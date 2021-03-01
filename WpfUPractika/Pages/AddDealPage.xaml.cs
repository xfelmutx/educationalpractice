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
    /// Логика взаимодействия для AddDealPage.xaml
    /// </summary>
    public partial class AddDealPage : Page
    {
        Deal dealnull;
        public AddDealPage(Deal deal)
        {
            InitializeComponent();
            comboNeed.ItemsSource = MainWindow.db.Need.ToList();
            comboOffer.ItemsSource = MainWindow.db.Offer.ToList();
            comboNeed.DisplayMemberPath = "ID";
            comboOffer.DisplayMemberPath = "ID";
            if (deal !=null)
            {
                this.addButton.Content = "Изменить";
                this.dealnull =MainWindow.db.Deal.Attach( deal);
                this.DataContext = dealnull;
                comboNeed.SelectedItem = dealnull.Need;
                comboOffer.SelectedItem = dealnull.Offer;
                //comboNeed.SelectedIndex = dealnull.Need.TypeProperty.ID - 1;
                //comboOffer.SelectedIndex = dealnull.Offer.Property.TypeProperty.ID - 1;
            }
            else
            {
                this.addButton.Content = "Добавить";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (dealnull !=null)
            {
                dealnull.Need = comboNeed.SelectedItem as Need;
                dealnull.Offer = comboOffer.SelectedItem as Offer;
                //dealnull.NeedId= Convert.ToInt32((comboNeed.SelectedItem as Need).ID);
                //dealnull.OfferId = Convert.ToInt32((comboOffer.SelectedItem as Offer).ID);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Изменено!","Информация",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            if (dealnull==null)
            {
                dealnull = new Deal();
                dealnull.Need = comboNeed.SelectedItem as Need;
                dealnull.Offer = comboOffer.SelectedItem as Offer;
                MainWindow.db.Deal.Add(dealnull);
                MainWindow.db.SaveChanges();
                MessageBox.Show("Добавлено!", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DealPage());
        }
    }
}
