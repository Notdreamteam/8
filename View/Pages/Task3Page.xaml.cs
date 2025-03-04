using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;
            double r = Convert.ToDouble(Tbr.Text);

            Task3[] dots =
            {
                new Task3(2, 1.5),
                new Task3(-0.5, 2.3),
                new Task3(1.5, -0.8)
            };
            int i = 1;

            foreach (var dot in dots)
            {
                if (dot.Belongs(r)) TbA.Text += $"{i}) Точка А({dot.X}, {dot.Y}) лежит в окружности\n";
                else TbA.Text += $"{i}) Точка А({dot.X}, {dot.Y}) не лежит в окружности\n";
                ++i;
            }

            Tbr.Text = string.Empty;
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task4Page());
        }
    }
}
