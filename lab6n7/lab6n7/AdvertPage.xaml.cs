using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace lab6n7
{
    /// <summary>
    /// Логика взаимодействия для AdvertPage.xaml
    /// </summary>
    public partial class AdvertPage : UserControl
    {
        private object advertObject;
        public AdvertPage(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            InitializeComponent();
            var dataInRow = (DataGridRow)sender;
            advertObject = dataInRow.Item;

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            AdvertInGrid advert = (AdvertInGrid)advertObject;
            AdFullNameTextBox.Text = advert.FullName;
            AdShortNameTextBox.Text = advert.ShortName;
            AdRaitingTextBox.Text = (advert.Raiting).ToString();
            AdCategoryTextBox.Text = (advert.Category).ToString();
            AdCostTextBox.Text = (advert.Cost).ToString();
            AdAmountTextBox.Text = (advert.Amount).ToString();
            for(var i = 0; i < advert.Images.Count; i++)
            {
                if (i == 0) AdMainImage.Source = ImageConverter.ImageSourceFromBitmap(advert.Images[0].Source);
                if (i == 1) AdMainImage.Source = ImageConverter.ImageSourceFromBitmap(advert.Images[1].Source);
                if (i == 2) AdMainImage.Source = ImageConverter.ImageSourceFromBitmap(advert.Images[2].Source);
                if (i == 3) AdMainImage.Source = ImageConverter.ImageSourceFromBitmap(advert.Images[3].Source);
            }
        }

        private void AdMainImageButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            ResetPicture(AdMainImage, AdMainImageWrapper);
        }

        private void AdSubImage1ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            ResetPicture(AdSubImage1, AdSubImage1Wrapper);
        }

        private void AdSubImage2ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            ResetPicture(AdSubImage2, AdSubImage2Wrapper);
        }

        private void AdSubImage3ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            ResetPicture(AdSubImage3, AdSubImage3Wrapper);
        }

        private void ResetPicture(System.Windows.Controls.Image img, Grid grid)
        {
            img.Source = null;
            grid.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(192, 192, 192));
        }
    }
}
