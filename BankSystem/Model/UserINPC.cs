using BankSystem.ViewModel;
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
    public class UserINPC : Bindable
    {
        private string _firstName;
        private string _LastName;
        private int _age;
        private double _personalMoney;
        private double _depositMoney;
        private double _loan;
        private int _iD;
        private bool _capitalization;
        private int _percentageOfCapitalization;
        private int _percentageOfLoan;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return _LastName; }
            set
            {
                _LastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                OnPropertyChanged("Age");
            }
        }
        public double PersonalMoney
        {
            get { return _personalMoney; }
            set
            {
                _personalMoney = value;
                OnPropertyChanged("PersonalMoney");
            }
        }
        public double DepositMoney
        {
            get { return _depositMoney; }
            set
            {
                _depositMoney = value;
                OnPropertyChanged("DepositMoney");
            }
        }
        public double Loan
        {
            get { return _loan; }
            set
            {
                _loan = value;
                OnPropertyChanged("Loan");
            }
        }
        public int ID
        {
            get { return _iD; }
            set
            {
                _iD = value;
                OnPropertyChanged("ID");
            }
        }
        static int IDCounter;
        private bool _contribution;
        public bool Contribution
        {
            get { return _contribution; }
            set
            {
                _contribution = value;
                if (_contribution == true)
                {
                    StartDayContribution = DateTime.Now;
                }
                OnPropertyChanged("Contribution");
            }
        }
        public bool Capitalization
        {
            get { return _capitalization; }
            set
            {
                _capitalization = value;
                OnPropertyChanged("Capitalization");
            }
        }
        public DateTime StartDayContribution { get; set; }
        public int PercentageOfCapitalization
        {
            get { return _percentageOfCapitalization; }
            set
            {
                _percentageOfCapitalization = value;
                OnPropertyChanged("PercentageOfCapitalization");
            }
        }
        public int PercentageOfLoan
        {
            get { return _percentageOfLoan; }
            set
            {
                _percentageOfLoan = value;
                OnPropertyChanged("PercentageOfLoan");
            }
        }

        #region Данные для теста
        string[] FNames = new string[]
        {
                "Владислав","Вячеслав", "Юрий","Роман",
                "Иван","Павел","Виталий","Александр",
                "Никита","Алексей","Дмитрий","Василий"
        };

        string[] LNames = new string[]
        {
                "Иванов","Петров", "Петечкин","Васечкин",
                "Мышкин","Клавиатуркин","Мониторкин","Микрофонкин",
                "Кнопочкин","Экранкин","Програмкин","Консолькин"
        };
        Random random = new Random();
        #endregion

        #region конструкторы
        public UserINPC(string firstName, string lastName, int age, double personalMoney, double depositMoney, bool contribution, bool capitalization)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PersonalMoney = personalMoney;
            DepositMoney = depositMoney;
            ID = ++IDCounter;
            Contribution = contribution;
            Capitalization = capitalization;
            PercentageOfCapitalization = 13;
            PercentageOfLoan = 4;
        }

        //заполнение случайными данными для теста
        public UserINPC()
        {
            FirstName = FNames[random.Next(0, FNames.Length)];
            LastName = LNames[random.Next(0, LNames.Length)];
            Age = random.Next(18, 50);
            PersonalMoney = random.Next(20000, 2352359);
            ID = ++IDCounter;
            PercentageOfCapitalization = random.Next(10, 15);
            PercentageOfLoan = random.Next(3, 6);
        }
        #endregion

        public void ChangeAllInfo(UserINPC user)
        {
            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            PersonalMoney = user.PersonalMoney;
            DepositMoney = user.DepositMoney;
            Loan = user.Loan;
            ID = user.ID;
            Contribution = user.Contribution;
            Capitalization = user.Capitalization;
            StartDayContribution = user.StartDayContribution;
            PercentageOfCapitalization = user.PercentageOfCapitalization;
            PercentageOfLoan = user.PercentageOfLoan;
            //TODO узнать как можно заменить класс UserINPC на данный класс.
        }

        public void AddLoan(double loan)
        {
            Loan += loan;
            PersonalMoney += loan;
        }

        public void RepayLoan(double loan)
        {
            Loan -= loan;
            PersonalMoney -= loan;
        }
    }
}
