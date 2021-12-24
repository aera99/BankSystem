using BankSystem.ViewModel;
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
        public User SelectedSender { get; set; }
        public User SelectedRecipient { get; set; }
        public ObservableCollection<User> AllUsers { get; set; }
        public string Sum { get; set; }

        public MoneyTransfer(ObservableCollection<User> allUsers)
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;
            AllUsers = allUsers;
        }

        #region команды
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
                            if (SelectedSender.PersonalMoney - Convert.ToDouble(Sum) >= 0)
                            {
                                SelectedSender.PersonalMoney -= Convert.ToDouble(Sum);
                                SelectedRecipient.PersonalMoney += Convert.ToDouble(Sum);
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
        #endregion
    }
}
