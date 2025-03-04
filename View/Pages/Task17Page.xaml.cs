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
    /// Логика взаимодействия для Task17Page.xaml
    /// </summary>
    public partial class Task17Page : Page
    {
        public Task17Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;

            Task17[] coords =
            {
                new Task17(9, 2),
                new Task17(7, -3),
                new Task17(0.1, 4)
            };

            int i = 1;
            foreach (var coord in coords)
            {
                TbA.Text += $"{i}) {coord.Quarter()}\n";
                ++i;
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task18Page());
        }
    }
}
