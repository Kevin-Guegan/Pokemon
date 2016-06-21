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

        public PromenadeView PromenadeView
        {
            get { return promenameView; }
            set { promenameView = value; }
        }

        public PromenadeViewModel(PromenadeView promenameView)
        {
            this.PromenadeView = this.promenameView;
            this.Init();
        }

        public void Init()
        {

        }
    }
}
