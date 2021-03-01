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
    public partial class AddClientPage : Page
    {
        public Client clientnull;
        public AddClientPage(Client client)
        {
            InitializeComponent();
            comboGender.ItemsSource = MainWindow.db.Gender.ToList();
            comboGender.DisplayMemberPath = "Name";
            if (client!=null)
            {
                this.addButton.Content = "Изменить";
                clientnull = MainWindow.db.Client.Attach(client);
                DataContext = this.clientnull;
                textFirstName.Text = clientnull.FirstName;
                textLastName.Text = clientnull.LastName;
                textPatronymic.Text = clientnull.Patronymic;
                textPhone.Text = clientnull.Phone;
                textEmail.Text = clientnull.Email;
                comboGender.SelectedItem = clientnull.GenderCode;
            }
            else
            {
                this.addButton.Content = "Добавить";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (textEmail.Text==""|| textFirstName.Text==""||textLastName.Text==""||textPatronymic.Text==""||textPhone.Text=="")
            {
                MessageBox.Show("Заполните поля!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (clientnull != null)
                {
                    clientnull.FirstName = textFirstName.Text;
                    clientnull.LastName = textLastName.Text;
                    clientnull.Patronymic = textPatronymic.Text;
                    clientnull.Phone = textPhone.Text;
                    clientnull.Email = textEmail.Text;
                    clientnull.Gender = comboGender.SelectedItem as Gender;
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Изменено!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (clientnull == null)
                {
                    clientnull = new Client();
                    clientnull.FirstName = textFirstName.Text;
                    clientnull.LastName = textLastName.Text;
                    clientnull.Patronymic = textPatronymic.Text;
                    clientnull.Phone = textPhone.Text;
                    clientnull.Email = textEmail.Text;
                    clientnull.Gender = comboGender.SelectedItem as Gender;
                    MainWindow.db.Client.Add(clientnull);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Добавлено!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            textFirstName.Text = "";
            textLastName.Text = "";
            textPatronymic.Text = "";
            textPhone.Text = "";
            textEmail.Text = "";
            this.NavigationService.Navigate(new ClientPage());
        }
    }
}
