﻿using BankSystem.ViewModel;
using LibraryModelBank;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Model
{
    public class DepartmentINPC : Department , INotifyPropertyChanged
    {
        private ObservableCollection<UserINPC> _users;
        public new ObservableCollection<UserINPC> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged("Users");
            }
        }

        public DepartmentINPC()
        {
            Users = new ObservableCollection<UserINPC>();
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
