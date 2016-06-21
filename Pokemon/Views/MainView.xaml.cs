using ClassLibraryPokemon;
using Pokemon.Views;
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

namespace Pokemon.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        public int indexListe;

        public MainView()
        {
            this.InitializeComponent();

            indexListe = 1;
            var pokemon = ClassLibraryPokemon.Pokemon.GetPokemonById(indexListe);
            imageList.Source = pokemon.ImgPokedex;
            //DataContext = Pokemons.GetPokemonsList();
        }

        private void On_imageNavRight_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indexListe++;
            var pokemon = ClassLibraryPokemon.Pokemon.GetPokemonById(indexListe);
            if (pokemon != null)
            {
                imageList.Source = pokemon.ImgPokedex;
            }
            else
            {
                indexListe--;
            }
        }

        private void On_imageNavLeft_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indexListe--;
            var pokemon = ClassLibraryPokemon.Pokemon.GetPokemonById(indexListe);
            if (pokemon != null)
            {
                imageList.Source = pokemon.ImgPokedex;
            }
            else
            {
                indexListe++;
            }
        }

        private void On_Pokedex_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(PokedexView));
        }

        private void On_Combat_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(CombatView));
        }

        private void On_Concours_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(ConcoursView));
        }

        private void On_Promenade_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(PromenadeView));
        }

        private void ExitButtonOnTapped(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
