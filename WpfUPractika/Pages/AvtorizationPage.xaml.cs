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
    public class UserRole
    {
        public static int Info
        {
            get;
            set;
        }
    }
    /// <summary>
    /// Логика взаимодействия для AvtorizationPage.xaml
    /// </summary>
    public partial class AvtorizationPage : Page
    {
        public AvtorizationPage()
        {
            InitializeComponent();
            if (Properties.Settings.Default.Properties!= null)
            {
                textLogin.Text = Properties.Settings.Default.Login;
                textPassword.Password = Properties.Settings.Default.Password;
            }

            //testCB.ItemsSource = MainWindow.db.Gender.ToList();
            //testCB.DisplayMemberPath = "Name";


        }

        private void avtorizationButton_Click(object sender, RoutedEventArgs e)
        {
            if (saveCheck.IsChecked.GetValueOrDefault())
            {
                Properties.Settings.Default.Login = textLogin.Text;
                Properties.Settings.Default.Password = textPassword.Password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Login = null;
                Properties.Settings.Default.Password = null;
                Properties.Settings.Default.Save();
            }
            foreach (var user in MainWindow.db.User)
            {
                if (user.Login==textLogin.Text.Trim())
                {
                    if (user.Password == textPassword.Password.Trim() && user.RoleId == 1)
                    {
                        UserRole.Info = 1;
                        MessageBox.Show("Батя в здании (админ)!","Информация!",MessageBoxButton.OK,MessageBoxImage.Information);
                        this.NavigationService.Navigate(new MenuPage());
                    }
                    if (user.Password == textPassword.Password.Trim() && user.RoleId == 2)
                    {
                        UserRole.Info = 2;
                        MessageBox.Show("Приветствуем пользователь!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.NavigationService.Navigate(new MenuPage());
                    }
                }
            }
            
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new RegistrationPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (Properties.Settings.Default.Properties != null)
            {
                textLogin.Text = Properties.Settings.Default.Login;
                textPassword.Password = Properties.Settings.Default.Password;
            }
        }

        //private void testBTN_Click(object sender, RoutedEventArgs e)
        //{
        //    var selGender = testCB.SelectedItem as Gender;
        //    Console.WriteLine($"{selGender}");
        //}
    }
}
