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
    /// Логика взаимодействия для ClientPage.xaml
    /// </summary>
    public partial class ClientPage : Page
    {
        public ClientPage()
        {
            InitializeComponent();
            if (UserRole.Info==2)
            {
                addButton.Visibility = Visibility.Hidden;
                editButton.Visibility = Visibility.Hidden;
                deleteButton.Visibility = Visibility.Hidden;
            }
            else
            {
                addButton.Visibility = Visibility.Visible;
                editButton.Visibility = Visibility.Visible;
                deleteButton.Visibility = Visibility.Visible;
            }
            comboGender.ItemsSource = MainWindow.db.Gender.ToList();
            comboGender.DisplayMemberPath = "Name";
        }

        private void listClient_Loaded(object sender, RoutedEventArgs e)
        {
            listClient.ItemsSource = MainWindow.db.Client.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddClientPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (listClient.SelectedItem!=null)
            {
                var select = listClient.SelectedItem as Client;
                this.NavigationService.Navigate(new AddClientPage(select));
            }
            else
            {
                MessageBox.Show("Выберите клиента!","Ошибка!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listClient.SelectedItem!=null)
            {
                var select = listClient.SelectedItem as Client;
                MainWindow.db.Client.Remove(select);
                MainWindow.db.SaveChanges();
                listClient.ItemsSource = MainWindow.db.Client.ToList();
            }
            else
            {
                MessageBox.Show("Выберите клиента!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void textFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textFirstName.Text !="")
            {
                listClient.ItemsSource = MainWindow.db.Client.Where(x => x.FirstName == textFirstName.Text).ToList();
            }
            else
            {
                listClient.ItemsSource = MainWindow.db.Client.ToList();
            }
        }

        private void comboGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int selectedGender = comboGender.SelectedIndex;
            switch (selectedGender)
            {
                case 1:
                listClient.ItemsSource = MainWindow.db.Client.Where(x => x.GenderCode == "ж").ToList();
                break;

                case 2:
                listClient.ItemsSource = MainWindow.db.Client.Where(x => x.GenderCode == "м").ToList();
                break;
            }

        }

        private void radioA_Checked(object sender, RoutedEventArgs e)
        {
            if (radioA.IsChecked==true)
            {
                listClient.ItemsSource = MainWindow.db.Client.OrderBy(x => x.FirstName).ToList();
            }
            if (radioYA.IsChecked==true)
            {
                listClient.ItemsSource = MainWindow.db.Client.OrderByDescending(x => x.FirstName).ToList();
            }
        }
    }
}
