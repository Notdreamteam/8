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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp12.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для Task10Page.xaml
    /// </summary>
    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }

        private void BtnAns_Click(object sender, RoutedEventArgs e)
        {
            TbA.Text = string.Empty;

            double number_topic; 
            string number_option;

            number_option = Convert.ToString(Tbv.Text);
            number_topic = Convert.ToDouble(Tbt.Text);

            Task10[] machine_numbers =
            {
                new Task10(1, "Новогодние"),
                new Task10(2, "С днем рождения"),
                new Task10(3, "С днем защитника отечества")
            };

            foreach(var machine_number in machine_numbers)
            {
                if (machine_number.Machine(number_topic, number_option))
                {
                    TbA.Text = machine_number.Print(number_topic, number_option);
                }
            }
        }

        private void BtnNextTask_Click(object sender, RoutedEventArgs e)
        {
            MyNavigation.MyConnect.Navigate(new Task11Page());
        }
    }
}
