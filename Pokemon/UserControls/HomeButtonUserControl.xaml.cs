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
    public sealed partial class HomeButtonUserControl : BaseUserControl
    {
        private String homeButtonText;

        public string HomeButtonText
        {
            get { return homeButtonText; }
            set
            {
                homeButtonText = value;
                base.OnPropertyChanged("Home Button Text");
            }
        }

        public HomeButtonUserControl()
        {
            this.InitializeComponent();
            base.DataContext = this;
        }
    }
}