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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Promenade : Page
    {
        public Promenade()
        {
            this.InitializeComponent();
        }

        private void NavBotOnTapped(object sender, TappedRoutedEventArgs e)
        {
            var uriImage = new Uri("ms-appx:///Assets/SachaBot.png");
            var image = new BitmapImage(uriImage);

            Player.Source = image;
        }

        private void NavRightOnTapped(object sender, TappedRoutedEventArgs e)
        {
            var uriImage = new Uri("ms-appx:///Assets/SachaRight.png");
            var image = new BitmapImage(uriImage);

            Player.Source = image;
        }

        private void NavLeftOnTapped(object sender, TappedRoutedEventArgs e)
        {
            var uriImage = new Uri("ms-appx:///Assets/SachaLeft.png");
            var image = new BitmapImage(uriImage);

            Player.Source = image;
        }

        private void NavTopOnTapped(object sender, TappedRoutedEventArgs e)
        {
            var uriImage = new Uri("ms-appx:///Assets/SachaTop.png");
            var image = new BitmapImage(uriImage);

            Player.Source = image;
        }
    }
}
