using Pokemon.ViewModels;
using ClassLibraryPokemon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace Pokemon.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class ConcoursView : Page
    {
        public int indexListe;

        public ConcoursView()
        {
            this.InitializeComponent();
            DataContext = Dress_old.GetDressesList();
        }

        private void On_imageNavRight_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //DressesListView.ScrollIntoView(DressesListView.Items[2]);
        }

        private void On_imageNavLeft_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //DressesListView.ScrollIntoView(DressesListView.Items[0]);
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            PhotoSave.Flyout.Hide();
        }

        private void On_Dress_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var vignette = sender as StackPanel;
            if (vignette.Tag == "Haut")
            {
                if(Haut.Opacity == 1)
                {
                    Haut.Opacity = 0;
                    vignette.BorderBrush = new SolidColorBrush(Colors.White);

                }
                else
                {
                    Haut.Opacity = 1;
                    vignette.BorderBrush = new SolidColorBrush(Colors.DeepPink);
                }
            }
            if (vignette.Tag == "Jupe")
            {
                if (Jupe.Opacity == 1)
                {
                    Jupe.Opacity = 0;
                    vignette.BorderBrush = new SolidColorBrush(Colors.White);
                }
                else
                {
                    Jupe.Opacity = 1;
                    vignette.BorderBrush = new SolidColorBrush(Colors.DeepPink);
                }
            }
            if (vignette.Tag == "Noeud")
            {
                if (Noeud.Opacity == 1)
                {
                    Noeud.Opacity = 0;
                    vignette.BorderBrush = new SolidColorBrush(Colors.White);
                }
                else
                {
                    Noeud.Opacity = 1;
                    vignette.BorderBrush = new SolidColorBrush(Colors.DeepPink);
                }
            }
            if (vignette.Tag == "Chaussures")
            {
                if (Chaussures.Opacity == 1)
                {
                    Chaussures.Opacity = 0;
                    vignette.BorderBrush = new SolidColorBrush(Colors.White);
                }
                else
                {
                    Chaussures.Opacity = 1;
                    vignette.BorderBrush = new SolidColorBrush(Colors.DeepPink);
                }
            }
            if (vignette.Tag == "Manchettes")
            {
                if (Manchettes.Opacity == 1)
                {
                    Manchettes.Opacity = 0;
                    vignette.BorderBrush = new SolidColorBrush(Colors.White);
                }
                else
                {
                    Manchettes.Opacity = 1;
                    vignette.BorderBrush = new SolidColorBrush(Colors.DeepPink);
                }
            }
            if (vignette.Tag == "Queue")
            {
                if (Queue.Opacity == 1)
                {
                    Queue.Opacity = 0;
                    vignette.BorderBrush = new SolidColorBrush(Colors.White);
                }
                else
                {
                    Queue.Opacity = 1;
                    vignette.BorderBrush = new SolidColorBrush(Colors.DeepPink);
                }
            }
        }

    }
}
