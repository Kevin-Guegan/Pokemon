using System;
using Pokemon.Views;
using ClassLibraryPokemon;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Pokemon.UserControls;

namespace Pokemon.UserControls
{
    public sealed partial class ExitUserControl : BaseUserControl
    {
        public ExitUserControl()
        {
            this.InitializeComponent();
        }

        private void Exit_On_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();
        }
    }
}
