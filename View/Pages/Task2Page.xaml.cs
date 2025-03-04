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
    /// Логика взаимодействия для Task2Page.xaml
    /// </summary>
    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            Task2[] numbers =
            {
                new Task2(3, 3.5, -2.1),
                new Task2(2.1, -6.55, 0.1),
                new Task2(-9, -3.7, 0.1)
            };
            int i = 1;
            foreach (var number in numbers)
            {
                TbA.Text += $"{i}) {number.MidValue()}\n";
                ++i;
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task3Page());
        }
    }
}
