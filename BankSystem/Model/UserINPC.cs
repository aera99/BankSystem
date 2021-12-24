using LibraryModelBank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    public class UserINPC : User , INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private double _personalMoney;
        private double _depositMoney;
        private double _loan;
        private int _iD;
        private bool _capitalization;
        public new string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public new string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public new int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        public new double PersonalMoney
        {
            get { return _personalMoney; }
            set
            {
                _personalMoney = value;
                OnPropertyChanged("PersonalMoney");
            }
        }
        public new double DepositMoney
        {
            get { return _depositMoney; }
            set
            {
                _depositMoney = value;
                OnPropertyChanged("DepositMoney");
            }
        }
        public new double Loan
        {
            get { return _loan; }
            set
            {
                _loan = value;
                OnPropertyChanged("Loan");
            }
        }
        public new int ID
        {
            get { return _iD; }
            set
            {
                _iD = value;
                OnPropertyChanged("ID");
            }
        }
        public new bool Capitalization
        {
            get { return _capitalization; }
            set
            {
                _capitalization = value;
                OnPropertyChanged("FirstName");
            }
        }

        //public UserINPC(string firstName, string lastName, int age, double personalMoney, double depositMoney, bool contribution, bool capitalization)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    Age = age;
        //    PersonalMoney = personalMoney;
        //    DepositMoney = depositMoney;
        //    ID = ++IDCounter;
        //    Contribution = contribution;
        //    Capitalization = capitalization;
        //    PercentageOfCapitalization = 13;
        //    PercentageOfLoan = 4;
        //}

        //public UserINPC()
        //{
        //    FirstName = FNames[random.Next(0, FNames.Length)];
        //    LastName = LNames[random.Next(0, LNames.Length)];
        //    Age = random.Next(18, 50);
        //    PersonalMoney = random.Next(20000, 2352359);
        //    ID = ++IDCounter;
        //    PercentageOfCapitalization = random.Next(10, 15);
        //    PercentageOfLoan = random.Next(3, 6);
        //}
        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
