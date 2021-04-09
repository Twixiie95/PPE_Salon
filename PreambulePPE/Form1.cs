using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace PreambulePPE
{
    public partial class Login : Form
    {
        public static string id;
        public static string login;
        public static string idco;
        int echec = 0;
        string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            DateTime date = DateTime.Today;
            DateTime hour = DateTime.Now;
            try
            {
                conn.Open();
                
                string sql = "SELECT * FROM user where login = '" + tb_log.Text + "' and pwd = '" +
                   SHA.petitsha(tb_pwd.Text) 
                   + "';";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                if (rdr.HasRows)
                {
                    id = rdr[5].ToString();
                    login = rdr[1].ToString();  
                    string heureCo = hour.ToString("t");
                    string sql2 = "INSERT INTO connexion (login,heureDebut,Date,nom,prenom) VALUES ('" + login + "','" + heureCo + "','" + date.ToString("d") + "','" + rdr[2].ToString() + "','" + rdr[1].ToString() + "');";
                    rdr.Close();
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    rdr2.Close();
                    string sql3 = "SELECT id from connexion where heureDebut = '" + heureCo + "';";
                    MySqlCommand cmd3 = new MySqlCommand(sql3, conn);
                    MySqlDataReader rdr3 = cmd3.ExecuteReader();
                    rdr3.Read();
                    idco = rdr3[0].ToString();
                    rdr3.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else if(echec < 2)
                {
                    MessageBox.Show("Login ou mot de passe incorrect !");
                    echec++;
                    rdr.Close();
                }
                else
                {                    
                    rdr.Close();
                    
                    string erreurCo = hour.ToString("t");
                    string sql2 = "insert into erreurco (login,date) values ('" + tb_log.Text + "','" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "');";
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    MySqlDataReader rdr2 = cmd2.ExecuteReader();
                    this.DialogResult = DialogResult.Cancel;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Login_Load(object sender, EventArgs e)
        {


        }
    }
}