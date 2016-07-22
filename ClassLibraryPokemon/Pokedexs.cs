using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPokemon
{
    public class Pokedexs : EntityBase
    {
        private Pokedexs pokedex;

        public Pokedexs(Pokedexs pokedex)
        {
            this.pokedex = pokedex;
        }

        public Pokedexs()
        {
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
