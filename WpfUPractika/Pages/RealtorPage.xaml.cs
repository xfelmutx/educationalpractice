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
    /// Логика взаимодействия для RealtorPage.xaml
    /// </summary>
    public partial class RealtorPage : Page
    {
        public RealtorPage()
        {
            InitializeComponent();
            comboGender.ItemsSource = MainWindow.db.Gender.ToList();
            comboGender.DisplayMemberPath = "Name";
        }

        private void listRealtor_Loaded(object sender, RoutedEventArgs e)
        {
            listRealtor.ItemsSource = MainWindow.db.Realtor.ToList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new AddRealtorPage(null));
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            if (listRealtor.SelectedItem !=null)
            {
                var select = listRealtor.SelectedItem as Realtor;
                this.NavigationService.Navigate(new AddRealtorPage(select));
            }
            else
            {
                MessageBox.Show("Выберите риэлтора!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listRealtor.SelectedItem !=null)
            {
                var select = listRealtor.SelectedItem as Realtor;
                MainWindow.db.Realtor.Remove(select);
                MainWindow.db.SaveChanges();
                listRealtor.ItemsSource = MainWindow.db.Realtor.ToList();
            }
            else
            {
                MessageBox.Show("Выберите риэлтора!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void textFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            listRealtor.ItemsSource = MainWindow.db.Realtor.Where(x => x.FirstName == textFirstName.Text).ToList();
        }

        private void comboGender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboGender.SelectedIndex==0)
            {
                listRealtor.ItemsSource = MainWindow.db.Realtor.ToList();
            }
            if (comboGender.SelectedIndex==1)
            {
                listRealtor.ItemsSource = MainWindow.db.Realtor.Where(x => x.GenderCode == "ж").ToList();
            }
            if (comboGender.SelectedIndex==2)
            {
                listRealtor.ItemsSource = MainWindow.db.Realtor.Where(x => x.GenderCode == "м").ToList();
            }
        }

        private void radioA_Checked(object sender, RoutedEventArgs e)
        {
            if (radioA.IsChecked==true)
            {
                listRealtor.ItemsSource = MainWindow.db.Realtor.OrderBy(x => x.FirstName).ToList();
            }
            if (radioYA.IsChecked==true)
            {
                listRealtor.ItemsSource = MainWindow.db.Realtor.OrderByDescending(x => x.FirstName).ToList();
            }
        }
    }
}
