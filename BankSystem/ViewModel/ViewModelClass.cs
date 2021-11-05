using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.View;
using LibraryModelBank;

namespace BankSystem.ViewModel
{
    public class ViewModelClass : VMBase
    {
        private Department[] departments;
        public Department[] Departments
        {
            get { return departments; } 
            set
            {
                departments = value;
                OnPropertyChanged("Departments");
            }
        }

        private ObservableCollection<User> selectedDepUsers;
        public ObservableCollection<User> SelectedDepUsers
        {
            get { return selectedDepUsers; }
            set
            {
                selectedDepUsers = value;
                OnPropertyChanged("SelectedDepUsers");
            }
        }

        private User selectedUser;
        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        private Department selectedDepartment;
        public Department SelectedDepartment
        {
            get { return selectedDepartment; }
            set
            {
                selectedDepartment = value;
                OnPropertyChanged("SelectedDepartment");
            }
        }

        public ViewModelClass()
        {
            Departments = new Department[]
            {
            new Defolt(),
            new Juridical(),
            new VIP()
            };

            SelectedDepartment = Departments[0];
            SelectedDepUsers = Departments[0].Users;
        }

        #region Команды
        // подумать над сокрощением свапов
        private RelayCommand radioSwapDefolt;
        public RelayCommand RadioSwapDefolt
        {
            get
            {
                return radioSwapDefolt ??
                    (radioSwapDefolt = new RelayCommand(obj =>
                    {
                        SelectedDepartment = Departments[0];
                        SelectedDepUsers = SelectedDepartment.Users;
                    }));
            }
        }

        private RelayCommand radioSwapJuridical;
        public RelayCommand RadioSwapDefoltJuridical
        {
            get
            {
                return radioSwapJuridical ??
                    (radioSwapJuridical = new RelayCommand(obj =>
                    {
                        SelectedDepartment = Departments[1];
                        SelectedDepUsers = SelectedDepartment.Users;
                    }));
            }
        }

        private RelayCommand radioSwapVIP;
        public RelayCommand RadioSwapVIP
        {
            get
            {
                return radioSwapVIP ??
                    (radioSwapVIP = new RelayCommand(obj =>
                    {
                        SelectedDepartment = Departments[2];
                        SelectedDepUsers = SelectedDepartment.Users;
                    }));
            }
        }

        private RelayCommand testAddUser;
        public RelayCommand TestAddUser
        {
            get
            {
                return testAddUser ??
                    (testAddUser = new RelayCommand(obj =>
                    {
                        for (int i = 0; i < Departments.Length; i++)
                        {
                            if (SelectedDepartment == Departments[i])
                            {
                                Departments[i].RandomFilling();
                            }
                        }
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
                        for (int i = 0; i < Departments.Length; i++)
                        {
                            Departments[i].Time.AddMonths(1);
                        }
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
                            for (int i = 0; i < Departments.Length; i++)
                            {
                                if (SelectedDepartment == Departments[i])
                                {
                                    Departments[i].Users.Remove(SelectedUser);
                                }
                            }
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
                            
                            for (int i = 0; i < Departments.Length; i++)
                            {
                                if (SelectedDepartment == Departments[i])
                                {
                                    Departments[i].Users.Add(userSetting.user);
                                }
                            }
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
                                for (int i = 0; i < Departments.Length; i++)
                                {
                                    if (SelectedDepartment == Departments[i])
                                    {
                                        for (int j = 0; j < Departments[i].Users.Count; j++)
                                        {
                                            if (SelectedUser == Departments[i].Users[j])
                                            {
                                                Departments[i].Users[j] = userSetting.user;
                                            }

                                        }
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
                        MoneyTransfer mt = new MoneyTransfer(Departments);
                        if (mt.ShowDialog() == true)
                        {
                            for (int i = 0; i < Departments.Length; i++)
                            {
                                for (int j = 0; j < Departments[i].Users.Count; j++)
                                {
                                    if (Departments[i].Users[j].ID == mt.SelectedSender.ID)
                                    {
                                        Departments[i].Users[j] = mt.SelectedSender;
                                    }
                                    if (Departments[i].Users[j].ID == mt.SelectedRecipient.ID)
                                    {
                                        Departments[i].Users[j] = mt.SelectedRecipient;
                                    }
                                }
                            }
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
                            LoanSetting loanSetting = new LoanSetting(SelectedUser, SelectedDepartment.PercentageOfLoan);
                            if (loanSetting.ShowDialog() == true)
                            {
                                for (int i = 0; i < Departments.Length; i++)
                                {
                                    if (SelectedDepartment == Departments[i])
                                    {
                                        for (int j = 0; j < Departments[i].Users.Count; j++)
                                        {
                                            if (SelectedUser == Departments[i].Users[j])
                                            {
                                                Departments[i].Users[j] = loanSetting.CreditUser;
                                            }
                                        }
                                    }
                                }
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
                                for (int i = 0; i < Departments.Length; i++)
                                {
                                    if (SelectedDepartment == Departments[i])
                                    {
                                        for (int j = 0; j < Departments[i].Users.Count; j++)
                                        {
                                            if (SelectedUser == Departments[i].Users[j])
                                            {
                                                Departments[i].Users[j].Loan = loanRepayment.UserChange.Loan;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }));
            }
        }
        #endregion
    }
}
