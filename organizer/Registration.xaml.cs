using Azure;
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
using System.Windows.Shapes;

namespace organizer
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
            mainframe.Navigate(new RegPage());
            LogReg.MainFrame = mainframe;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            LogReg.MainFrame.Navigate(new LogPage());
            logmenu.Background = Brushes.White;
            regmenu.Background = Brushes.LightGray;
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            LogReg.MainFrame.Navigate(new RegPage());
            regmenu.Background = Brushes.White;
            logmenu.Background = Brushes.LightGray;
        }

    }
}
