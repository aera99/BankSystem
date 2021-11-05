using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModelBank
{
    public class VIP : Department
    {
        public VIP()
        {
            NameDepartment = "Отдел работы с VIP клиентами";
            PercentageOfCapitalization = 15;
            PercentageOfLoan = 3;
            Users = new ObservableCollection<User>();
        }
    }
}
