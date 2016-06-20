using Pokemon.Pages;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon.UsersControls
{
    public sealed partial class Menu : UserControl
    {
        public Menu()
        {
            this.InitializeComponent();

            /*var page = (Window.Current.Content as Frame).Content as Promenade;
            if (page != null)
            {
                BackgroundMenu.Background = new SolidColorBrush(Colors.White);
            }*/
        }

        private void Home_On_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(MainPageView));
        }

        private void Save_On_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            buttonSave.Flyout.Hide();
        }

        private void ExitButtonOnTapped(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
