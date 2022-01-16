using BankSystem.Model;
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
    /// Логика взаимодействия для ActivityLogView.xaml
    /// </summary>
    public partial class ActivityLogView : Window
    {
        public List<ActivityLog> ActivityLogs { get; set; }
        public ActivityLogView(List<ActivityLog> activityLogs)
        {
            InitializeComponent();
            ActivityLogs = activityLogs;
            this.DataContext = this;
            this.Focus();
        }
    }
}
