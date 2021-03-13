using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace lab6n7
{
    /// <summary>
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : UserControl
    {

        public List<AdvertInGrid> ResultCollection { get; set; }

        public HomePage()
        {
            InitializeComponent();
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            List<Advert> adList = Serialization.Deserialize();
            ResultCollection = new List<AdvertInGrid>();
            foreach (var el in adList)
            {
                ResultCollection.Add(new AdvertInGrid { FullName = el.FullName, ShortName = el.ShortName, Category = el.Category, Raiting = el.Raiting, Cost = el.Cost, Amount = el.Amount, AdvertImage = ImageConverter.ImageSourceFromBitmap(el.Images[0].Source), Images = el.Images });
            }
            MainGrid.ItemsSource = ResultCollection;
        }
    }
}
