using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PreambulePPE
{
    class User
    {
        private string login;
        private string nom;
        private string prenom;
        private string pwd;
        private int admin;
        private int id;
        private string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";

        public User(string unLogin, string unNom, string unPrenom, string unPwd, int unAdmin)
        {
            login = unLogin;
            nom = unNom;
            prenom = unPrenom;
            pwd = unPwd;
            admin = unAdmin;
        }
        public User(int idCurrent, string unLogin, string unNom, string unPrenom, string unPwd, int unAdmin)
        {
            id = idCurrent;
            login = unLogin;
            nom = unNom;
            prenom = unPrenom;
            pwd = unPwd;
            admin = unAdmin;
        }

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
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

        public string Pwd
        {
            get
            {
                return pwd;
            }
            set
            {
                pwd = value;
            }
        }

        public int Admin
        {
            get
            {
                return admin;
            }
            set
            {
                admin = value;
            }
        }

        public void Save()
        {
            string sqlModif;
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            string sqlVerif = "Select * from user where id = '"+id+"';";
            MySqlCommand cmdVerif = new MySqlCommand(sqlVerif, conn);
            MySqlDataReader rdrVerif = cmdVerif.ExecuteReader();
            rdrVerif.Read();
            if (rdrVerif.HasRows)
            {
                rdrVerif.Close();
                if (pwd != "")
                {
                    sqlModif = "Update user SET login = '" + login + "', nom = '" + nom + "', prenom = '" + prenom + "', pwd = '" + SHA.petitsha(pwd) +
                  "', adm = '" + admin + "' where id = '" + id + "';";
                }
                else
                {
                    sqlModif = "Update user SET login = '" + login + "', nom = '" + nom + "', prenom = '" + prenom + "', adm = '" + admin + "' where id = '" + id + "';";
                }
                MySqlCommand cmdModif = new MySqlCommand(sqlModif, conn);
                cmdModif.ExecuteNonQuery();
            }
            else
            {
                rdrVerif.Close();
                string sql = "INSERT INTO `user` (`login`,nom,prenom, pwd, `adm`) VALUES ('" + login + "', '" + nom + "','" + prenom + "','" + SHA.petitsha(pwd) + "', '" + admin + "');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Close();
            }
            conn.Close();
        }

        public void Delete()
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            string sqlDel = "DELETE FROM user WHERE id = '" + id + "';";
            MySqlCommand cmdDel = new MySqlCommand(sqlDel, conn);
            MySqlDataReader rdrDel = cmdDel.ExecuteReader();
            rdrDel.Read();
        }



        //40BD001563085FC35165329EA1FF5C5ECBDBBEEF
    }
}
