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
    /// Логика взаимодействия для Task22Page.xaml
    /// </summary>
    public partial class Task22Page : Page
    {
        public Task22Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;

            Task22[] least_numvers =
            {
                new Task22(15, 13, -33),
                new Task22(-38, 25, 12),
                new Task22(22, -1, -33)
            };
            int i = 1;

            foreach (var least_number in least_numvers)
            {
                TbA.Text += $"{i}) {least_number.Least()}\n";
                ++i;
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task23Page());
        }
    }
}
