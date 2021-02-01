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

namespace Story_Of_Abdulla.MainMenu
{
    /// <summary>
    /// Логика взаимодействия для MenuMain.xaml
    /// </summary>
    public partial class MenuMain : Page
    {
        public MenuMain()
        {
            InitializeComponent();
        }

        private void ButtonStartGame_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new History_Info());
        }

        private void ButtonSetter_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Setter());
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
