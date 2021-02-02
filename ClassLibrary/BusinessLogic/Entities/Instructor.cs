using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Instructor
    {
        public Instructor()
        {
            Activities = new List<Activity>();
        }

        public Instructor(string address, string iban, string id, string name,
            int zipCode, string sn) : base(address, iban, id, name, zipCode)
        {
            Activities = new List<Activity>();
            Ssn = sn;
        }

        public Boolean estaDisponible(Days activityDays, TimeSpan duration, DateTime finishDate, DateTime startDate, DateTime startHour)
        {
            bool res = true;

            foreach(Activity act in Activities)
            {
                if(act.Colisiona(activityDays, duration, finishDate, startDate, startHour))
                {
                    res = false;
                }
                
            }
            return res;
        }

        public void getInstructorData(out String address, out String IBAN, out String name, out int zipCode,
            out String ssn, out ICollection<int> activitiesIds) {

            address = Address;
            IBAN = this.IBAN;
            name = Name;
            zipCode = ZipCode;
            ssn = Ssn;
            activitiesIds = new List<int>();

            foreach (Activity act in Activities)
            {
                activitiesIds.Add(act.Id);
            }
                

        }





    }
}
