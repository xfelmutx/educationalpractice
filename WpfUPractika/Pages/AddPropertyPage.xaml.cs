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
    /// Логика взаимодействия для AddPropertyPage.xaml
    /// </summary>
    public partial class AddPropertyPage : Page
    {
        public Property propertynull;
        public AddPropertyPage(Property property)
        {
            InitializeComponent();
            comboTypeId.ItemsSource = MainWindow.db.TypeProperty.ToList();
            comboAddressId.ItemsSource = MainWindow.db.Address.ToList();
            comboAddressId.DisplayMemberPath = "ID";
            comboTypeId.DisplayMemberPath = "Name";
           
            if (property!=null)
            {
                this.addButton.Content = "Изменить";
                this.propertynull =MainWindow.db.Property.Attach(property);
                DataContext = propertynull;
                comboTypeId.SelectedItem = propertynull.TypeProperty;
                textFloor.Text = propertynull.Floor.ToString();
                textRoom.Text = propertynull.Room.ToString();
                comboAddressId.SelectedItem = propertynull.Address;
                textArea.Text = propertynull.Area.ToString();
            }
            else
            {
                this.addButton.Content = "Добавить";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (textArea.Text == "" || textFloor.Text == "" || textRoom.Text=="")
            {
                MessageBox.Show("Заполните поля!","Ошибка!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                if (propertynull != null)
                {
                    propertynull.Area = Convert.ToInt32(textArea.Text);
                    propertynull.Floor = Convert.ToInt32(textFloor.Text);
                    propertynull.Room = Convert.ToInt32(textRoom.Text);
                    propertynull.TypeProperty = comboTypeId.SelectedItem as TypeProperty;
                    propertynull.Address = comboAddressId.SelectedItem as Address;
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Изменено!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                if (propertynull == null)
                {
                    propertynull = new Property();
                    propertynull.Area = Convert.ToInt32(textArea.Text);
                    propertynull.Floor = Convert.ToInt32(textFloor.Text);
                    propertynull.Room = Convert.ToInt32(textRoom.Text);
                    propertynull.TypeProperty = comboTypeId.SelectedItem as TypeProperty;
                    propertynull.Address = comboAddressId.SelectedItem as Address;
                    MainWindow.db.Property.Add(propertynull);
                    MainWindow.db.SaveChanges();
                    MessageBox.Show("Добавлено!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new PropertyPage());
        }
    }
}
