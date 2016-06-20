using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPokemon;
using Pokemon.Views;

namespace Pokemon.ViewModels
{
    public class ConcoursViewModel
    {
        private ConcoursView concoursView;

        public ConcoursView ConcoursView
        {
            get { return concoursView; }
            set { concoursView = value; }
        }

        public ConcoursViewModel(ConcoursView ConcoursView)
        {
            this.ConcoursView = this.ConcoursView;
            this.Init();
        }

        public void Init()
        {

        }
    }
}
