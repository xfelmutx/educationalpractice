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
    /// Логика взаимодействия для PropertyPage.xaml
    /// </summary>
    public partial class PropertyPage : Page
    {
        public PropertyPage()
        {
            InitializeComponent();
        }
        private void listProperty_Loaded_1(object sender, RoutedEventArgs e)
        {
            listProperty.ItemsSource = MainWindow.db.Property.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddPropertyPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (listProperty.SelectedItem !=null)
            {
                var select = listProperty.SelectedItem as Property;
                this.NavigationService.Navigate(new AddPropertyPage(select));
            }
            else
            {
                MessageBox.Show("Выберите недвижимость!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listProperty.SelectedItem !=null)
            {
                var select = listProperty.SelectedItem as Property;
                MainWindow.db.Property.Remove(select);
                MainWindow.db.SaveChanges();
                listProperty.ItemsSource = MainWindow.db.Property.ToList();
            }
            else
            {
                MessageBox.Show("Выберите недвижимость!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
