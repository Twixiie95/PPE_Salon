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

namespace PreambulePPE
{
    public partial class Utilisateur : Form
    {

        string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
        public static int idSalon;
        public Utilisateur()
        {
            
            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("select nom from salon",conn);
            MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds,"salon");
            cb_salon.DataSource = ds.Tables[0];
            cb_salon.DisplayMember = "nom";
            cb_salonPDF.DataSource = ds.Tables[0];
            cb_salonPDF.DisplayMember = "nom";
        }

        private void bt_ajout_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            string sql = "select id from salon where Nom = '" + cb_salon.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            
            Participant unParticipant = new Participant(tb_nom.Text, tb_prenom.Text, tb_departement.Text, tb_email.Text, rdr.GetInt32(0));
            unParticipant.Save();
            rdr.Close();
            conn.Close();
            MessageBox.Show("Participant ajouté !");
            tb_nom.Text = "";
            tb_email.Text = "";
            tb_departement.Text = "";
            tb_prenom.Text = "";
        }

        private void BT_recherche_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            string sql = "select id from salon where Nom = '" + cb_salon.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            idSalon = rdr.GetInt32(0);
            rdr.Close();
            conn.Close();
            PDFGenerer unPDF = new PDFGenerer();
            this.Hide();
            unPDF.ShowDialog();
            this.Show();
        }
    }
}
