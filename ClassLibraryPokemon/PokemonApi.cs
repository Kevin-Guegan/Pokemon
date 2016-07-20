using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPokemon
{
    public class Pokemons : EntityBase
    {

        private Pokemons pokemon;

        public Pokemons(Pokemons pokemon)
        {
            this.pokemon = pokemon;
        }

        public Pokemons()
        {
        }

        private int id;
        private string surnom;
        private int niveau;
        private string capture;
        private int dresseursId;
        private int attaquesId_1;
        private int attaquesId_2;
        private int attaquesId_3;
        private int attaquesId_4;
    }
}
