using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPokemon
{
    public class Dresseurs : EntityBase
    {
        private Dresseurs dresseur;

        public Dresseurs(Dresseurs dresseur)
        {
            this.dresseur = dresseur;
        }

        public Dresseurs()
        {
        }

        private int id;
        private string nom;
        private string login;
        private string password;
        private List<Npcs> npc;

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

        [Column("login")]
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        [Column("password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
