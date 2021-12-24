using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModelBank
{
    public class User 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int Age { get; set; }
        public double PersonalMoney { get; set; }
        public double DepositMoney { get; set; }
        public double Loan { get; set; }
        public int ID { get; set; }
        static int IDCounter;
        private bool contribution;
        public bool Contribution
        {
            get { return contribution; }
            set
            {
                contribution = value;
                if (contribution == true)
                {
                    StartDayContribution = DateTime.Now;
                }
            }
        }
        public bool Capitalization { get; set; }
        public DateTime StartDayContribution { get; set; }
        public int PercentageOfCapitalization { get; set; }
        public int PercentageOfLoan { get; set; }

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
        public User (string firstName , string lastName , int age , double personalMoney , double depositMoney, bool contribution , bool capitalization)
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
        public User()
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

        public void ChangeAllInfo(User user)
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
            //TODO узнать как можно заменить класс user на данный класс.
        }
    }
}
