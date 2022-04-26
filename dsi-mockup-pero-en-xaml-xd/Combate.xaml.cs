using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_Mockup
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Combate : Page
    {
        public Combate()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void Border_Click(object sender, RoutedEventArgs e)
        {
            if (fireman.BorderThickness != new Thickness(0))
                fireman.BorderThickness = new Thickness(0);
            if (Medic.BorderThickness != new Thickness(0))
                Medic.BorderThickness = new Thickness(0);
            if (Police.BorderThickness != new Thickness(0))
                Police.BorderThickness = new Thickness(0);
            if (Army.BorderThickness != new Thickness(0))
                Army.BorderThickness = new Thickness(0);
            Button boton = sender as Button;
            boton.BorderBrush = new SolidColorBrush(Colors.LightGreen);
            boton.BorderThickness = new Thickness(10);
        }

        private void EneBorder_Click(object sender, RoutedEventArgs e)
        {
            if (ene1.BorderThickness != new Thickness(0))
                ene1.BorderThickness = new Thickness(0);
            if (ene2.BorderThickness != new Thickness(0))
                ene2.BorderThickness = new Thickness(0);
            if (ene3.BorderThickness != new Thickness(0))
                ene3.BorderThickness = new Thickness(0);
            if (ene4.BorderThickness != new Thickness(0))
                ene4.BorderThickness = new Thickness(0);
            Button boton = sender as Button;
            boton.BorderBrush = new SolidColorBrush(Colors.LightYellow);
            boton.BorderThickness = new Thickness(10);
        }
    }
}
