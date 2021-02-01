using Story_Of_Abdulla.Episodes;
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
    /// Логика взаимодействия для History_Info.xaml
    /// </summary>
    public partial class History_Info : Page
    {
        public History_Info()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Episode1());
        }
    }
}
