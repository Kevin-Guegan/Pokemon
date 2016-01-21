using Dress.Classes;
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

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon.Pages
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class Concours : Page
    {
        public int indexListe;

        public Concours()
        {
            this.InitializeComponent();
            DataContext = Dresses.GetDressesList();
        }

        private void On_imageNavRight_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //DressesListView.ScrollIntoView(DressesListView.Items[2]);
        }

        private void On_imageNavLeft_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //DressesListView.ScrollIntoView(DressesListView.Items[0]);
        }

        private void On_Dress_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var vignette = sender as StackPanel;
            if (vignette.Tag == "Haut")
            {
                if(Haut.Opacity == 1)
                {
                    Haut.Opacity = 0;
                }
                else
                {
                    Haut.Opacity = 1;
                }
            }
            if (vignette.Tag == "Jupe")
            {
                if (Jupe.Opacity == 1)
                {
                    Jupe.Opacity = 0;
                }
                else
                {
                    Jupe.Opacity = 1;
                }
            }
            if (vignette.Tag == "Noeud")
            {
                if (Noeud.Opacity == 1)
                {
                    Noeud.Opacity = 0;
                }
                else
                {
                    Noeud.Opacity = 1;
                }
            }
            if (vignette.Tag == "Chaussures")
            {
                if (Chaussures.Opacity == 1)
                {
                    Chaussures.Opacity = 0;
                }
                else
                {
                    Chaussures.Opacity = 1;
                }
            }
            if (vignette.Tag == "Manchettes")
            {
                if (Manchettes.Opacity == 1)
                {
                    Manchettes.Opacity = 0;
                }
                else
                {
                    Manchettes.Opacity = 1;
                }
            }
            if (vignette.Tag == "Queue")
            {
                if (Queue.Opacity == 1)
                {
                    Queue.Opacity = 0;
                }
                else
                {
                    Queue.Opacity = 1;
                }
            }
        }

    }
}
