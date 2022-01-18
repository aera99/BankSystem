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
    /// Логика взаимодействия для LoanRepayment.xaml
    /// </summary>
    public partial class LoanRepayment : Window
    {
        public UserINPC UserChange { get; set; }
        public double Loan { get; set; }
        public double PaymentLoan { get; set; }
        public LoanRepayment(UserINPC user)
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;
            UserChange = user;
            Loan = UserChange.Loan;
        }

        private void ShowError()
        {
            Error error = new Error();
            error.ShowDialog();
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
                            if (UserChange.Loan - PaymentLoan >= 0 && PaymentLoan > 0 && UserChange.PersonalMoney >= PaymentLoan)
                            {
                                UserChange.RepayLoan(PaymentLoan);
                                DialogResult = true;
                            }

                            else ShowError();
                        }
                        catch (FormatException)
                        {
                            ShowError();
                        }
                    }));
            }
        }
    }
}
