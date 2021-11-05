using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModelBank
{
    public class Defolt : Department
    {
        public Defolt ()
        {
            NameDepartment = "Отдел работы с обычными клиентами";
            PercentageOfCapitalization = 11;
            PercentageOfLoan = 5;
            Users = new ObservableCollection<User>();
        }
    }
}
