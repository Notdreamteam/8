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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp12.Servers;
using WpfApp12.Utility.Tasks;

namespace WpfApp12.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task9Page.xaml
    /// </summary>
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;

            double weekend, weekdays;

            weekend = Convert.ToDouble(Tbwd.Text);
            weekdays = Convert.ToDouble(Tbw.Text);

            Task9[] costs =
            {
                new Task9(50, 0.1),
                new Task9(45, 0.08),
                new Task9(55, .012)
            };

            int i = 1;

            foreach(var cost in costs)
            {
                TbA.Text += $"{i}) {cost.CostOfCall(weekend, weekdays)}";
                ++i;
            }

            Tbw.Text = string.Empty;
            Tbwd.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task10Page());
        }
    }
}
