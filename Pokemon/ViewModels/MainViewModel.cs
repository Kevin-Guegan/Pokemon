using ClassLibraryPokemon;
using Pokemon.Views;

namespace Pokemon.ViewModels
{
    internal class MainViewModel
    {
        private MainView mainView;

        public MainView MainView
        {
            get { return mainView; }
            set { mainView = value; }
        }

        public MainViewModel(MainView mainView)
        {
            this.MainView = this.mainView;
            this.Init();
        }

        public void Init()
        {

        }
    }
}