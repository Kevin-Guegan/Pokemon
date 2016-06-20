using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPokemon;
using Pokemon.Views;
using Pokemon.UserControls;

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

        public CombatViewModel(CombatView combatView)
        {
            this.CombatView = this.combatView;
            this.Init();
        }

        public void Init()
        {

        }
    }
}
