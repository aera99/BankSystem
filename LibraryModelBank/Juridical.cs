using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModelBank
{
    public class Juridical : Department
    {
        public Juridical()
        {
            NameDepartment = "Отдел работы с юридическими клиентами";
            PercentageOfCapitalization = 13;
            PercentageOfLoan = 4;
            Users = new ObservableCollection<User>();
        }
    }
}
