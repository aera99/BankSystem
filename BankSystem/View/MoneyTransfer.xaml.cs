using BankSystem.Model;
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
        public UserINPC SelectedSender { get; set; }
        public UserINPC SelectedRecipient { get; set; }
        public ObservableCollection<UserINPC> AllUsers { get; set; }
        public double Sum { get; set; }

        public MoneyTransfer(ObservableCollection<UserINPC> allUsers)
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
                            if (SelectedSender.PersonalMoney - Sum >= 0)
                            {
                                SelectedSender.PersonalMoney -= Sum;
                                SelectedRecipient.PersonalMoney += Sum;
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
