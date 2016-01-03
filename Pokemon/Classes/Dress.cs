namespace Pokemon.Classes
{
    internal class Dress
    {

        public static Dresses GetDressById(int id)
        {
            var source = "";
            var margin = "";

            if (id == 1)
            {
                source = "ms-appx:///Assets/pikachu-beaute-haut.png";
                margin = "-52,-93,-102,-53";
            }
            else if (id == 2)
            {
                source = "ms-appx:///Assets/pikachu-beaute-jupe.png";
                margin = "-3,-83,-23,-40";
            }
            else if (id == 3)
            {
                source = "ms-appx:///Assets/pikachu-beaute-noeud.png";
                margin = "-12,-56,-56,-149";
            }
            else
            {
                dress = null;
            }

            return dress;
        }
    }
}