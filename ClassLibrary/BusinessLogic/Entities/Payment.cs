using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Payment
    {
        public Payment()
        {
        }

        public Payment(DateTime date, string description, double Quantity)
        {
            this.Date = date;
            this.Description = description;
            this.Quantity = Quantity;
        }

        public void GetDataPayment(out DateTime date, out string description, out double quantity)
        {
            date = Date;
            description = Description;
            quantity = Quantity;
        }
    }
}
