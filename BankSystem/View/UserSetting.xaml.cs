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

namespace BankSystem.View
{
    /// <summary>
    /// Логика взаимодействия для UserSetting.xaml
    /// </summary>
    public partial class UserSetting : Window , INotifyPropertyChanged
    {
        public User User { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string PersonalMoney { get; set; }
        public string DepositMoney { get; set; }

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
        public UserSetting(User user)
        {
            InitializeComponent();
            this.Focus();
            this.DataContext = this;
            User = user;

            FirstName = user.FirstName;
            LastName = user.LastName;
            Age = Convert.ToString(user.Age);
            PersonalMoney = Convert.ToString(user.PersonalMoney);
            DepositMoney = Convert.ToString(user.DepositMoney);
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
                            if (CheckNull() || User == null)
                            {
                                User = new User(FirstName, LastName, Convert.ToInt32(Age), Convert.ToDouble(PersonalMoney), Convert.ToDouble(DepositMoney), Contribution, Capitalization);
                            }
                            else if (CheckNull() || User != null)
                            {
                                User.FirstName = FirstName;
                                User.LastName = LastName;
                                User.Age = Convert.ToInt32(Age);
                                User.PersonalMoney = Convert.ToDouble(PersonalMoney);
                                User.DepositMoney = Convert.ToDouble(DepositMoney);
                                User.Contribution = Contribution;
                                User.Capitalization = Capitalization;
                            }
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
        #endregion

        private bool CheckNull()
        {
            if (FirstName != null || LastName != null || Age != null || PersonalMoney != null)
            {
                return true;
            }
            else return false;
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
