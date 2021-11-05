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
        public User CreditUser { get; set; }

        public LoanSetting(User user , int percentageOfLoan)
        {
            InitializeComponent();
            this.Focus();
            CreditUser = user;
            FIO.Text += user.FullName;
            Balance.Text += Convert.ToString(user.PersonalMoney);
            Procent.Text += Convert.ToString(percentageOfLoan) + " %" ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextSum.Text != null)
            {
                try
                {
                    CreditUser.Loan = Convert.ToDouble(TextSum.Text);
                    DialogResult = true;
                }
                catch (FormatException)
                {
                    Error error = new Error();
                    error.ShowDialog();
                }
            }
        }
    }
}