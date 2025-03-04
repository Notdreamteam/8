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
    /// Логика взаимодействия для Task13Page.xaml
    /// </summary>
    public partial class Task13Page : Page
    {
        public Task13Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;
            Task13[] numbers =
            {
                new Task13(3.2, -7, 0.5),
                new Task13(2.3, 3, 2.5),
                new Task13(23, -34, 89.5)
            };
            int i = 1;

            foreach (var item in numbers)
            {
                if (Math.Abs(item.X) > item.Exp()) TbA.Text += $"{i}) {item.X}\n";
                if (Math.Abs(item.Y) > item.Exp()) TbA.Text += $"{i}) {item.Y}\n";
                if (Math.Abs(item.Z) > item.Exp()) TbA.Text += $"{i}) {item.Z}\n";
                ++i;
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task14Page());
        }
    }
}
