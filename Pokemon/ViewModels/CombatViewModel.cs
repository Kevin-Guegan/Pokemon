using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPokemon;
using Pokemon.Views;

namespace Pokemon.ViewModels
{
    public class CombatViewModel
    {
        private CombatView combatView;

        public CombatView CombatView
        {
            get { return combatView; }
            set { combatView = value; }
        }

    }
}
