using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace ClassLibraryPokemon
{
    public class Dress_old : EntityBase
    {
        public string Name { get; set; }
        public BitmapImage Img { get; set; }
        public BitmapImage Vignette { get; set; }

        public static List<Dress_old> DressesList
        {
            get;
            set;
        }

        public Dress_old()
        {

        }

        public Dress_old(string name, BitmapImage img, BitmapImage vignette)
        {
            this.Name = name;
            this.Img = img;
            this.Vignette = vignette;
        }

        public static List<Dress_old> GetDressesList()
        {
            if (DressesList == null)
            {
                var list = new List<Dress_old>();

                list.Add(new Dress_old("Haut", 
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut.png")), 
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut2.png"))));
                list.Add(new Dress_old("Jupe",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-jupe.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-jupe2.png"))));
                list.Add(new Dress_old("Noeud",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-haut.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-noeud2.png"))));
                list.Add(new Dress_old("Chaussures",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-chaussure.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-chaussure2.png"))));
                list.Add(new Dress_old("Manchettes",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-manchette.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-manchette2.png"))));
                list.Add(new Dress_old("Queue",
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-queue.png")),
                    new BitmapImage(new Uri("ms-appx:///Assets/pikachu-beaute-queue2.png"))));
                DressesList = list;
            }
            
            return DressesList;
        }
    }
}