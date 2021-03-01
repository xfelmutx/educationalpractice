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
using WpfUPractika.DB;

namespace WpfUPractika.Pages
{
    /// <summary>
    /// Логика взаимодействия для OfferPage.xaml
    /// </summary>
    public partial class OfferPage : Page
    {
        public OfferPage()
        {
            InitializeComponent();
        }

        private void listOffer_Loaded(object sender, RoutedEventArgs e)
        {
            listOffer.ItemsSource = MainWindow.db.Offer.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddOfferPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (listOffer.SelectedItem !=null)
            {
                var select = listOffer.SelectedItem as Offer;
                this.NavigationService.Navigate(new AddOfferPage(select));
            }
            else
            {
                MessageBox.Show("Выберите предложение!","Ошибка!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listOffer.SelectedItem!=null)
            {
                var select = listOffer.SelectedItem as Offer;
                MainWindow.db.Offer.Remove(select);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Успешно удалено!","Информация!",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите предложение!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
