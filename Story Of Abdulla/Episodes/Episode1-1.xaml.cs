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
    /// Логика взаимодействия для Episode1_1.xaml
    /// </summary>
    public partial class Episode1_1 : Page
    {
        public Episode1_1()
        {
            InitializeComponent();
        }

        private void ButtonBackMainMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new yes_no_backtomenu());
            
        }

        private void ButtonStopAndDream_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GameOver());
        }

        private void ButtonGoToHuman_Click(object sender, RoutedEventArgs e)
        {
            TextBonfire.Visibility = Visibility.Collapsed;
            TextIfGonext3.Visibility = Visibility.Collapsed;
            ButtonStopAndDream.Visibility = Visibility.Collapsed;
            ButtonGoToHuman.Visibility = Visibility.Collapsed;
            TextForHuman.Visibility = Visibility.Visible;
            TextForHuman2.Visibility = Visibility.Visible;
            ImageBookV.Visibility = Visibility.Visible;
            ButtonGoDemon.Visibility = Visibility.Visible;


        }

        private void ButtonGoDemon_Click(object sender, RoutedEventArgs e)
        {
            TextForHuman.Visibility = Visibility.Collapsed;
            TextForHuman2.Visibility = Visibility.Collapsed;
            ImageBookV.Visibility = Visibility.Collapsed;
            ButtonGoDemon1.Visibility = Visibility.Visible;
            Textforguman3.Visibility = Visibility.Visible;
            

        }

        private void ButtonGoDemon1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Episode1_2Demon());
        }
    }
}
