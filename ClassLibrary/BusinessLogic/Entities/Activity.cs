using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Activity
    {
        public Activity()
        {
            Enrollments = new List<Enrollment>();
            Rooms = new List<Room>();
        }
        public Activity(Days ActivityDays, string Description, TimeSpan Duration, DateTime FinishDate, int MaximumEnrollments, 
            int MinimumEnrollments, double Price, DateTime StartDate, DateTime StartHour): this()
        {
            this.ActivityDays = ActivityDays;
            this.Cancelled = false;
            this.Description = Description;
            this.Duration = Duration;
            this.FinishDate = FinishDate;
            this.MaximumEnrollments = MaximumEnrollments;
            this.MinimumEnrollments = MinimumEnrollments;
            this.Price = Price;
            this.StartDate = StartDate;
            this.StartHour = StartHour;
        }

        public bool Colisiona(Days activityDays, TimeSpan duration, DateTime finishDate, DateTime startDate, DateTime startHour) {
            if ((this.ActivityDays & activityDays) == Days.None)
            {
                return false;
            }
            else if (this.FinishDate.Date < startDate || finishDate < StartDate.Date)
            {
                return false;
            }
            else {
                DateTime FinishHour = startHour + duration;
                DateTime FinishHourThis = this.StartHour + this.Duration;
                if (FinishHour.TimeOfDay < this.StartHour.TimeOfDay || FinishHourThis.TimeOfDay < startHour.TimeOfDay) {
                    return false;
                }
            }
            return true;
        }

        
        public Enrollment GetEnrollment(int EnrId)
        {
            foreach(Enrollment e in Enrollments)
            {
                if(e.Id == EnrId) { return e; }
            }
            return null;
        }

        public ICollection<int> GetIdEnrollments(ICollection<Enrollment> listaEnrollments)
        {
            ICollection<int> idEnrollments = new List<int>();
            foreach (Enrollment enroll in listaEnrollments)
            {
                idEnrollments.Add(enroll.Id);
            }
            if (idEnrollments == null)
            {
                throw new Exception("No hay ninguna inscripción.");
            }
            else { return idEnrollments; }

        }

        public ICollection<int> GetIdRooms(ICollection<Room> listaRooms)
        {
            ICollection<int> idRooms = new List<int>(); 
            foreach (Room room in listaRooms)
            {
                idRooms.Add(room.Id);
            }
            if (idRooms == null)
            {
                throw new Exception("No hay ninguna sala.");
            }
            else { return idRooms; }

        }

        public bool UserInActivity(ICollection<int> enrollmentsId)
        {
            foreach (int eId in enrollmentsId)
            {
                foreach (Enrollment e in Enrollments)
                {
                    if (e.Id == eId) { return true; }
                }

            }
            return false;
        }







    }
}
