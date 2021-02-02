using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class User
    {
        public User()
        {
            Enrollments = new List<Enrollment>();

        }
        public User(string address, string iban, string id, string name, 
            int zipCode, DateTime birthDate, bool retired) :
            base(address, iban, id, name, zipCode)
        {
            BirthDate = birthDate;
            Retired = retired;
            Enrollments = new List<Enrollment>();
        }

        public Boolean UserEquals(String dni) {
            if (this.Id == dni) { return true; }
            else
            {
                return false;
            }
        }

        public void GetDataUser(out string address, out string iban, out string name,
            out int zipCode, out DateTime birthDate, out bool retired, out ICollection<int> enrollmentIds)
        {
            address = Address;
            iban = IBAN;
            name = Name;
            zipCode = ZipCode;
            birthDate = BirthDate;
            retired = Retired;
            enrollmentIds = new List<int>();
            foreach(Enrollment en in Enrollments) {
                enrollmentIds.Add(en.Id);
            }

        }

        public bool IsInActivity(int idActivity)
        {
            foreach(Enrollment e in Enrollments)
            {
                if (e.Activity.Id == idActivity) return true;
            }
            return false;
        }


    }
}
