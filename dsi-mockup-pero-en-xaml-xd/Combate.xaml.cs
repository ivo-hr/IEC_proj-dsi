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
using Windows.ApplicationModel.DataTransfer;
using Windows.System;

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

            switch (boton.Name){
                case "fireman":
                    abil1Desc.Text = "Dale un manguerazo y echa a tu enemigo del mapa!";
                    abil2Desc.Text = "Recobra fuerzas tomándote una barrita energética. Qué rico!";
                    abil3Desc.Text = "Lanza tu manguera al enemigo, enredándolo y bajando su  defensa!";
                    specAbilDesc.Text = "Ataca  a tu enemigo con un hacha, haciendo mucho daño!";
                    break;
                case "Medic":
                    abil1Desc.Text = "Dispara a tu enemigo con un extintor para no dejarle ver!";
                    abil2Desc.Text = "Recupera  un poco de  vida con una tirita. Justo lo que necesitaba!";
                    abil3Desc.Text = "Dale al enemigo con el extintor, aturdéndole durante un tiempo!";
                    specAbilDesc.Text = "Lanza tu extintor para que  explote, haciendo daño a todos los enemigos!";
                    break;
                case "Police":
                    abil1Desc.Text = "Pon la escalera delante tuya para aumentar  tu defensa!";
                    abil2Desc.Text = "Aumenta tu  velocidad tomando una bebida energética. Fiuum!";
                    abil3Desc.Text = "Lanza la escalera al pie de tus enemigos, reduciendo la velocidad a  todos!";
                    specAbilDesc.Text = "Pega un maporrazo con la escalera a 2 de tus enemigos. Qué daño!";
                    break;
                case "Army":
                    abil1Desc.Text = "Da a uno de tus compañeros uno de tus  objetos para que lo use!";
                    abil2Desc.Text = "Tómate  un cafe para aumentar tu  eficiencia de curación!";
                    abil3Desc.Text = "Cura un poco a uno de tus aliados!";
                    specAbilDesc.Text = "Sana por completo a  tus  aliados, además de darles un poco de defensa!";
                    break;

            }
            
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

        private void TextBlock_SelectionChanged()
        {

        }

        private void Inventario_DragStarting(UIElement sender, DragStartingEventArgs args)
        {
            ContentControl mov = sender as ContentControl;

            args.Data.SetText(mov.Name);

            args.Data.RequestedOperation = DataPackageOperation.Copy;

            switch (mov.Name)
            {
                case "Wood":
                    itemDescription.Text = "Un trozo de madera de arbol. Se puede usar para atraer a enemigos tipo fuego";
                    break;
                case "Bow":
                    itemDescription.Text = "Un arco de un solo uso que dispara una flecha de agua";
                    break;
                case "Fire":
                    itemDescription.Text = "Una fogata rápida. Quema a los enemigos o calienta a los heroes";
                    break;
                case "Brick":
                    itemDescription.Text = "Un lingote de metal. Refuerza a un heroe para que reciba menos daño durante 2 turnos";
                    break;
                case "Apple":
                    itemDescription.Text = "Una manzana al día da una vida sana. Cura a un heroe 10 puntos de vida";
                    break;
                case "Money":
                    itemDescription.Text = "Una bolsa de dinero otorgado a los heroes. Usarla te da 10 monedas";
                    break;
                default:
                    break;
            }
        }

        private void MiCanvas_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private async void MiCanvas_Drop(object sender, DragEventArgs e)
        {
            var objN = await e.DataView.GetTextAsync();
            ContentControl obj = FindName(objN.ToString()) as ContentControl;

            Point pnt = e.GetPosition(MiCanvas);

            if (obj.Parent == MiStack)
            {
                MiStack.Children.Remove(obj);
                MiCanvas.Children.Add(obj);
            }

            obj.SetValue(Canvas.LeftProperty, pnt.X - 150);
            obj.SetValue(Canvas.TopProperty, pnt.Y - 150);

            MiCanvas.Children.Remove(obj);

            itemDescription.Text = "";
        }
    }
}
