using LibraryModelBank;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для MoneyTransfer.xaml
    /// </summary>
    public partial class MoneyTransfer : Window
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public User SelectedSender { get; set; }
        public User SelectedRecipient { get; set; }
        public string Sum { get; set; }

        public MoneyTransfer(Department[] departments)
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;

            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Users.Count; j++)
                {
                    Users.Add(departments[i].Users[j]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((SelectedSender.PersonalMoney - Convert.ToDouble(Sum)) >= 0)
                {
                    SelectedSender.PersonalMoney -= Convert.ToDouble(Sum);
                    SelectedRecipient.PersonalMoney += Convert.ToDouble(Sum);
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
        }
    }
}
