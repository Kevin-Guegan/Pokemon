using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace ClassLibraryPokemon
{
    public class Dress : EntityBase
    {
        public string Name { get; set; }
        public BitmapImage Img { get; set; }
        public BitmapImage Vignette { get; set; }

        public static List<Dress> DressesList
        {
            get;
            set;
        }

        public Dress()
        {

        }

        public Dress(string name, BitmapImage img, BitmapImage vignette)
        {
            this.Name = name;
            this.Img = img;
            this.Vignette = vignette;
        }

        public static List<Dress> GetDressesList()
        {
            if (DressesList == null)
            {
                var list = new List<Dress>();

                list.Add(new Dress("Haut", 
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut.png")), 
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut2.png"))));
                list.Add(new Dress("Jupe",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-jupe.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-jupe2.png"))));
                list.Add(new Dress("Noeud",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-noeud2.png"))));
                list.Add(new Dress("Chaussures",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-chaussure.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-chaussure2.png"))));
                list.Add(new Dress("Manchettes",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-manchette.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-manchette2.png"))));
                list.Add(new Dress("Queue",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-queue.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-queue2.png"))));
                DressesList = list;
            }
            
            return DressesList;
        }
    }
}