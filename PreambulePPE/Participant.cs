using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreambulePPE
{
    class Participant
    {
        private string nom;
        private string prenom;
        private string departement;
        private string email;
        private int idSalon;
        private string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
        public Participant(string nom, string prenom, string departement, string email,int unSalon)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.departement = departement;
            this.email = email;
            this.idSalon = unSalon;
        }

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                nom = value;
            }
        }
        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                prenom = value;
            }
        }
        public string Departement
        {
            get
            {
                return departement;
            }
            set
            {
                departement = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public int IdSalon
        {
            get
            {
                return idSalon;
            }
            set
            {
                idSalon = value;
            }
        }
        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            string sql = "INSERT INTO `participant` (idSalon,nom, prenom, Departement, Email) " +
                "VALUES ('" + idSalon + "', '" + nom + "','" + prenom + "','" + departement + "','"+email+"');";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            conn.Close();
        }
    }
}
