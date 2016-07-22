using SQLite.Net.Attributes;
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
        private TypeDePokemons typePokemon;
        private Attaques attaque1;
        private Attaques attaque2;
        private Attaques attaque3;
        private Attaques attaque4;

        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Column("surnom")]
        public string Surnom
        {
            get { return surnom; }
            set { surnom = value; }
        }

        [Column("niveau")]
        public int Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }

        [Column("capture")]
        public string Capture
        {
            get { return capture; }
            set { capture = value; }
        }
    }
}
