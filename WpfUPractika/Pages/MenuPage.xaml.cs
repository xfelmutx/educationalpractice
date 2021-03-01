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

namespace WpfUPractika.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void clientButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ClientPage());
        }

        private void realtorButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RealtorPage());
        }

        private void propertyButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PropertyPage());
        }

        private void needButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NeedPage());
        }

        private void offerButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new OfferPage());
        }

        private void dealButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DealPage());
        }
    }
}
