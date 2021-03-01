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
    /// Логика взаимодействия для NeedPage.xaml
    /// </summary>
    public partial class NeedPage : Page
    {
        public NeedPage()
        {
            InitializeComponent();
        }

        private void listNeed_Loaded(object sender, RoutedEventArgs e)
        {
            listNeed.ItemsSource = MainWindow.db.Need.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddNeedPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (listNeed.SelectedItem != null)
            {
                var select = listNeed.SelectedItem as Need;
                this.NavigationService.Navigate(new AddNeedPage(select));
            }
            else
            {
                MessageBox.Show("Выберите недвижимость!","Ошибка!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listNeed.SelectedItem != null)
            {
                var select = listNeed.SelectedItem as Need;
                MainWindow.db.Need.Remove(select);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Успешно удалено!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Выберите недвижимость!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void listNeed_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
