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
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BankSystem.Model;

namespace BankSystem.View
{
    /// <summary>
    /// Логика взаимодействия для UserSetting.xaml
    /// </summary>
    public partial class UserSetting : Window , INotifyPropertyChanged
    {
        public UserINPC User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double PersonalMoney { get; set; }
        public double DepositMoney { get; set; }

        private bool contribution;
        public bool Contribution
        {
            get { return contribution; }
            set
            {
                contribution = value;
                OnPropertyChanged("Contribution");
            }
        }
        public bool Capitalization { get; set; }
        
        public UserSetting()
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;
        }
        public UserSetting(UserINPC user)
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;
            User = user;

            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = user.Age;
            PersonalMoney = user.PersonalMoney;
            DepositMoney = user.DepositMoney;
            Contribution = user.Contribution;
            Capitalization = user.Capitalization;
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
                            if (CheckNull() && User == null)
                            {
                                User = new UserINPC(FirstName, LastName, Age, PersonalMoney, DepositMoney, Contribution, Capitalization);
                                DialogResult = true;
                            }
                            else if (CheckNull() && User != null)
                            {
                                User.FirstName = FirstName;
                                User.LastName = LastName;
                                User.Age = Age;
                                User.PersonalMoney = PersonalMoney;
                                User.DepositMoney = DepositMoney;
                                User.Contribution = Contribution;
                                User.Capitalization = Capitalization;

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
        #endregion

        private bool CheckNull()
        {
            if (FirstName != null && FirstName != "" && LastName != null && LastName != "")
            {
                return true;
            }
            else return false;
        }

        private void ShowError()
        {
            Error error = new Error();
            error.ShowDialog();
        }

        #region INPC
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
