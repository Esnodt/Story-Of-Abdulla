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
    /// Логика взаимодействия для Episode1.xaml
    /// </summary>
    public partial class Episode1 : Page
    {
        public Episode1()
        {
            InitializeComponent();
        }

        private void ButtonBackMainMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new yes_no_backtomenu());
        }

        private void ButonStop_Click(object sender, RoutedEventArgs e)
        {
            TextStart.Text = TextIfStop.Text;
            ButonStop.Visibility = Visibility.Collapsed;
            ButtonGoNext.Visibility = Visibility.Visible;
        }

        private void ButtonGoNext_Click(object sender, RoutedEventArgs e)
        {
            TextStart.Text = TextIfGonext2.Text;
            ButonStop.Visibility = Visibility.Collapsed;
            ButtonGoNext.Visibility = Visibility.Collapsed;
            ButtomGoBonefire.Visibility = Visibility.Visible;

        }


        private void ButtonGoForest_Click(object sender, RoutedEventArgs e)
        {
            TextIfGonext2.Visibility = Visibility.Collapsed;
            ButtomGoBonefire.Visibility = Visibility.Collapsed;

        }

        private void ButtomGoBonefire_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Episode1_1());
        }
    }
}
