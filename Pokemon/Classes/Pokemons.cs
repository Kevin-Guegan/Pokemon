using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Pokemon.Classes
{
    class Pokemons
    {
        public string Name { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public string Number { get; set; }

        public string Health { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        internal List<Attack> Attack { get; set; }

        internal List<Dress> Dress { get; set; }

        public Image Imgpokedex { get; set; }

        public Image Imgdress { get; set; }

        public Image Imgfight { get; set; }

        public Pokemons()
        {

        }

        public Pokemons(string name, string weight, string height, string Description, string type, string number, string health, List<Attack> attack, List<Dress> dress, Image imgpokedex, Image imgdress, Image imgfight)
        {
            this.Name = name;
            this.Weight = weight;
            this.Height = height;
            this.Number = number;
            this.Health = health;
            this.Attack = attack;
            this.Dress = dress;
            this.Imgpokedex = imgpokedex;
            this.Imgdress = imgdress;
            this.Imgfight = imgfight;
        }



       

    }


}
