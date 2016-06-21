using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPokemon;
using Pokemon.Views;

namespace Pokemon.ViewModels
{
    public class PokedexViewModel
    {
        private PokedexView pokedexView;

        public PokedexView PokedexView
        {
            get { return pokedexView; }
            set { pokedexView = value; }
        }

        public PokedexViewModel(PokedexView PokedexView)
        {
            this.PokedexView = this.PokedexView;
            this.Init();
        }

        public void Init()
        {

        }
    }
}
