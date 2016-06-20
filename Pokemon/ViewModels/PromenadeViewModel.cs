using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPokemon;
using Pokemon.Views;

namespace Pokemon.ViewModels
{
    public class PromenadeViewModel
    {
        private PromenadeView promenameView;

        public PromenadeView PromenameView
        {
            get { return promenameView; }
            set { promenameView = value; }
        }

    }
}
