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
    /// Логика взаимодействия для AddNeedPage.xaml
    /// </summary>
    public partial class AddNeedPage : Page
    {
        Need neednull;
        public AddNeedPage(Need need)
        {
            InitializeComponent();
            comboAddress.ItemsSource = MainWindow.db.Address.ToList();
            comboClient.ItemsSource = MainWindow.db.Client.ToList();
            comboRealtor.ItemsSource = MainWindow.db.Realtor.ToList();
            comboProperty.ItemsSource = MainWindow.db.TypeProperty.ToList();
            comboAddress.DisplayMemberPath = "City.Name";
            comboClient.DisplayMemberPath = "FirstName";
            comboRealtor.DisplayMemberPath = "FirstName";
            comboProperty.DisplayMemberPath = "Name";
            if (need!=null)
            {
                addButton.Content = "Изменить";
                this.neednull = MainWindow.db.Need.Attach(need);
                DataContext = neednull;
                comboAddress.SelectedItem = this.neednull.Address;
                comboClient.SelectedItem = this.neednull.Client;
                comboProperty.SelectedItem = this.neednull.TypeProperty;
                comboRealtor.SelectedItem = this.neednull.Realtor;
                textMaxPrice.Text = this.neednull.MaxPrice.ToString();
                textMinPrice.Text = this.neednull.MinPrice.ToString();
                DataContext = this.neednull;
            }
            else
            {
                //this.neednull = need;
                addButton.Content = "Добавить";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (neednull !=null)
            {
                neednull.ClientId = Convert.ToInt32((comboClient.SelectedItem as Client).ID);
                neednull.RealtorId = Convert.ToInt32((comboRealtor.SelectedItem as Realtor).ID);
                neednull.TypePropertyId = Convert.ToInt32((comboProperty.SelectedItem as TypeProperty).ID);
                neednull.AddressId = Convert.ToInt32((comboAddress.SelectedItem as Address).ID);
                neednull.MinPrice = Convert.ToDecimal(textMinPrice.Text);
                neednull.MaxPrice = Convert.ToDecimal(textMaxPrice.Text);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Изменено", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (neednull==null)
            {
                neednull = new Need();
                neednull.Client = comboClient.SelectedItem as Client;
                neednull.Realtor = comboRealtor.SelectedItem as Realtor;
                neednull.TypeProperty = comboProperty.SelectedItem as TypeProperty;
                neednull.Address = comboAddress.SelectedItem as Address;
                neednull.MinPrice = Convert.ToDecimal(textMinPrice.Text);
                neednull.MaxPrice = Convert.ToDecimal(textMaxPrice.Text);
                MainWindow.db.Need.Add(neednull);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Добавлено!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NeedPage());
        }
    }
}
