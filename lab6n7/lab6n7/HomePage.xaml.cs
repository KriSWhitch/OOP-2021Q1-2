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
                ResultCollection.Add(new AdvertInGrid { FullName = el.fullName, ShortName = el.shortName, Category = el.category, Raiting = el.raiting, Cost = el.cost, Amount = el.amount, AdvertImage = ImageConverter.ImageSourceFromBitmap(el.images[0].Source), Images = el.images});
            }
            MainGrid.ItemsSource = ResultCollection;
        }
    }
}
