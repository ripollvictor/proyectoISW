using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Enrollment
    {
        public Enrollment()
        {
            Payments = new List<Payment>();
        }
        public Enrollment(DateTime enrollmentDate, Activity activity,
            Payment payment, User user) : this()
        {
            CancellationDate = null;
            EnrollmentDate = enrollmentDate;
            ReturnedFirstCuotaIfCancelledActivity = null;
            //Id is managed by EE
            Activity = activity;
            Payments.Add(payment);
            User = user;
        }

        public void GetDataEnrollment(out DateTime? cancellationDate, out DateTime enrollmentDate,
            out DateTime? returnedFirstCuotaIfCancelledActivity, out ICollection<int> paymentIds, out string userId)
        {
            cancellationDate = this.CancellationDate;
            enrollmentDate = EnrollmentDate;
            returnedFirstCuotaIfCancelledActivity = ReturnedFirstCuotaIfCancelledActivity;
            paymentIds = new List<int>();
            foreach(Payment p in Payments) { paymentIds.Add(p.Id); }
            userId = User.Id;
        }

    }
}
