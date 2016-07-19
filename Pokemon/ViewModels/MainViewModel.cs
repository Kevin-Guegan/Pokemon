using ClassLibraryPokemon;
using Pokemon.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.Generic;
using Pokemon.API;
using System.Linq;

namespace Pokemon.ViewModels
{
    public class MainViewModel
    {
        private int indexListe;

        private List<TypeDePokemons> typeDePokemons = new List<TypeDePokemons>();
        private TypeDePokemons typeDePokemon = new TypeDePokemons();

        private MainView mainView;

        public MainView MainView
        {
            get { return mainView; }
            set { mainView = value; }
        }

        private ApiManager apiManager;

        public ApiManager ApiManager
        {
            get { return apiManager; }
            set { apiManager = value; }
        }

        public MainViewModel(MainView mainView)
        {
            this.MainView = mainView;
            this.ApiManager = apiManager;
            this.Init();
        }

        public async void Init()
        {
            indexListe = 1;

            ApiManager apiManager = new ApiManager();
            typeDePokemon = await apiManager.GetFromApi<TypeDePokemons>(indexListe);
            if (typeDePokemon != null)
            {
                typeDePokemons.Add(new TypeDePokemons(typeDePokemon));
            }

            this.MainView.PokemonList.Text = typeDePokemon.nom;
            //this.MainView.ImageList.Source = pokemon.ImgPokedex;

            this.MainView.PokedexButton.HomeButtonText = "Pokemon";
            this.Bind();
        }

        public async void SearchPokemon(int index)
        {
            try
            {
                typeDePokemon = typeDePokemons.ElementAt(index);
            }
            catch (System.Exception)
            {

                ApiManager apiManager = new ApiManager();
                typeDePokemon = await apiManager.GetFromApi<TypeDePokemons>(index);
                if (typeDePokemon != null)
                {
                    typeDePokemons.Add(new TypeDePokemons(typeDePokemon));
                }
            }

            
        }

        public void Bind()
        {
            this.MainView.PokedexButton.Tapped += PokedexButton_Tapped;
            this.MainView.CombatButton.Tapped += CombatButton_Tapped;
            this.MainView.ConcoursButton.Tapped += ConcoursButton_Tapped;
            this.MainView.PromenadeButton.Tapped += PromenadeButton_Tapped;
            this.MainView.ExitButton.Tapped += ExitButton_Tapped;

            this.MainView.ImageNavLeft.Tapped += ImageNavLeft_Tapped;
            this.MainView.ImageNavRight.Tapped += ImageNavRight_Tapped;
        }

        private void ExitButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void ImageNavRight_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indexListe++;
            SearchPokemon(indexListe);
            this.MainView.PokemonList.Text = typeDePokemon.nom;
            /*var pokemon = ClassLibraryPokemon.Pokemon.GetPokemonById(indexListe);
            if (pokemon != null)
            {
                this.MainView.ImageList.Source = pokemon.ImgPokedex;
            }
            else
            {
                indexListe--;
            }*/
        }

        private void ImageNavLeft_Tapped(object sender, TappedRoutedEventArgs e)
        {
            indexListe--;
            SearchPokemon(indexListe);
            this.MainView.PokemonList.Text = typeDePokemon.nom;
            /*var pokemon = ClassLibraryPokemon.Pokemon.GetPokemonById(indexListe);
            if (pokemon != null)
            {
                this.MainView.ImageList.Source = pokemon.ImgPokedex;
            }
            else
            {
                indexListe++;
            }*/
        }

        private void PromenadeButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(PromenadeView));
        }

        private void ConcoursButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(ConcoursView));
        }

        private void CombatButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(CombatView));
        }

        private void PokedexButton_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            (Window.Current.Content as Frame).Navigate(typeof(PokedexView));
        }
    }
}