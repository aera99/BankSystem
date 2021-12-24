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
        public User UserChange { get; set; }
        public string Loan { get; set; }
        public string PaymentLoan { get; set; }
        public LoanRepayment(User user)
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;
            UserChange = user;
            Loan = Convert.ToString(UserChange.Loan);
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
                            if (UserChange.Loan - Convert.ToDouble(PaymentLoan) >= 0)
                            {
                                UserChange.Loan -= Convert.ToDouble(PaymentLoan);
                                DialogResult = true;
                            }
                            else
                            {
                                Error error = new Error();
                                error.ShowDialog();
                            }
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
