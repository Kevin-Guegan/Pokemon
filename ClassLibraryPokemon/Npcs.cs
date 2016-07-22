using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPokemon
{
    public class Npcs : EntityBase
    {
        private Npcs npc;

        public Npcs(Npcs npc)
        {
            this.npc = npc;
        }

        public Npcs()
        {
        }

        private int id;
        private string nom;
        private string profession;
        private string texte;
        private List<Pokemons> pokemon;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }

        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }

    }
}
