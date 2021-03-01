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
    /// Логика взаимодействия для AddOfferPage.xaml
    /// </summary>
    public partial class AddOfferPage : Page
    {
        Offer offernull;
        public AddOfferPage(Offer offer)
        {
            InitializeComponent();
            comboClent.ItemsSource = MainWindow.db.Client.ToList();
            comboRealtor.ItemsSource = MainWindow.db.Realtor.ToList();
            comboProperty.ItemsSource = MainWindow.db.Property.ToList();
            comboClent.DisplayMemberPath = "FirstName";
            comboRealtor.DisplayMemberPath = "FirstName";
            comboProperty.DisplayMemberPath = "ID";
            if (offer != null)
            {
                addButton.Content = "Изменить";
                this.offernull = MainWindow.db.Offer.Attach( offer);
                DataContext = this.offernull;
                comboClent.SelectedItem = offernull.Client;
                comboRealtor.SelectedItem = offernull.Realtor;
                comboProperty.SelectedItem = offernull.Property;
                textPrice.Text = this.offernull.Price.ToString();
            }
            else
            {
                addButton.Content = "Добавить";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (offernull!=null)
            {
                offernull.Price = Convert.ToDecimal(textPrice.Text);
                //offernull.ClientId =Convert.ToInt32((comboClent.SelectedItem as Client).ID);
                //offernull.RealtorId = Convert.ToInt32((comboRealtor.SelectedItem as Realtor).ID);
                //offernull.PropertyId = Convert.ToInt32((comboProperty.SelectedItem as Property).ID);
                offernull.Client = comboClent.SelectedItem as Client;
                offernull.Realtor = comboRealtor.SelectedItem as Realtor;
                offernull.Property = comboProperty.SelectedItem as Property;
                MainWindow.db.SaveChanges();
                MessageBox.Show("Изменено!","Информация!",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            if (offernull==null)
            {
                offernull = new Offer();
                offernull.Client = comboClent.SelectedItem as Client;
                offernull.Realtor = comboRealtor.SelectedItem as Realtor;
                offernull.Property = comboProperty.SelectedItem as Property;
                offernull.Price = Convert.ToDecimal(textPrice.Text);
                MainWindow.db.Offer.Add(offernull);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Добавлено!!", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OfferPage());
        }
    }
}
