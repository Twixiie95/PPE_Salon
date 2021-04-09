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
using System.Data.SqlClient;
using System.Timers;

namespace PreambulePPE
{
    public partial class Admin : Form
    {
        string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
        public static string login;
        public static string nom;
        public static string prenom;
        public static string pwd;
        public static string admin;
        public static string idCurrent;
        public void Refreshdgv()
        {
            MySqlDataAdapter donnee = new MySqlDataAdapter();
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            DateTime date = DateTime.Today;
            DateTime hour = DateTime.Now;
            string sql = "SELECT nom,prenom,heureDebut,heureFin,Date FROM connexion where date ='" + date.ToString("d") + "'";
            MySqlCommand cmd2 = new MySqlCommand(sql, conn);
            donnee.SelectCommand = cmd2;
            DataSet dataset = new DataSet();
            donnee.Fill(dataset);
            DGV_jour.DataSource = dataset.Tables[0];
            string sql2 = "SELECT * FROM erreurco where date between '" + DateTime.Now.AddDays(-3).ToString("yyyy/MM/dd HH:mm:ss") + "' and '" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "';";
            MySqlCommand cmd3 = new MySqlCommand(sql2, conn);
            donnee.SelectCommand = cmd3;
            DataSet dataset2 = new DataSet();
            donnee.Fill(dataset2);
            DGV_erreurCo.DataSource = dataset2.Tables[0];
            string sql3 = "SELECT * FROM user;";
            MySqlCommand cmd4 = new MySqlCommand(sql3, conn);
            donnee.SelectCommand = cmd4;
            DataSet dataset3 = new DataSet();
            donnee.Fill(dataset3);
            DGV_User.DataSource = dataset3.Tables[0];
            conn.Close();
        }
        public Admin()
        {
           
            InitializeComponent();
            Refreshdgv();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormAjout monFormAjout = new FormAjout();
            this.Hide();
            monFormAjout.ShowDialog();
            if (monFormAjout.DialogResult == DialogResult.OK)
            {
                Refreshdgv();
            }
            this.Show();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void DGV_User_DoubleClick(object sender, EventArgs e)
        {
            idCurrent = DGV_User.CurrentRow.Cells["id"].Value.ToString();
            login = DGV_User.CurrentRow.Cells["login"].Value.ToString();
            nom = DGV_User.CurrentRow.Cells["nom"].Value.ToString();
            prenom = DGV_User.CurrentRow.Cells["prenom"].Value.ToString();
            pwd = DGV_User.CurrentRow.Cells["pwd"].Value.ToString();
            admin = DGV_User.CurrentRow.Cells["adm"].Value.ToString();
            Modif_User MaModif_User = new Modif_User();
            this.Hide();
            MaModif_User.ShowDialog();
            if(MaModif_User.DialogResult == DialogResult.OK)
            {
                Refreshdgv();
            }
            this.Show();
        }

        private void BT_Date_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter donneejour = new MySqlDataAdapter();
            MySqlConnection conn = new MySqlConnection(_connectionString);
            string sqljour = "SELECT nom,prenom,heureDebut,heureFin,Date FROM connexion where date ='" + DTP_date.Value.ToString("d") + "'";
            conn.Open();
            MySqlCommand cmdjour = new MySqlCommand(sqljour, conn);
            donneejour.SelectCommand = cmdjour;
            DataSet datasetjour = new DataSet();
            donneejour.Fill(datasetjour);
            DGV_jour.DataSource = datasetjour.Tables[0];
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AjoutSalon FormSalon = new AjoutSalon();
            FormSalon.ShowDialog();
        }

        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            Refreshdgv();
        }
    }
}
