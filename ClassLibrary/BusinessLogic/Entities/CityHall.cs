using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class CityHall
    {
        public CityHall()
        {
            People = new List<Person>();
            Payments = new List<Payment>();
            Gyms = new List<Gym>();
        }

        public CityHall(string Name) : this()
        {
            this.Name = Name;
        }

        public bool ExistUser(string dni)
        {
            bool res = false;

            foreach (Person person in People)
            {
                if (person.Id == dni) { res = true; break; }
            }

            return res;
        }


        public User getUser(string userId)
        {
            foreach (Person person in People)
            {

                if (person is User && person.Id == userId) // person.GetType().Equals("User") &&
                {
                    return person as User;
                }

            }
            return null;
        }

        public Payment GetPayment(int paymentId)
        {
            foreach(Payment p in Payments)
            {
                if(p.Id == paymentId)
                {
                    return p;
                }
            }
            return null;
        }
        public bool ExistsGym()
        {
            return Gyms.Count()>0;
        }

        public ICollection<Instructor> GetInstructors()
        {
            //Lista de Instructores inicialmente vacía
            ICollection<Instructor> listaInstructor = new List<Instructor>();

            //Recorremos la lista de Instructores y los añadimos a la lista creada
            foreach (Person ins in People)
            {
                if (ins is Instructor)
                {
                    listaInstructor.Add(ins as Instructor);
                }
            }

            return listaInstructor;
        }

        

        public Instructor getInstructor(string instructorId)
        {
            foreach (Person ins in People)  
            {

                if (ins is Instructor && ins.Id == instructorId) 
                {
                    return ins as Instructor;
                    
                }

            }
            return null;
        }

        public bool comprobarLongitud(string id)
        {
            bool correcta = true;

            if(id.Length != 9)
            {
                correcta = false;

            }

            return correcta;
        }
        





    }

   
}
