using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Media.Imaging;

namespace ClassLibraryPokemon
{
    public class Pokemon : EntityBase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public string Number { get; set; }

        public string Health { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        internal List<Attack> Attack { get; set; }

        internal List<Dress> Dress { get; set; }

        public BitmapImage ImgPokedex { get; set; }

        public BitmapImage ImgDress { get; set; }

        public BitmapImage ImgFight { get; set; }

        public string Attaque1 { get; set; }

        public string Attaque2 { get; set; }

        public string Attaque3 { get; set; }

        public string Attaque4 { get; set; }

        public Pokemon()
        {

        }


        public Pokemon(int id, string name, string weight, string height, string description, string type, string number, string health, List<Dress> dress, 
            BitmapImage imgPokedex, BitmapImage imgDress, BitmapImage imgFight, string attaque1, string attaque2, string attaque3, string attaque4)
        {
            this.Id = id;
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Description = description;
            this.Type = type;
            this.Number = number;
            this.Health = health;
            this.Dress = dress;
            this.ImgPokedex = imgPokedex;
            this.ImgDress = imgDress;
            this.ImgFight = imgFight;
            this.Attaque1 = attaque1;
            this.Attaque2 = attaque2;
            this.Attaque3 = attaque3;
            this.Attaque4 = attaque4;
        }

        internal static List<Pokemon> PokemonList { get; set; }

        public static Pokemon GetPokemonById(int id)
        {
            var dresses = new List<Dress>();
            var pokemon = new Pokemon();
            Uri uriImage = new Uri("ms-appx:///");
            var image = new BitmapImage();

            if (id == 1)
            {
                uriImage = new Uri("ms-appx:///Assets/pikachu.png");
                image = new BitmapImage(uriImage);
                pokemon = new Pokemon(1, "Pikachu", "6.0 kg", "0.4 m", "Sa queue est dressée quand il est aux aguets",
                    "Foudre", "#025", "10", dresses, image, image, image, "Eclair", "Vive-Attaque", "Tonnerre", "Fatal-Foudre");
            }
            else if (id == 2)
            {
                uriImage = new Uri("ms-appx:///Assets/carapuce.png");
                image = new BitmapImage(uriImage);
                pokemon = new Pokemon(2, "Carapuce", "9.0 kg", "0.5 m", "Il se réfugie dans sa carapace et réplique en éclaboussant l'ennemi à la première occasion.",
                    "Eau", "#007", "10", dresses, image, image, image, "Charge", "Mimi-Queue", "Ecume", "Pistolet à O");
            }
            else if (id == 3)
            {
                uriImage = new Uri("ms-appx:///Assets/salameche.png");
                image = new BitmapImage(uriImage);
                pokemon = new Pokemon(3, "Salamèche", "8.5 kg", "0.6m", "La flamme de sa queue symbolise sa vitalité. Elle est intense quand il est en bonne santé.",
                    "Feu", "#004", "10", dresses, image, image, image, "Griffe", "Rugissement", "Flamèche", "Brouillard");
            }
            else
            {
                pokemon = null;
            }

            return pokemon;
        }

        public static List<Pokemon> PokemonsList
        {
            get;
            set;
        }

        public static List<Pokemon> GetPokemonsList()
        {
            if (PokemonsList == null)
            {
                var list = new List<Pokemon>();

                var attacks = new List<Attack>();
                var dresses = new List<Dress>();

                list.Add(new Pokemon(1, "Pikachu", "6.0 kg", "0.4 m", "Sa queue est dressée quand il est aux aguets",
                    "Foudre", "#025", "10", dresses,
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu.png")),
                    "Eclair", "Vive-Attaque", "Tonnerre", "Fatal-Foudre"));
                list.Add(new Pokemon(2, "Carapuce", "9.0 kg", "0.5 m", "Il se réfugie dans sa carapace et réplique en éclaboussant l'ennemi à la première occasion.",
                    "Eau", "#007", "10", dresses,
                    new BitmapImage(new Uri("ms-appx:///Assets/carapuce.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/carapuce.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/carapuce.png")),
                    "Charge", "Mimi-Queue", "Ecume", "Pistolet à O"));
                list.Add(new Pokemon(3, "Salamèche", "8.5 kg", "0.6m", "La flamme de sa queue symbolise sa vitalité.Elle est intense quand il est en bonne santé.",
                    "Feu", "#004", "10", dresses,
                    new BitmapImage(new Uri("ms-appx:///Assets/salameche.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/salameche.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/salameche.png")),
                    "Griffe", "Rugissement", "Flamèche", "Brouillard"));
                PokemonsList = list;
            }

            return PokemonsList;
        }
    }
}
