using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Gym
    {
        public Gym()
        {
            Activities = new List<Activity>();
            Rooms = new List<Room>();
        }

        public Gym(DateTime ClosingHour, int DiscountLocal, int DiscountRetired, double FreeUserPrice, string name, DateTime OpeningHour, int ZipCode)
        {

            this.ClosingHour = ClosingHour;
            this.DiscountLocal = DiscountLocal;
            this.DiscountRetired = DiscountRetired;
            this.FreeUserPrice = FreeUserPrice;
            this.Name = name;
            this.OpeningHour = OpeningHour;
            this.ZipCode = ZipCode;
            Activities = new List<Activity>();
            Rooms = new List<Room>();

        }

        public ICollection<int> GetListAvailableRooms(Days activityDays, TimeSpan duration, DateTime finishDate, DateTime startDate, DateTime startHour)
        {
            ICollection<int> roomsAvaible = new List<int>();
            foreach (Room rom in Rooms)
            {
                bool res = rom.Ocupada(activityDays, duration, finishDate, startDate, startHour);
                if (res == false)
                {
                    roomsAvaible.Add(rom.Id);
                }
            }
            return roomsAvaible;
        }

        public bool RoomsDisponibles(Days activityDays, TimeSpan duration, DateTime finishDate, DateTime startDate, DateTime startHour, ICollection<int> roomsIds)
        {
            int contador = 0;
            ICollection<int> res = GetListAvailableRooms(activityDays, duration, finishDate, startDate, startHour);
            if (res.Count == 0 || roomsIds.Count == 0)
            {
                return false;
            }
            else
            {
                foreach (int id in roomsIds)
                {
                    foreach (int ids in res)
                    {
                        if (id == ids) { contador++; }
                    }
                }
                if (contador != roomsIds.Count) { return false; }
            }
            return true;
        }

        public Dictionary<DateTime, int> GetListAvailableRoomsPerWeek(DateTime initialMonday)
        {
            Dictionary<DateTime, int> taula = new Dictionary<DateTime, int>();
            TimeSpan interval = new TimeSpan(0, 45, 0);
            //DateTime local = initialMonday.Date;
            for (int i = 0; i < 7; i++)
            {
                DateTime local = initialMonday.AddDays(i);
                DateTime local2 = OpeningHour;

                while (local2.TimeOfDay < ClosingHour.TimeOfDay)
                {
                    int total = GetListAvailableRooms(returnDays(i+1), interval, local.Date, local.Date, local2).Count();
                    taula.Add(local.Date.AddHours(local2.Hour).AddMinutes(local2.Minute).AddSeconds(local2.Second), total);
                    local2 = local2.AddMinutes(45);
                    
                }
            }
            return taula;

        }

        public Activity getActivity(int id)
        {
            Activity res = null;
            foreach (Activity act in Activities) { if (id == act.Id) res = act; }
            return res;
        }

        //public ICollection<int> GetAllActivitiesIds()
        //{

        //    ICollection<int> listaIds = new List<int>();
        //    foreach (Activity act in Activities)
        //    {
        //        int idAct = act.Id;
        //        listaIds.Add(idAct);
        //    }

        //    if (listaIds == null)
        //    {
        //        throw new Exception("No existe ninguna actividad\n");
        //    }
        //    else { return listaIds; }
        //}

        public void GetActivityDataFromId(int ActivityId)
        {

            foreach (Activity act in Activities)
            {

                if (act.Id == ActivityId)
                {
                    act.ToString();
                    if (act.Instructor != null)
                    {
                        Console.WriteLine("Ya tiene un monitor asignado\n");
                    }
                }
                else { throw new Exception("No existe esa actividad\n"); }

            }

        }

        public Days returnDays(int day)
        {
            int caseSwitch = day;

            switch (caseSwitch)
            {
                case 5:
                    return Days.Fri;
                case 6:
                    return Days.Sat;
                case 7:
                    return Days.Sun;
                case 4:
                    return Days.Thu;
                case 2:
                    return Days.Tue;
                case 3:
                    return Days.Wed;
                case 1:
                    return Days.Mon;
                default:
                    return Days.None;
            }
        }

        public void GetGymData(out int gymId, out DateTime closingHour, out int discountLocal, out int discountRetired, out double freeUserPrice, out string name,
    out DateTime openingHour, out int zipCode, out ICollection<int> activityIds, out ICollection<int> roomIds)
        {
            gymId = ID;
            closingHour = ClosingHour;
            discountLocal = DiscountLocal;
            discountRetired = DiscountRetired;
            freeUserPrice = FreeUserPrice;
            name = Name;
            openingHour = OpeningHour;
            zipCode = ZipCode;
            activityIds = new List<int>();
            foreach (Activity a in Activities) { activityIds.Add(a.Id); }
            roomIds = new List<int>();
            foreach (Room r in Rooms) { roomIds.Add(r.Id); }
        }

        public ICollection<Room> GetRooms()
        {
            return Rooms;
        }

            public Room getRoom(int idR)
        {
            foreach(Room room in Rooms)
            {
                if(idR == room.Id)
                {
                    return room;
                }
            }
            return null;
        }

        public ICollection<int> obtenerTodasLasActividades()
        {
            //Creamos unas lista que contiene Todos los ids de las actividades,inicialmente vacia
            ICollection<int> listaIds = new List<int>();

            //Recorremos la lista de Actividades añadiendo los ids de las actividades a la lista
            foreach (Activity act in Activities)
            {
                int idAct = act.Id;
                listaIds.Add(idAct);
            }

            return listaIds; 
        }

        public ICollection<int> GetIdActivities(ICollection<Activity> listaActivitiesIds)
        {
            ICollection<int> idActivities = new List<int>();
            foreach (Activity act in listaActivitiesIds)
            {
                idActivities.Add(act.Id);
            }
            return idActivities;
        }


       
        public ICollection<int> GetAllRunningOrFutureActivitiesIds()
        {
            List<int> res = new List<int>();
            DateTime today = DateTime.Today;
            foreach (Activity activity in Activities)
            {
                if (DateTime.Compare(today, activity.FinishDate) < 0)
                    res.Add(activity.Id);
            }
            return res;
        }


        public double CalculoDescuentos(bool retired, int zipCode, Activity activity)
        {
            if (retired && zipCode == ZipCode) { return activity.Price - (activity.Price * DiscountRetired / 100) - (activity.Price * DiscountLocal / 100); }
            else if (retired) { return activity.Price - (activity.Price * DiscountRetired / 100); }
            else if (zipCode == ZipCode) { return activity.Price - (activity.Price * DiscountLocal / 100); }
            else { return activity.Price; }
        }



    }
}
