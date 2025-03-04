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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;
            Task4[] angles =
            {
                new Task4(3, 3.5, -2.1),
                new Task4(21, -6.55, 0.1),
                new Task4(-9, -3.7, -0.1)
            };

            int i = 1;

            foreach(var angle in angles)
            {
                if (angle.Rectangular()) TbA.Text += "Треугольник abc является прямоугольным\n";
                else TbA.Text += "Треугольник не является прямоугольным\n";
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task5Page());
        }
    }
}
