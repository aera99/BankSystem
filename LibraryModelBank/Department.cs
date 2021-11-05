using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModelBank
{
    public abstract class Department
    {
        public string NameDepartment { get; set; } 
        public ObservableCollection<User> Users { get; set; }
        public int PercentageOfCapitalization { get; set; }
        public int PercentageOfLoan { get; set; }
        public DateTime Time
        {
            get { return Time; }
            set
            {
                bool recalculation = false;
                if (Time.Month < value.Month)
                {
                    recalculation = true;
                }
                Time = value;
                if (recalculation == true)
                {
                    CapitalizationPayments();
                }
            }
        }

        private void CapitalizationPayments()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if ((Users[i].Contribution == true) || (Users[i].Capitalization == true))
                {
                    Users[i].DepositMoney += (Users[i].DepositMoney * (PercentageOfCapitalization / 100)) / 12;

                    if (Users[i].StartDayContribution.Year >= Time.Year)
                    {
                        Users[i].Contribution = false;
                    }
                }
                if ((Users[i].Contribution == true) || (Users[i].Capitalization == false))
                {
                    if (Users[i].StartDayContribution.Year >= Time.Year)
                    {
                        Users[i].PersonalMoney += (Users[i].DepositMoney * (PercentageOfCapitalization / 100));
                        Users[i].DepositMoney = 0;
                        Users[i].Contribution = false;
                    }
                }
            }
        }
        public void RandomFilling()
        {
            Users.Add(new User());
        }
    }
}
