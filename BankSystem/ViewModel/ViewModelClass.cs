using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Model;
using BankSystem.View;


namespace BankSystem.ViewModel
{
    public class ViewModelClass : Bindable
    {
        public DepartmentINPC BankDepartment { get; set; }

        private UserINPC selectedUser;
        public UserINPC SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }
        public ObservableCollection<UserINPC> AllUsers
        {
            get { return BankDepartment.Users; }
            set
            {
                BankDepartment.Users = value;
                OnPropertyChanged("AllUsers");
            }
        }

        public ViewModelClass()
        {
            BankDepartment = new DepartmentINPC();
        }

        #region Команды
        private RelayCommand _testAddUser;
        public RelayCommand TestAddUser
        {
            get
            {
                return _testAddUser ??
                    (_testAddUser = new RelayCommand(obj =>
                    {
                        AllUsers.Add(new UserINPC());
                    }));
            }
        }

        private RelayCommand testAddMonth;
        public RelayCommand TestAddMonth
        {
            get
            {
                return testAddMonth ??
                    (testAddMonth = new RelayCommand(obj =>
                    {
                        BankDepartment.Time.AddMonths(1);
                    }));
            }
        }

        private RelayCommand deleteUser;
        public RelayCommand DeleteUser
        {
            get
            {
                return deleteUser ??
                    (deleteUser = new RelayCommand(obj =>
                    {
                        if (SelectedUser != null)
                        {
                            AllUsers.Remove(SelectedUser);
                        }
                    }));
            }
        }

        private RelayCommand addUser;
        public RelayCommand AddUser
        {
            get
            {
                return addUser ??
                    (addUser = new RelayCommand(obj =>
                    {
                        UserSetting userSetting = new UserSetting();
                        if (userSetting.ShowDialog() == true)
                        {
                            AllUsers.Add(userSetting.User);
                        }
                    }));
            }
        }

        private RelayCommand editUser;
        public RelayCommand EditUser
        {
            get
            {
                return editUser ??
                    (editUser = new RelayCommand(obj =>
                    {
                        if (SelectedUser != null)
                        {
                            UserSetting userSetting = new UserSetting(SelectedUser);
                            if (userSetting.ShowDialog() == true)
                            {
                                foreach (var user in AllUsers)
                                {
                                    if (user == SelectedUser)
                                    {
                                        user.ChangeAllInfo(userSetting.User);
                                    }
                                }
                            }
                        }
                    }));
            }
        }

        private RelayCommand trasfer;
        public RelayCommand Trasfer
        {
            get
            {
                return trasfer ??
                    (trasfer = new RelayCommand(obj =>
                    {
                        MoneyTransfer mt = new MoneyTransfer(AllUsers);
                        if (mt.ShowDialog() == true)
                        {

                        }
                    }));
            }
        }

        private RelayCommand editLoan;
        public RelayCommand EditLoan
        {
            get
            {
                return editLoan ??
                    (editLoan = new RelayCommand(obj =>
                    {
                        if (SelectedUser != null)
                        {
                            LoanSetting loanSetting = new LoanSetting(SelectedUser);
                            if (loanSetting.ShowDialog() == true)
                            {
                            }
                        }
                    }));
            }
        }

        private RelayCommand editLoanRepayment;
        public RelayCommand EditLoanRepayment
        {
            get
            {
                return editLoanRepayment ??
                    (editLoanRepayment = new RelayCommand(obj =>
                    {
                        if (SelectedUser != null && SelectedUser.Loan > 0)
                        {
                            LoanRepayment loanRepayment = new LoanRepayment(SelectedUser);
                            if (loanRepayment.ShowDialog() == true)
                            {
                            }
                        }
                    }));
            }
        }
        #endregion
    }
}
