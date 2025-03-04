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
    /// Логика взаимодействия для Task7Page.xaml
    /// </summary>
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;

            Task7[] coordinates =
            {
                new Task7(2, 2, -4, 0),
                new Task7(8, 9, 12, 1),
                new Task7(-3.5, 0.9, 2, 3)
            };
            int i = 1;

            foreach(var coord in coordinates)
            {
                if (coord.Distance()) TbA.Text += $"Точка А({coord.X1}, {coord.Y1}) наименее удалена\n";
                else TbA.Text += $"Точка B({coord.X2}, {coord.Y2}) наименее удалена\n";
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task8Page());
        }
    }
}
