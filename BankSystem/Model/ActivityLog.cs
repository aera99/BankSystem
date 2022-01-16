using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    public class ActivityLog
    {
        public DateTime TimeOperation { get; set; }
        public int ID { get; set; }
        public string FullNameUser { get; set; }
        public string TypeOperations { get; set; }
        public double Sum { get; set; }

        public ActivityLog(UserINPC user , string typeOperations , double sum)
        {
            TimeOperation = DateTime.Now;
            ID = user.ID;
            FullNameUser = user.FullName;
            TypeOperations = typeOperations;
            Sum = sum;
        }
    }
}
