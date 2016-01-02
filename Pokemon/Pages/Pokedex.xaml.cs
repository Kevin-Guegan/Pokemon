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
using Pokemon.Classes;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Pokedex : Page
    {
        /// <summary>
        /// 
        /// </summary>
        public Pokedex()
        {
            this.InitializeComponent();
            Pokemons pokemon = new Pokemons();

            pokemon.Name = "Pikachu";
            pokemon.Number = "#025";
            pokemon.Weight = "6.0 kg";
            pokemon.Height = "0.4 m";
            pokemon.Description = "Sa queue est dressée quand il est aux aguets.";
            pokemon.Type = "Foudre.";
            
            NamePokemon.Text = pokemon.Name;
            NumberPokemon.Text = pokemon.Number;
            HeightValue.Text = pokemon.Height;
            WeightValue.Text = pokemon.Weight;
            DescriptionPokemon.Text = pokemon.Description;
            TypePokemon.Text = pokemon.Type;

        }

        private void On_imageNavLeft_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Pokemons pokemon = new Pokemons();

            pokemon.Name = this.NamePokemon.Text;
            
            if (pokemon.Name == "Pikachu")
            {
                pokemon.Name = "Carapuce";
                pokemon.Number = "#007";
                pokemon.Weight = "9.0 kg";
                pokemon.Height = "0.5 m";
                pokemon.Description = "Il se réfugie dans sa carapace et réplique en éclaboussant l'ennemi à la première occasion.";
                pokemon.Type = "Eau.";
                

            }
            else if(pokemon.Name == "Salamèche")
            {
                pokemon.Name = "Pikachu";
                pokemon.Number = "#025";
                pokemon.Weight = "6.0 kg";
                pokemon.Height = "0.4 m";
                pokemon.Description = "Sa queue est dressée quand il est aux aguets.";
                pokemon.Type = "Foudre.";
            }
            

            NamePokemon.Text = pokemon.Name;
            NumberPokemon.Text = pokemon.Number;
            HeightValue.Text = pokemon.Height;
            WeightValue.Text = pokemon.Weight;
            DescriptionPokemon.Text = pokemon.Description;
            TypePokemon.Text = pokemon.Type;
            
        }

        private void On_imageNavRight_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Pokemons pokemon = new Pokemons();

            pokemon.Name = this.NamePokemon.Text;

            if (pokemon.Name == "Pikachu")
            {
                pokemon.Name = "Salamèche";
                pokemon.Number = "#004";
                pokemon.Weight = "8.5 kg";
                pokemon.Height = "0.6 m";
                pokemon.Description = "La flamme de sa queue symbolise sa vitalité. Elle est intense quand il est en bonne santé.";
                pokemon.Type = "Feu.";
            }
            else if (pokemon.Name == "Carapuce")
            {
                pokemon.Name = "Pikachu";
                pokemon.Number = "#025";
                pokemon.Weight = "6.0 kg";
                pokemon.Height = "0.4 m";
                pokemon.Description = "Sa queue est dressée quand il est aux aguets.";
                pokemon.Type = "Foudre.";
            }

            NamePokemon.Text = pokemon.Name;
            NumberPokemon.Text = pokemon.Number;
            HeightValue.Text = pokemon.Height;
            WeightValue.Text = pokemon.Weight;
            DescriptionPokemon.Text = pokemon.Description;
            TypePokemon.Text = pokemon.Type;
        }
    }
}
