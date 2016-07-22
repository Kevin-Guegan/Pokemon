using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace ClassLibraryPokemon
{
    public class TypeDePokemons : EntityBase
    {
        private TypeDePokemons typeDePokemon;

        public TypeDePokemons(TypeDePokemons typeDePokemon)
        {
            this.typeDePokemon = typeDePokemon;
        }

        public TypeDePokemons()
        {
        }
        
        private int id;
        private string nom;
        private int attaque;
        private int attaque_spe;
        private int defence;
        private int defence_spe;
        private int vitesse;
        private int pv;
        private Types type;
        private List<TypeDePokemons> typePokemon;
        private Pokedexs pokedex;

 
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Column("nom")]
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        [Column("attaque")]
        public int Attaque
        {
            get { return attaque; }
            set { attaque = value; }
        }

        [Column("attaque_spe")]
        public int AttaqueSpe
        {
            get { return attaque_spe; }
            set { attaque_spe = value; }
        }

        [Column("defence")]
        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }

        [Column("defence_spe")]
        public int DefenceSpe
        {
            get { return defence_spe; }
            set { defence_spe = value; }
        }

        [Column("vitesse")]
        public int Vitesse
        {
            get { return vitesse; }
            set { vitesse = value; }
        }

        [Column("pv")]
        public int Pv
        {
            get { return pv; }
            set { pv = value; }
        }


        public override string ToString()
        {
            return this.Id.ToString();
        }
    }
}
