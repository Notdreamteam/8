using System.Windows;
using WpfApp12.Servers;
using WpfApp12.View.Pages;

namespace WpfApp12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyNavigation.MyConnect = MyFrame;

            MyFrame.Navigate(new MainPage());
        }
    }
}
