using LibraryModelBank;
using BankSystem.ViewModel;
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
    /// Логика взаимодействия для UserSetting.xaml
    /// </summary>
    public partial class UserSetting : Window
    {
        public User user { get; set; }
        public UserSetting()
        {
            InitializeComponent();
            this.Focus();
            user = new User();
        }
        public UserSetting(User user)
        {
            InitializeComponent();
            this.Focus();
            this.user = user;

            TextName.Text = this.user.FirstName;
            TextLName.Text = this.user.LastName;
            TextAge.Text = Convert.ToString(this.user.Age);
            TextMoney.Text = Convert.ToString(this.user.PersonalMoney);
            CheckContribution.IsChecked = user.Contribution;
            if (CheckContribution.IsChecked == true)
            {
                OnCapitalization.IsEnabled = true;
                OffCapitalization.IsEnabled = true;
                OnCapitalization.IsChecked = user.Capitalization;
                if (OnCapitalization.IsChecked == false)
                {
                    OffCapitalization.IsChecked = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if ((TextName.Text != null) || (TextLName.Text != null) || (TextAge.Text != null) || (TextMoney.Text != null))
            {
                try
                {
                    user.Age = Convert.ToInt32(TextAge.Text);
                    user.PersonalMoney = Convert.ToDouble(TextMoney.Text);
                    user.FirstName = TextName.Text;
                    user.LastName = TextLName.Text;
 
                    if (CheckContribution.IsChecked == true)
                    {
                        user.Contribution = true;
                        if (OnCapitalization.IsChecked == true)
                        {
                            user.Capitalization = true;
                        }
                        user.DepositMoney = Convert.ToDouble(TextContribution.Text);
                    }

                    DialogResult = true;
                }
                catch (FormatException)
                {
                    Error error = new Error();
                    error.ShowDialog();
                }
            }
        }

        private void CheckContribution_Click(object sender, RoutedEventArgs e)
        {
            if (CheckContribution.IsChecked == true)
            {
                OnCapitalization.IsEnabled = true;
                OffCapitalization.IsEnabled = true;
                OnCapitalization.IsChecked = true;
                TextContribution.IsEnabled = true;
            }

            else
            {
                OnCapitalization.IsEnabled = false;
                OffCapitalization.IsEnabled = false;
                OnCapitalization.IsChecked = false;
                OffCapitalization.IsChecked = false;
                TextContribution.IsEnabled = false;
            }
        }
    }
}
