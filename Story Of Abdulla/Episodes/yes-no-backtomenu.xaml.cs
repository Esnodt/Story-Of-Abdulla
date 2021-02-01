using Story_Of_Abdulla.MainMenu;
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

namespace Story_Of_Abdulla.Episodes
{
    /// <summary>
    /// Логика взаимодействия для yes_no_backtomenu.xaml
    /// </summary>
    public partial class yes_no_backtomenu : Page
    {
        public yes_no_backtomenu()
        {
            InitializeComponent();
        }

        private void ButtonBackToMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuMain());
        }

        private void ButtonBackToEpisode_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
