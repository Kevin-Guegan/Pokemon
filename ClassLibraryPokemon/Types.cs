using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPokemon
{
    public class Types : EntityBase
    {
        private Types type;

        public Types(Types type)
        {
            this.type = type;
        }

        public Types()
        {
        }

        private int id;
        private List<TypeDePokemons> typeDePokemon;
        private List<Attaques> attaque;
    }
}
