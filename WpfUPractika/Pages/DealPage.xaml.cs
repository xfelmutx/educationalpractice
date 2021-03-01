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
    /// Логика взаимодействия для DealPage.xaml
    /// </summary>
    public partial class DealPage : Page
    {
        public DealPage()
        {
            InitializeComponent();
        }

        private void dealClient_Loaded(object sender, RoutedEventArgs e)
        {
            dealClient.ItemsSource = MainWindow.db.Deal.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddDealPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (dealClient.SelectedItem != null)
            {
                var select = dealClient.SelectedItem as Deal;
                this.NavigationService.Navigate(new AddDealPage(select));
            }
            else
            {
                MessageBox.Show("Выберите сделку","Ошибка!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (dealClient.SelectedItem!=null)
            {
                var select = dealClient.SelectedItem as Deal;
                MainWindow.db.Deal.Remove(select);
                MainWindow.db.SaveChanges();
                dealClient.ItemsSource = MainWindow.db.Deal.ToList();
                MessageBox.Show("Успешно удалено!","Информация!",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите сделку", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
