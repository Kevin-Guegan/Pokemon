using System;
using Pokemon.Views;
using ClassLibraryPokemon;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Pokemon.UserControls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon.UserControls
{
    public sealed partial class MenuUserControl : BaseUserControl
    {
        public MenuUserControl()
        {
            this.InitializeComponent();
        }

        private void Home_On_Tapped(object sender, TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(MainView));
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
