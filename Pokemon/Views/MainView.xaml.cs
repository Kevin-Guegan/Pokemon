using ClassLibraryPokemon;
using Pokemon.UserControls;
using Pokemon.ViewModels;
using Pokemon.Views;
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
using Microsoft.Azure.Engagement;
using Newtonsoft.Json;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Pokemon.Views
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        private MainViewModel mainViewModel;

        public HomeButtonUserControl PokedexButton { get; set; }
        public HomeButtonUserControl CombatButton { get; set; }
        public HomeButtonUserControl ConcoursButton { get; set; }
        public HomeButtonUserControl PromenadeButton { get; set; }
        public Button ExitButton { get; set; }

        public Image ImageNavLeft { get; set; }
        public Image ImageNavRight { get; set; }
        public Image ImageList { get; set; }

        public TextBlock PokemonList { get; set; }

        public MainView()
        {
            this.InitializeComponent();

            this.PokedexButton = this.pokedexButton;
            this.CombatButton = this.combatButton;
            this.ConcoursButton = this.concoursButton;
            this.PromenadeButton = this.promenadeButton;
            this.ExitButton = this.exitButton;

            this.ImageNavLeft = this.imageNavLeft;
            this.ImageNavRight = this.imageNavRight;
            this.ImageList = this.imageList;

            this.PokemonList = this.pokemonList;

            this.mainViewModel = new MainViewModel(this);
        }
        
        private void Engagement()
        {
            String deviceId = EngagementAgent.Instance.GetDeviceId();
            EngagementReach.Instance.DataPushStringReceived += Instance_DataPushStringReceived;
        }

        private bool Instance_DataPushStringReceived(string arg)
        {
            var item = JsonConvert.DeserializeObject(arg);
            return true;
        }
    }
}
