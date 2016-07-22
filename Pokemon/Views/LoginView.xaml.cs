using Pokemon.UserControls;
using Pokemon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Pokemon.Views
{
    public sealed partial class LoginView : Page
    {
        private LoginViewModel loginViewModel;

        public TextBox LoginTextBox { get; set; }
        public PasswordBox PasswordTextBox { get; set; }
        
        public HomeButtonUserControl ConnexionButton { get; set; }

        public LoginView()
        {
            this.InitializeComponent();

            this.LoginTextBox = this.loginTextBox;
            this.PasswordTextBox = this.passwordTextBox;

            this.ConnexionButton = this.connexionButton;

            this.loginViewModel = new LoginViewModel(this);
        }
    }
}
