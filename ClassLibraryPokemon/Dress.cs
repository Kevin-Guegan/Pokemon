using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace ClassLibraryPokemon
{
    public class Dresses : EntityBase
    {
        public string Name { get; set; }
        public BitmapImage Img { get; set; }
        public BitmapImage Vignette { get; set; }

        public static List<Dresses> DressesList
        {
            get;
            set;
        }

        public Dresses()
        {

        }

        public Dresses(string name, BitmapImage img, BitmapImage vignette)
        {
            this.Name = name;
            this.Img = img;
            this.Vignette = vignette;
        }

        public static List<Dresses> GetDressesList()
        {
            if (DressesList == null)
            {
                var list = new List<Dresses>();

                list.Add(new Dresses("Haut", 
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut.png")), 
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut2.png"))));
                list.Add(new Dresses("Jupe",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-jupe.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-jupe2.png"))));
                list.Add(new Dresses("Noeud",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-noeud2.png"))));
                list.Add(new Dresses("Chaussures",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-chaussure.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-chaussure2.png"))));
                list.Add(new Dresses("Manchettes",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-manchette.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-manchette2.png"))));
                list.Add(new Dresses("Queue",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-queue.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-queue2.png"))));
                DressesList = list;
            }
            
            return DressesList;
        }
    }
}