﻿using System;
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

namespace dsi_mockup_pero_en_xaml_xd
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class gameplay : Page
    {
        public ImageSource imgS;
        public gameplay()
        {
            this.InitializeComponent();

            
        }



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

        private void Map_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {

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

        }
        private void Log_startHover(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.UriSource = new Uri("ms-appx:///Assets/map.png");
            hoverImg.Source = bi;

            hoverImg.Height = 394;
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Menu.Visibility = Visibility.Collapsed;
        }

        private void stopHover(object sender, RoutedEventArgs e)
        {
            BitmapImage bi = new BitmapImage();
            bi.UriSource = new Uri("ms-appx:///Assets/Blck.png");

            hoverImg.Source = bi;

            hoverImg.Height = 394;
        }

    }


}

