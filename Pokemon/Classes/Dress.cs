using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;


namespace Dress.Classes
{
    class Dresses
    {
        public string Name { get; set; }
        public BitmapImage Img { get; set; }
        public string Margin { get; set; }

        private static List<Dresses> dressesList;
        public static List<Dresses> DressesList
        {
            get;
            set;
        }

        public Dresses()
        {

        }

        public Dresses(string name, BitmapImage img, string margin)
        {
            this.Name = name;
            this.Img = img;
            this.Margin = margin;
        }

        public static List<Dresses> GetDressesList()
        {
            if (dressesList == null)
            {
                var uriImage = new Uri("ms-appx:///Assets/pikachu-beaute-haut.png");
                var image = new BitmapImage(uriImage);
                dressesList.Add(new Dresses("Haut", image, "-52,-93,-102,-53"));

                uriImage = new Uri("ms-appx:///Assets/pikachu-beaute-jupe.png");
                image = new BitmapImage(uriImage);
                dressesList.Add(new Dresses("Jupe", image, "-3,-83,-23,-40"));

                uriImage = new Uri("ms-appx:///Assets/pikachu-beaute-noeud.png");
                image = new BitmapImage(uriImage);
                dressesList.Add(new Dresses("Noeud", image, "-12,-56,-56,-149"));

                uriImage = new Uri("ms-appx:///Assets/pikachu-beaute-chaussure.png");
                image = new BitmapImage(uriImage);
                dressesList.Add(new Dresses("Chaussures", image, "-12,-56,-56,-149"));

                uriImage = new Uri("ms-appx:///Assets/pikachu-beaute-manchette.png");
                image = new BitmapImage(uriImage);
                dressesList.Add(new Dresses("Manchettes", image, "-12,-56,-56,-149"));
           
                uriImage = new Uri("ms-appx:///Assets/pikachu-beaute-queue.png");
                image = new BitmapImage(uriImage);
                dressesList.Add(new Dresses("Queue", image, "-12,-56,-56,-149"));
            }
            return dressesList;
        }
    }
}