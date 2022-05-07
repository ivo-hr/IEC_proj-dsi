using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using System.ComponentModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_Mockup
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class gameplay : Page, INotifyPropertyChanged
    {
        private DispatcherTimer _timer;

        public gameplay()
        {
            this.InitializeComponent();

            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

            _timer.Tick += (sender, o) =>
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentTime)));

            _timer.Start();


        }

        public string CurrentTime
        {
            get { return DateTime.Now.ToLongTimeString(); }
        }

        public string CurrentDate
        {
            get { return DateTime.Now.ToLongDateString(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Visible;
        }
        private void Map_startHover(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.UriSource = new Uri("ms-appx:///Assets/map.png");
            hoverImg.Source = bi;

            hoverImg.Height = 394;
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaUnoOpciones));
        }

        private void Inv_startHover(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.UriSource = new Uri("ms-appx:///Assets/inv_hover.png");
            hoverImg.Source = bi;

            hoverImg.Height = 394;
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            Inv.Visibility = Visibility.Visible;
        }
        private void Party_startHover(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.UriSource = new Uri("ms-appx:///Assets/party_hover.png");
            hoverImg.Source = bi;

            hoverImg.Height = 394;
        }

        private void Party_Click(object sender, RoutedEventArgs e)
        {
            Party.Visibility = Visibility.Visible;
        }
        private void Log_startHover(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.UriSource = new Uri("ms-appx:///Assets/log_hover.png");
            hoverImg.Source = bi;

            hoverImg.Height = 394;
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            Log.Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Collapsed;
        }
        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            Pause.Visibility = Visibility.Collapsed;
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            Pause.Visibility = Visibility.Visible;
        }

        private void stopHover(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.UriSource = new Uri("ms-appx:///Assets/Blck.png");

            hoverImg.Source = bi;

            hoverImg.Height = 394;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Combate));
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Wait_Click(object sender, RoutedEventArgs e)
        {
            Exit.Visibility = Visibility.Visible;
        }

        private void Back3_Click(object sender, RoutedEventArgs e)
        {
            Inv.Visibility = Visibility.Collapsed;
        }

        private void Back4_Click(object sender, RoutedEventArgs e)
        {
            Log.Visibility = Visibility.Collapsed;
        }

        private void Back5_Click(object sender, RoutedEventArgs e)
        {
            Party.Visibility = Visibility.Collapsed;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }


}

