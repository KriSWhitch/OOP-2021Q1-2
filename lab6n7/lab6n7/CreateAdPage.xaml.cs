using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace lab6n7
{
    /// <summary>
    /// Логика взаимодействия для CreateAdPage.xaml
    /// </summary>
    public partial class CreateAdPage : UserControl
    {
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
            AdMainImageWrapper.Background = new SolidColorBrush(Color.FromRgb(192, 192, 192));
        }

        private void AdSubImage1ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            AdSubImage1.Source = null;
            AdSubImage1Wrapper.Background = new SolidColorBrush(Color.FromRgb(192, 192, 192));
        }

        private void AdSubImage2ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            AdSubImage2.Source = null;
            AdSubImage2Wrapper.Background = new SolidColorBrush(Color.FromRgb(192, 192, 192));
        }

        private void AdSubImage3ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Visibility = Visibility.Collapsed;
            AdSubImage3.Source = null;
            AdSubImage3Wrapper.Background = new SolidColorBrush(Color.FromRgb(192, 192, 192));
        }


    }
}
