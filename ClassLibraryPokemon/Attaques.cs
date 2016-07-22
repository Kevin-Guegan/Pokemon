using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace ClassLibraryPokemon
{
    public class Attaques : EntityBase
    {
        private Attaques attaque;

        public Attaques(Attaques attaque)
        {
            this.attaque = attaque;
        }

        public Attaques()
        {
        }

        private int id;
        private string nom;
        private int puissance;
        private int precis;
        private Type type;

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

        [Column("puissance")]
        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }

        [Column("precis")]
        public int Precis
        {
            get { return precis; }
            set { precis = value; }
        }
    }
}
