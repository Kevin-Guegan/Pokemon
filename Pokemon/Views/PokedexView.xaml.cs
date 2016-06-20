using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Pokemon.ViewsModels;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class PokedexView : Page
    {
        public int indexListe;
        /// <summary>
        /// 
        /// </summary>
        public PokedexView()
        {
            this.InitializeComponent();

            indexListe = 1;
            var pokemon = Pokemons.GetPokemonById(indexListe);
            
            image.Source = pokemon.ImgPokedex;
            NamePokemon.Text = pokemon.Name;
            NumberPokemon.Text = pokemon.Number;
            HeightValue.Text = pokemon.Height;
            WeightValue.Text = pokemon.Weight;
            DescriptionPokemon.Text = pokemon.Description;
            TypePokemon.Text = pokemon.Type;
            Attaque1.Text = "- " + pokemon.Attaque1;
            Attaque2.Text = "- " + pokemon.Attaque2;
            Attaque3.Text = "- " + pokemon.Attaque3;
            Attaque4.Text = "- " + pokemon.Attaque4;
        }

        private void On_imageNavLeft_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indexListe--;
            var pokemon = Pokemons.GetPokemonById(indexListe);
            if (pokemon != null)
            {
                image.Source = pokemon.ImgPokedex;
                NamePokemon.Text = pokemon.Name;
                NumberPokemon.Text = pokemon.Number;
                HeightValue.Text = pokemon.Height;
                WeightValue.Text = pokemon.Weight;
                DescriptionPokemon.Text = pokemon.Description;
                TypePokemon.Text = pokemon.Type;
                Attaque1.Text = "- " + pokemon.Attaque1;
                Attaque2.Text = "- " + pokemon.Attaque2;
                Attaque3.Text = "- " + pokemon.Attaque3;
                Attaque4.Text = "- " + pokemon.Attaque4;
            }
            else
            {
                indexListe++;
            }
        }

        private void On_imageNavRight_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indexListe++;
            var pokemon = Pokemons.GetPokemonById(indexListe);
            if (pokemon != null)
            {
                image.Source = pokemon.ImgPokedex;
                NamePokemon.Text = pokemon.Name;
                NumberPokemon.Text = pokemon.Number;
                HeightValue.Text = pokemon.Height;
                WeightValue.Text = pokemon.Weight;
                DescriptionPokemon.Text = pokemon.Description;
                TypePokemon.Text = pokemon.Type;
                Attaque1.Text = "- " + pokemon.Attaque1;
                Attaque2.Text = "- " + pokemon.Attaque2;
                Attaque3.Text = "- " + pokemon.Attaque3;
                Attaque4.Text = "- " + pokemon.Attaque4;
            }
            else
            {
                indexListe--;
            }
        }
    }
}
