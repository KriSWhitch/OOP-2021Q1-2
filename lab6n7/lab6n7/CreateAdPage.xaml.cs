using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
using System.Xml.Serialization;

namespace lab6n7
{
    /// <summary>
    /// Логика взаимодействия для CreateAdPage.xaml
    /// </summary>
    public partial class CreateAdPage : UserControl
    {

        bool completenessFlag = false;

        public CreateAdPage()
        {
            InitializeComponent();
        }

        private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true) 
            {
                if (AdMainImage.Source == null) 
                {
                    AdMainImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    AdMainImageButtonClose.Visibility = Visibility.Visible;
                    AdMainImageWrapper.Background = new SolidColorBrush(Colors.Transparent);
                } 
                else if (AdSubImage1.Source == null)
                {
                    AdSubImage1.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    AdSubImage1ButtonClose.Visibility = Visibility.Visible;
                    AdSubImage1Wrapper.Background = new SolidColorBrush(Colors.Transparent);
                }
                else if (AdSubImage2.Source == null)
                {
                    AdSubImage2.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    AdSubImage2ButtonClose.Visibility = Visibility.Visible;
                    AdSubImage2Wrapper.Background = new SolidColorBrush(Colors.Transparent);
                }
                else if (AdSubImage3.Source == null)
                {
                    AdSubImage3.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                    AdSubImage3ButtonClose.Visibility = Visibility.Visible;
                    AdSubImage3Wrapper.Background = new SolidColorBrush(Colors.Transparent);
                }
                else
                {
                    MessageBox.Show("Вы не можете добавить более 4-х фотографий!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            
            
        }

        private void AdMainImageButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            AdMainImage.Source = null;
            AdMainImageWrapper.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(192, 192, 192));
        }

        private void AdSubImage1ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            AdSubImage1.Source = null;
            AdSubImage1Wrapper.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(192, 192, 192));
        }

        private void AdSubImage2ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            AdSubImage2.Source = null;
            AdSubImage2Wrapper.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(192, 192, 192));
        }

        private void AdSubImage3ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            AdSubImage3.Source = null;
            AdSubImage3Wrapper.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb(192, 192, 192));
        }

        private void CreateAdButton_Click(object sender, RoutedEventArgs e)
        {
            completenessFlag = false;
            if 
            (
                AdFullNameTextBox.Text.Length > 0 && AdShortNameTextBox.Text.Length > 0 &&
                AdRaitingTextBox.Text.Length > 0 && AdCostTextBox.Text.Length > 0 &&
                AdCategoryTextBox.Text.Length > 0 && (AdMainImage.Source != null || AdSubImage1.Source != null || AdSubImage2.Source != null || AdSubImage3.Source != null)
            ) completenessFlag = true;


            if (completenessFlag)
            {
                Advert ad = new Advert();
                ad.fullName = AdFullNameTextBox.Text;
                ad.shortName = AdShortNameTextBox.Text;
                ad.raiting = Double.Parse(AdRaitingTextBox.Text);
                ad.cost = Convert.ToDecimal(AdCostTextBox.Text);
                ad.category = AdCategoryTextBox.Text;
                ad.amount = Convert.ToInt32(AdAmountTextBox.Text);
                if (AdMainImage.Source != null) ad.images.Add(new Picture(ImageConverter.ConvertToBitmap(AdMainImage.Source as BitmapImage)));
                if (AdSubImage1.Source != null) ad.images.Add(new Picture(ImageConverter.ConvertToBitmap(AdSubImage1.Source as BitmapImage)));
                if (AdSubImage2.Source != null) ad.images.Add(new Picture(ImageConverter.ConvertToBitmap(AdSubImage2.Source as BitmapImage)));
                if (AdSubImage3.Source != null) ad.images.Add(new Picture(ImageConverter.ConvertToBitmap(AdSubImage3.Source as BitmapImage)));
                Serialization.Serialize(ad);
            }
            else
            {
                MessageBox.Show(
                    "Вы не заполнили все необходимые поля!",
                    "Сообщение об ошибке",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning
                );
            }
        }

    }
}
