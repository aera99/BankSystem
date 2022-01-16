using BankSystem.Model;
using BankSystem.ViewModel;
using LibraryModelBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BankSystem.View
{
    /// <summary>
    /// Логика взаимодействия для LoanSetting.xaml
    /// </summary>
    public partial class LoanSetting : Window
    {
        public UserINPC CreditUser { get; set; }
        public string FullName { get; set; }
        public double PersonalMoney { get; set; }
        public int PercentageOfLoan { get; set; }
        public double AddLoan { get; set; }

        public LoanSetting(UserINPC user)
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;
            CreditUser = user;
            FullName = user.FullName;
            PersonalMoney = user.PersonalMoney;
            PercentageOfLoan = user.PercentageOfLoan;
        }

        private RelayCommand accept;
        public RelayCommand Accept
        {
            get
            {
                return accept ??
                    (accept = new RelayCommand(obj =>
                    {
                        try
                        {
                            CreditUser.Loan += AddLoan;
                            DialogResult = true;
                        }
                        catch (FormatException)
                        {
                            Error error = new Error();
                            error.ShowDialog();
                        }
                    }));
            }
        }
    }
}