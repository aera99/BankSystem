using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModelBank
{
    public class Department
    {
        public List<User> Users { get; set; }
        public DateTime Time { get; set; }

        public Department()
        {
            Users = new List<User>();
            Time = DateTime.Now;
        }

        #region Методы
        public void RandomFilling()
        {
            Users.Add(new User());
        }
        public void DeleteUser()
        {
            //todo
        }
        #endregion
    }
}
