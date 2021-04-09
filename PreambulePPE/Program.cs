using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace PreambulePPE
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
            MySqlConnection conn = new MySqlConnection(_connectionString);
            DateTime hour = DateTime.Now;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login MonFormLogin = new Login();
            MonFormLogin.ShowDialog();
            //Test test = new Test();
            //test.ShowDialog();
            if (MonFormLogin.DialogResult == DialogResult.OK)
            {
                MonFormLogin.Close();
                if(Login.id == "3")
                {
                    Application.Run(new Admin());
                }
                else if (Login.id == "2")
                {
                    Application.Run(new Utilisateur());
                }
                else
                {
                    Application.Run(new Invite());
                }
            }
            else
                MonFormLogin.Close();
            conn.Open();
            string sql = "Update connexion set heureFin = '" + hour.ToString("t") + "' where id = '" + Login.idco + "';";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            
            MessageBox.Show("Au revoir");
        }        
    }
}
