using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreambulePPE
{
    class Salon
    {
        private string nom;
        private string lieu;
        private DateTime dateDeb;
        private DateTime dateFin;
        private string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
        
        public Salon(string unNom, string unLieu,DateTime uneDateDeb,DateTime uneDateFin)
        {
            nom = unNom;
            lieu = unLieu;
            dateDeb = uneDateDeb;
            dateFin = uneDateFin;
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
        public string Lieu
        {
            get
            {
                return lieu;
            }
            set
            {
                lieu = value;
            }
        }
        public DateTime DateDeb
        {
            get
            {
                return dateDeb;
            }
            set
            {
                dateDeb = value;
            }
        }
        public DateTime DateFin
        {
            get
            {
                return dateFin;
            }
            set
            {
                dateFin = value;
            }
        }
        public void Save()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            string sql = "INSERT INTO `salon` (Nom,Lieu, DateDeb, DateFin) VALUES ('" + nom + "', '" + lieu + "','" + dateDeb.ToString("yyyy/MM/dd") + "','" + dateFin.ToString("yyyy/MM/dd") + "');";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            conn.Close();
        }
    }
}
