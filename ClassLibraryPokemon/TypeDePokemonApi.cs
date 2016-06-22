using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPokemon
{
    public class TypeDePokemons
    {
        private TypeDePokemons typeDePokemon;

        public TypeDePokemons(TypeDePokemons typeDePokemon)
        {
            this.typeDePokemon = typeDePokemon;
        }

        public TypeDePokemons()
        {
        }

        public string nom { get; set; }
        public int attaque { get; set; }
        public int attaque_spe { get; set; }
        public int defence { get; set; }
        public int defence_spe { get; set; }
        public int vitesse { get; set; }
        public int pv { get; set; }
        public int id_pokedex { get; set; }
        public int id { get; set; }
        //public List<object> typesid { get; set; }
        //public List<object> zonesid { get; set; }
    }

    public class Trololo
    {
        //public Pokemon pokemon { get; set; }
    }

        /*public class TypeDePokemons
        {
            public List<TypeDePokemon> typeDePokemon { get; set; }
        }*/
}
