using Pokemon.Pages;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pokemon
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void On_Pokedex_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(Pokedex));
        }

        private void On_Combat_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(Combat));
        }

        private void On_Concours_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(Concours));
        }

        private void On_Promenade_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(Promenade));
        }


        public object TextPokedex
        {
            get {
                return (string)GetValue(TextPokedexProperty);
            }
            set {
                SetValue(TextPokedexProperty, value);
            }
        }
        public static readonly DependencyProperty TextPokedexProperty =
        DependencyProperty.Register("Pokedex", typeof(string),
        typeof(MainPage), new PropertyMetadata(null));
    }
}
