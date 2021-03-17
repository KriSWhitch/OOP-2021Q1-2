using System.Windows;
using System.Windows.Input;



namespace lab6n7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Mouse.OverrideCursor = ((FrameworkElement)this.Resources["MouseCursor"]).Cursor;
        }



        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void GitHubButton_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KriSWhitch/OOP-2021Q1-2/tree/master/lab6n7");
        }

        private void ButtonFAQ_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Version 1.0 ©KriSWhitch", "FAQ", MessageBoxButton.OK);
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            GridMain.Children.Add(new HomePage(this));
        }

        private void CreateAdButton_Click(object sender, RoutedEventArgs e)
        {
            GridMain.Children.Clear();
            GridMain.Children.Add(new CreateAdPage());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HomeButton_Click(sender, e);
        }
    }
}
