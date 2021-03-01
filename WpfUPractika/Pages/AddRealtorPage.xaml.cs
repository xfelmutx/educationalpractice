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
    /// Логика взаимодействия для AddRealtorPage.xaml
    /// </summary>
    public partial class AddRealtorPage : Page
    {
        Realtor realtornull;
        public AddRealtorPage(Realtor realtor)
        {
            InitializeComponent();
            if (realtor != null)
            {
                this.addButton.Content = "Изменить";
                realtornull = MainWindow.db.Realtor.Attach( realtor);
                DataContext = realtornull;
                textFirstName.Text = realtornull.FirstName;
                textLastName.Text = realtornull.LastName;
                textPatronymic.Text = realtornull.Patronymic;
                textComisia.Text = realtornull.ShareOfComisia.ToString();
            }
            else
            {
                this.addButton.Content = "Добавить";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (textPatronymic.Text==""|| textLastName.Text==""||textFirstName.Text==""||textComisia.Text=="")
            {
                MessageBox.Show("Заполните поля!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (realtornull != null)
                {
                    realtornull.FirstName = textFirstName.Text;
                    realtornull.LastName = textLastName.Text;
                    realtornull.Patronymic = textPatronymic.Text;
                    realtornull.ShareOfComisia = Convert.ToDecimal(textComisia.Text);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Изменено!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (realtornull == null)
                {
                    realtornull = new Realtor();
                    realtornull.FirstName = textFirstName.Text;
                    realtornull.LastName = textLastName.Text;
                    realtornull.Patronymic = textPatronymic.Text;
                    realtornull.ShareOfComisia = Convert.ToDecimal(textComisia.Text);
                    MainWindow.db.Realtor.Add(realtornull);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Добавлено!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            textComisia.Text = "";
            textFirstName.Text = "";
            textLastName.Text = "";
            textPatronymic.Text = "";
            this.NavigationService.Navigate(new RealtorPage());
        }
    }
}
