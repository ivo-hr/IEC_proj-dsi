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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DSI_Mockup
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PaginaUnoTrans : Page
    {
        public PaginaUnoTrans()
        {
            this.InitializeComponent();
        }
        private void Page1Options_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PaginaUnoOpciones));
        }
        private void Page1Return_OnClick(object sender, RoutedEventArgs e)
        {
            if (Frame.CanGoBack)
            {
                Frame.GoBack();
            }
        }

        private void Page1Gameplay_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(gameplay));
        }
    }
}
