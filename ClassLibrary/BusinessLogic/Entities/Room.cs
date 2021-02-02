using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDep.Entities
{
    public partial class Room
    {

        public Room() {
            Activities = new List<Activity>();
        }

        public Room(int Number) {
            this.Number = Number;
            Activities = new List<Activity>();

        }

        public bool Ocupada(Days activityDays, TimeSpan Duration, DateTime FinishDate, DateTime StartDate, DateTime StartHour)
        {
            foreach (Activity act in Activities) {
                bool res = act.Colisiona(activityDays,  Duration,  FinishDate,  StartDate,  StartHour);
                if (res == true) { return true; }
            }
            return false;
        }

        public void getActivityIds(out ICollection<int> res, out int number) {
            ICollection<int> resultat = new List<int>();
            foreach (Activity act in Activities) {
                resultat.Add(act.Id);
            }
            res = resultat;
            number = res.Count;
        }
                
        




    }
}
