using GestDep.Entities;
using GestDep.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestDep.Services
{
    public class GestDepService : IGestDepService
    {
        private readonly IDAL dal; //Persistence Layer Interface
        public CityHall cityHall;  //Services only work on a City Hall
        public Gym gym;            // Gym of the City Hall. Also available from cityHall.Gyms.First();

        /// </summary>
        /// Returns a service Layer connected with the persistence Layer. Retrieves the CitiHall and Gym from the database if they exist. If not, it creates new ones
        /// </summary>
        /// <param name="dal"> Persistence Layer Interface</param>

        public GestDepService(IDAL dal)
        {
            this.dal = dal;
            try
            {

                if (dal.GetAll<CityHall>().Count() == 0) //No cityHall in the system. Data initilization. 
                {
                    bool CLEAR_DATABASE = true;
                    int ROOMS_NUMBER = 9;
                    int INSTRUCTORS_NUMBER = 5;
                    Populate populateDB = new Populate(CLEAR_DATABASE, dal);
                    cityHall = populateDB.InsertCityHall();
                    gym = populateDB.InsertGym(cityHall);     //Also in cityHall.First();                
                    populateDB.InsertRooms(ROOMS_NUMBER, gym);  //Now available from gym.rooms;
                    populateDB.InsertInstructors(INSTRUCTORS_NUMBER, cityHall); //Now available from cityHall.People;

                }
                else
                {   //Retrieve the CityHall stored
                    cityHall = dal.GetAll<CityHall>().First();

                    if (cityHall.Gyms.Count > 0)
                    { //Retrieve the Gym stored
                        gym = cityHall.Gyms.First();

                    }
                    else
                    { //Adding Rooms and Gym
                        bool MANTAIN_DATABASE = false;
                        int ROOMS_NUMBER = 9;
                        Populate populateDB = new Populate(MANTAIN_DATABASE, dal);
                        gym = populateDB.InsertGym(cityHall);
                        populateDB.InsertRooms(ROOMS_NUMBER, gym);
                    }
                    int INSTRUCTORS_NUMBER = 5;
                    if (dal.GetAll<Instructor>().Count() == 0)//No instructors
                    {
                        bool MANTAIN_DATABASE = false;
                        Populate populateDB = new Populate(MANTAIN_DATABASE, dal);
                        populateDB.InsertInstructors(INSTRUCTORS_NUMBER, cityHall); //Now available from cityHall.People;
                    }

                }
            } catch (Exception e)
            {
                throw new ServiceException("Error in the service init process", e);

            }
        }

        public Days returnDays(int day) {
            return gym.returnDays(day);
        }
        public int AddNewActivity(Days activityDays, string description, TimeSpan duration, DateTime finishDate, int maximumEnrollments,
            int minimumEnrollments, double price, DateTime startDate, DateTime startHour, ICollection<int> roomsIds)
        {
            //Comprovacions previes
            if (maximumEnrollments < 0 || maximumEnrollments < minimumEnrollments || minimumEnrollments < 0) { throw new ServiceException("Els enrrolments no son correctes"); }
            if (startHour.TimeOfDay < gym.OpeningHour.TimeOfDay || startHour.TimeOfDay > gym.ClosingHour.TimeOfDay 
                    || startHour.TimeOfDay.Add(duration) > gym.ClosingHour.TimeOfDay) { throw new ServiceException("L'hora d'inici ha d'estar dins l'horari del Gimnàs"); }
            if (startDate > finishDate || startDate < DateTime.Now || activityDays == Days.None) { throw new ServiceException("Les dates no son correctes"); }
            if (duration < TimeSpan.Zero) { throw new ServiceException("Duració incorrecta"); }
            if (price < 0) { throw new ServiceException("Preu incorrecte"); }
            if (roomsIds == null)
            {
                throw new ServiceException("Rooms incorrectes");
            }
            //Comprovem si les rooms estan disponibles per a l'horari de la nova activitat
            if (!gym.RoomsDisponibles(activityDays, duration, finishDate, startDate, startHour,roomsIds)) 
            { 
                throw new ServiceException("Rooms ocupades"); 
            }
            else {
                //Creació de l'activitat 
                Activity act = new Activity(activityDays, description, duration, finishDate, maximumEnrollments,
                minimumEnrollments, price, startDate, startHour);
                //afegir rooms a l'activitat i activitat a cada room
                foreach (int id in roomsIds)
                {
                    Room r = gym.getRoom(id);
                    act.Rooms.Add(r);
                    r.Activities.Add(act);

                }
                gym.Activities.Add(act);
                SaveChanges();
                return act.Id;

            }
        }

        public void AddNewUser(string address, string iban, string id, string name, int zipCode, DateTime birthDate, bool retired)
        {
            //comprovacions previes
            if (address == "" || id.Length != 9 || iban == ""|| name == "" || zipCode <= 0 || birthDate > DateTime.Now) 
            {
                throw new ServiceException("Dades no correctes"); 
            }
            // comprovació que l'ultim caracter del ID es una lletra
            char letra = id[8];
            string numeros = id.Remove(8);
            foreach (Char num in numeros) { if (!Char.IsNumber(num) || !Char.IsLetter(letra)) { throw new ServiceException("DNI incorrecte."); } }

            if (!cityHall.ExistUser(id)) {
                User usuario = new User(address, iban, id, name, zipCode, birthDate, retired);
                cityHall.People.Add(usuario);
                SaveChanges();
            }
            else { throw new ServiceException("L'usuari ja existeix"); }
           
        }

        public void AssignInstructorToActivity(int activityId, string instructorId)
        {
            //  Comprobamos que el ID del Actividad no sea negativo
            if(activityId < 0)
            {
                throw new ServiceException("ActivityId negativo");
            }
            //Llamamos al metodo de la clase gym , getActivity, y le pasamos como parametro el activityId de la actividad
            //EL método comprueba si el ID que le pasamos coincide con el ID de alguna actividad de la lista de Actividades
            //Si da resultado creamos un objeto Actividad con ese Id
            Activity actividad = gym.getActivity(activityId);

            if(actividad == null)
            {
                throw new ServiceException("No existe ninguna actividad con ese Id");
            }

            if(instructorId.Length != 9)
            {
                throw new ServiceException("El Id del instructor no es correcto");
            }

            //llamamos al metodo de la clase cityHall,getInstructor, y le pasamos como parametros el instructorId
            //Este método comprueba si el Id que le pasamos coincide con el ID de algun instructor de la lista de Instructores
            //si es asi lo devuelve y se crea un objeto Instructor con ese Id
            Instructor ins = cityHall.getInstructor(instructorId);

            if(ins == null)
            {
                throw new ServiceException("No existe ningun instructor con este Id");
                
            }

            //Comprobamos si el instructor esta disponible o no para realaizar esa actividad a las horas deseadas

            if (!ins.estaDisponible(actividad.ActivityDays, actividad.Duration, actividad.FinishDate, actividad.StartDate, actividad.StartHour)) {
                throw new ServiceException("No esta disponible");            
            }

          // Añadimos la actividad al instructor
            ins.Activities.Add(actividad);
            //Añadimos el instructor a la actividad
            actividad.Instructor = ins;
            SaveChanges();

          
        }

        public int EnrollUserInActivity(int activityId, string userId)
        {
            Activity act = gym.getActivity(activityId);
            if (!cityHall.ExistUser(userId) || act == null)
            {
                throw new ServiceException("El usuari i/o l'activitat no existeixen.");
            }
            else if (act.MaximumEnrollments <= act.Enrollments.Count())
            {
                throw new ServiceException("Maxim nombre d'usuaris inscrits a l'activitat.");
            } 
            else
            {
              
                DateTime ara = DateTime.Now;
                User usuari = cityHall.getUser(userId);
                if (usuari.IsInActivity(activityId)) throw new ServiceException("El usuari ja es troba inscrit a l'activitat.");
                Payment pagament = new Payment(ara, "", gym.CalculoDescuentos(usuari.Retired, usuari.ZipCode, act));
                Enrollment nuevo = new Enrollment(ara, act, pagament, usuari);
                pagament.Enrollment = nuevo;
                act.Enrollments.Add(nuevo);
                usuari.Enrollments.Add(nuevo);
                cityHall.Payments.Add(pagament);
                SaveChanges();
                return nuevo.Id;
            }

        }

        public void GetActivityDataFromId(int ActivityId, out Days activityDays, out String description, out TimeSpan duration,
            out DateTime finishDate, out int maximumEnrollments, out int minimumEnrollments, out double price,
            out DateTime startDate, out DateTime startHour, out ICollection<int> enrollmentIds,
            out String instructorId, out ICollection<int> roomIds)
        {

            Boolean encontrada = false;
            Activity actividad = null;

            foreach (Activity act in gym.Activities)
            {
                if (act.Id == ActivityId)
                {
                    encontrada = true;
                    actividad = act;
                }
            }
                if (encontrada && actividad != null)
                {
                    activityDays = actividad.ActivityDays;
                    description = actividad.Description;
                    duration = actividad.Duration;
                    finishDate = actividad.FinishDate;
                    maximumEnrollments = actividad.MaximumEnrollments;
                    minimumEnrollments = actividad.MinimumEnrollments;
                    price = actividad.Price;
                    startDate = actividad.StartDate;
                    startHour = actividad.StartHour;
                    enrollmentIds = actividad.GetIdEnrollments(actividad.Enrollments);
                    if (actividad.Instructor == null) { instructorId = ""; }
                    else { instructorId = actividad.Instructor.Id; }
                    roomIds = actividad.GetIdRooms(actividad.Rooms);

                } else {
                    throw new ServiceException("No existe ninguna actividad");
                     }

              
                
            
        }

        public ICollection<int> GetAllActivitiesIds()
            {

            //Creamos una Lista donde almacenamos todos los Ids de las actividades de la lista de Activities,llamando a un metodo de la clase Gym
            ICollection<int> listaIds = gym.obtenerTodasLasActividades();

            if (listaIds == null)
            {
                throw new ServiceException("No existe ninguna actividad\n");
            }
            else { return listaIds; }

            }

        public ICollection<int> GetAllRunningOrFutureActivitiesIds()
        {
            ICollection<int> AllRunnningOrFutureActivities = gym.GetAllRunningOrFutureActivitiesIds();
            if (AllRunnningOrFutureActivities.Count() < 1) { throw new ServiceException("No hi han activitats actuals o futures."); }

            return AllRunnningOrFutureActivities;
        }

        public ICollection<string> GetAvailableInstructorsIds(Days activityDays, TimeSpan duration, DateTime finishDate, DateTime startDate, DateTime startHour)
        {

            //Comprobamos previamente los horarios de las actividades y su duracion
            if (startDate > finishDate || startDate < DateTime.Now || activityDays == Days.None) { throw new ServiceException("Les dates no son correctes"); }
            if (duration < TimeSpan.Zero) { throw new ServiceException("Duració incorrecta"); }

            //Lista con los Ids de los instructores que estan disponibles,inicialmente vacia
            ICollection<string> listaInstructorIds = new List<string>();

            //Lista de Instructores con todos los instructores q obtenemos llamando al metodo de cityHall
            ICollection<Instructor> listaInstructores = cityHall.GetInstructors();
            
            //Recorremos la listaInstructores creada y comprobamos que ese instructor esta disponible y la actividad no se solapa, si es asi añadimos a la lista listaInstructorsId el id de ese Instructor
                foreach (Instructor instructor in listaInstructores) {
                    
                   if(instructor.estaDisponible(activityDays,duration,finishDate,startDate,startHour) ){

                        listaInstructorIds.Add(instructor.Id);
                   }

                }
          return listaInstructorIds; 

            
        }

        public void GetEnrollmentDataFromIds(int activityId, int enrollmentId, out DateTime? cancellationDate, out DateTime enrollmentDate,
            out DateTime? returnedFirstCuotaIfCancelledActivity, out ICollection<int> paymentIds, out string userId)
        {
            Activity activity = gym.getActivity(activityId);
            if(activity == null) throw new ServiceException("No existeix l'Activitat");
            Enrollment enrollment = activity.GetEnrollment(enrollmentId);

            if (enrollment is null) throw new ServiceException("No existeix el Enrollment");

            enrollment.GetDataEnrollment(out cancellationDate, out enrollmentDate,
                    out returnedFirstCuotaIfCancelledActivity, out paymentIds, out userId);
            
        }

        public void GetGymData(out int gymId, out DateTime closingHour, out int discountLocal, out int discountRetired, out double freeUserPrice, out string name, out DateTime openingHour, out int zipCode, out ICollection<int> activityIds, out ICollection<int> roomIds)
        {
                if (!cityHall.ExistsGym()) { throw new ServiceException("No existeixen gyms."); }
            gym.GetGymData(out gymId, out closingHour, out discountLocal, out discountRetired,
                out freeUserPrice, out name, out openingHour, out zipCode, out activityIds, out roomIds);
        }

        public void GetInstructorDataFromId(string instructorId, out String address, out String IBAN, out String name, out int zipCode,
                out String ssn, out ICollection<int> activitiesIds)
        {
                if(instructorId.Length != 9)
                {
                    throw new ServiceException("Id del monitor inválido");
                }

            Instructor ins = cityHall.getInstructor(instructorId);
  
            if(ins == null)
            {
                throw new ServiceException("No existe un monitor con ese Id");
            }

            ins.getInstructorData(out address, out  IBAN, out  name, out  zipCode,
            out  ssn, out activitiesIds);
            
                SaveChanges();
           
            }

        public ICollection<int> GetListAvailableRoomsIds(Days activityDays, TimeSpan duration, DateTime finishDate, DateTime startDate, DateTime startHour)
        {
            //comprovacions previes
            if (startDate > finishDate || startDate < DateTime.Now || activityDays == Days.None) { throw new ServiceException("Les dates no son correctes"); }
            if (duration < TimeSpan.Zero) { throw new ServiceException("Duració incorrecta"); }
            //Agafem la llista de rooms disponibles per a aquestes dates
            ICollection<int> res = gym.GetListAvailableRooms(activityDays, duration, finishDate, startDate, startHour);
            return res;
        }

        public Dictionary<DateTime, int> GetListAvailableRoomsPerWeek(DateTime initialMonday)
        {
            if(initialMonday.DayOfWeek != DayOfWeek.Monday) { throw new ServiceException("No es lunes."); }
            Dictionary<DateTime, int> res = gym.GetListAvailableRoomsPerWeek(initialMonday);
            if (res.Count == 0) {
                throw new ServiceException("No hi han Rooms disponibles per a aquestes dades.");
            }
            return res;
            //if (initialMonday.DayOfWeek == DayOfWeek.Monday) { Dictionary<DateTime, int> res = gym.GetListAvailableRoomsPerWeek(initialMonday); }
            //else { return res; }
            // throw new NotImplementedException();
        }

        public void GetPaymentDataFromId(int paymentId, out DateTime date, out string description, out double quantity)
        {
            Payment pagament = cityHall.GetPayment(paymentId);
            if (pagament == null) throw new ServiceException("No existeix el pagament.");

            pagament.GetDataPayment(out date, out description, out quantity);
            
        }

        public void GetRoomDataFromId(int roomId, out int number, out ICollection<int> activityIds)
        {
            Room rom = gym.getRoom(roomId);
            if (rom == null)
            {
                throw new ServiceException("No existeix la room");
            }
            else {
                rom.getActivityIds(out activityIds, out number);

            }
        }

        public void GetUserDataFromId(string userId, out string address, out string iban, out string name, out int zipCode,
            out DateTime birthDate, out bool retired, out ICollection<int> enrollmentIds)
        {
            User usuari = cityHall.getUser(userId);
            if (usuari == null) { throw new ServiceException("No s'ha trobat l'usuari."); }
            usuari.GetDataUser(out address, out iban, out name, out zipCode, out birthDate, out retired, out enrollmentIds);

        }

        public ICollection<int> GetRooms() {
            ICollection<int> res = new List<int>();
            ICollection<Room> roms = gym.GetRooms();
            foreach (Room rom in roms) {
                res.Add(rom.Id);
            
            }
            return res;
        }

        public double GetUserDataNotInActivityAndFirstQuota(int activityId, string userId, out string address, out string iban, out string name,
            out int zipCode, out DateTime birthDate, out bool retired, out ICollection<int> enrollmentIds)
        {
            Activity activity = gym.getActivity(activityId);


            if (activity == null) { throw new ServiceException("No existeix l'activitat."); }
            
            User user = cityHall.getUser(userId);
            if(user == null) { throw new ServiceException("No existeix l'usuari."); }
            user.GetDataUser(out address, out iban, out name, out zipCode, out birthDate, out retired, out enrollmentIds);

            if(activity.UserInActivity(enrollmentIds)) { throw new ServiceException("Usuari ja registrat a l'activitat"); }          

            return gym.CalculoDescuentos(retired, zipCode, activity);
        }

        public DateTime CalcularLunes(DateTime fecha)
        {
            //var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            return fecha.AddDays(-(int)fecha.DayOfWeek + (int)DayOfWeek.Monday);
        }

        #region Connection with the Persistence Layer
        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }


        public void SaveChanges()
        {
            dal.Commit();
        }
        #endregion
        }
}



