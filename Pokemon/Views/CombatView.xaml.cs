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
using Pokemon.Views;
using Microsoft.Azure.Engagement;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class CombatView : EngagementPage
    {
        public CombatView()
        {
            this.InitializeComponent();
        }

        private void RetourButton_Click(object sender, RoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(MainView));
        }

        private void OnTapped_Action1(object sender, TappedRoutedEventArgs e)
        {
            ImageSource ActualImage = EnnemyPokemonLife.Source;
            var PokemonLife = EnnemyPokemonLife.Tag;
            Uri uriImage = new Uri("ms-appx:///");
            var image = new BitmapImage();

            if ((string)PokemonLife == "100")
            {
                EnnemyPokemonLife.Tag = "75";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife75_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "75")
            {
                EnnemyPokemonLife.Tag = "50";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife50_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "50")
            {
                EnnemyPokemonLife.Tag = "25";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife25_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "25")
            {
                EnnemyPokemonLife.Tag = "0";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife0_percent.png");
                image = new BitmapImage(uriImage);

                WinFlyout.Opacity = 1;
            }

            EnnemyPokemonLife.Source = image;
        }


        private void OnTapped_Action2(object sender, TappedRoutedEventArgs e)
        {
            ImageSource ActualImage = EnnemyPokemonLife.Source;
            var PokemonLife = EnnemyPokemonLife.Tag;
            Uri uriImage = new Uri("ms-appx:///");
            var image = new BitmapImage();

            if ((string)PokemonLife == "100")
            {
                EnnemyPokemonLife.Tag = "75";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife75_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "75")
            {
                EnnemyPokemonLife.Tag = "50";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife50_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "50")
            {
                EnnemyPokemonLife.Tag = "25";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife25_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "25")
            {
                EnnemyPokemonLife.Tag = "0";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife0_percent.png");
                image = new BitmapImage(uriImage);

                WinFlyout.Opacity = 1;
            }

            EnnemyPokemonLife.Source = image;
        }


        private void OnTapped_Action3(object sender, TappedRoutedEventArgs e)
        {
            ImageSource ActualImage = EnnemyPokemonLife.Source;
            var PokemonLife = EnnemyPokemonLife.Tag;
            Uri uriImage = new Uri("ms-appx:///");
            var image = new BitmapImage();

            if ((string)PokemonLife == "100")
            {
                EnnemyPokemonLife.Tag = "75";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife75_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "75")
            {
                EnnemyPokemonLife.Tag = "50";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife50_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "50")
            {
                EnnemyPokemonLife.Tag = "25";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife25_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "25")
            {
                EnnemyPokemonLife.Tag = "0";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife0_percent.png");
                image = new BitmapImage(uriImage);

                WinFlyout.Opacity = 1;
            }

            EnnemyPokemonLife.Source = image;
        }


        private void OnTapped_Action4(object sender, TappedRoutedEventArgs e)
        {
            ImageSource ActualImage = EnnemyPokemonLife.Source;
            var PokemonLife = EnnemyPokemonLife.Tag;
            Uri uriImage = new Uri("ms-appx:///");
            var image = new BitmapImage();

            if ((string)PokemonLife == "100")
            {
                EnnemyPokemonLife.Tag = "75";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife75_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "75")
            {
                EnnemyPokemonLife.Tag = "50";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife50_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "50")
            {
                EnnemyPokemonLife.Tag = "25";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife25_percent.png");
                image = new BitmapImage(uriImage);
            }
            else if ((string)PokemonLife == "25")
            {
                EnnemyPokemonLife.Tag = "0";
                uriImage = new Uri("ms-appx:///Assets/pokemonLife0_percent.png");
                image = new BitmapImage(uriImage);

                WinFlyout.Opacity = 1;
            }

            EnnemyPokemonLife.Source = image;
        }

    }
}
