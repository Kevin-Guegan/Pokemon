using ClassLibraryPokemon;
using Pokemon.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using System.Collections.Generic;
using Pokemon.API;

namespace Pokemon.ViewModels
{
    public class LoginViewModel
    {
        private LoginView loginView;
        private ApiManager apiManager;

        public ApiManager ApiManager
        {
            get { return apiManager; }
            set { apiManager = value; }
        }

        public LoginView LoginView
        {
            get { return loginView; }
            set { loginView = value; }
        }

        public LoginViewModel(LoginView loginView)
        {
            this.LoginView = loginView;
            this.ApiManager = apiManager;
            this.Init();
        }

        public void Init()
        {
            // regarder si user enregistre dans bdd locale
            int test = 1;
            if (test == 1)
            {
                (Window.Current.Content as Frame).Navigate(typeof(MainView));
            }
            this.Bind();
        }

        public void Bind()
        {
            this.LoginView.ConnexionButton.Tapped += ConnexionButton_Tapped;
        }

        private void ConnexionButton_Tapped(object sender, TappedRoutedEventArgs e)
        {
            // verification des infos de connexions depuis l'api
            if (this.LoginView.LoginTextBox.Text == "test" && this.LoginView.PasswordTextBox.Password == "test")
            {
                (Window.Current.Content as Frame).Navigate(typeof(MainView));
            }
            else
            {
                
            } 
        }
    }
}
