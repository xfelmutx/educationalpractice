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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            loginInCB.ItemsSource = MainWindow.db.Gender.ToList();
            loginInCB.DisplayMemberPath = "Name";
        }

        private void registrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (textLogin.Text =="" || textPassword.Text== "")
            {
                MessageBox.Show("Где заполненные поля? Заполни", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                var selectedGender = loginInCB.SelectedItem as Gender;  
                Client client = new Client();
                client.LastName = textLastName.Text;
                client.FirstName = textFirstName.Text;
                client.Patronymic = textPatronymic.Text;
                client.Phone = textPhone.Text;
                client.Email = textEmail.Text;
                client.GenderCode = selectedGender.Code;
                MainWindow.db.Client.Add(client);
                User user = new User();
                user.Login = textLogin.Text;
                user.Password = textPassword.Text;
                user.RoleId = 2;
                user.ClientId = client.ID;
                MainWindow.db.User.Add(user);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Вы успешно зарегестрировались!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                this.NavigationService.GoBack();
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            textPassword.Text = "";
            textLogin.Text = "";
            this.NavigationService.Navigate(new AvtorizationPage());
        }
    }
}
