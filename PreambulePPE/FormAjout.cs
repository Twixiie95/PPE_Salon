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
    public partial class FormAjout : Form
    {
        string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
        int adm = 1;
        public FormAjout()
        {
            InitializeComponent();
        }

        private void bt_ajout_Click(object sender, EventArgs e)
        {
            try
            {
                /*MySqlConnection conn = new MySqlConnection(_connectionString);
                conn.Open();
                string sql = "INSERT INTO `user` (`login`,nom,prenom, pwd, `adm`) VALUES ('" + tb_log.Text + "', '"+TB_Nom.Text+"','"+TB_Prenom.Text+"','" + SHA.petitsha(tb_pwd.Text) + "', '" + adm + "');";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                conn.Close();*/
                User unUser = new User(tb_log.Text, TB_Nom.Text, TB_Prenom.Text, tb_pwd.Text, adm);
                unUser.Save();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            this.DialogResult = DialogResult.OK;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            adm = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            adm = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            adm = 3;
        }
    }
}
