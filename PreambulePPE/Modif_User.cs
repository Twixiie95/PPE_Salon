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
    public partial class Modif_User : Form
    {
        int adm;
        string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
       
        public Modif_User()
        {
            InitializeComponent();
            TB_log.Text = Admin.login;
            TB_nom.Text = Admin.nom;
            TB_prenom.Text = Admin.prenom;
            
            if (Admin.admin == "2")
            {
                radioButton2.Checked = true;
            }
            if (Admin.admin == "3")
            {
                radioButton3.Checked = true;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (TB_pwd.Text != "")
            {
                User unUser = new User(int.Parse(Admin.idCurrent), TB_log.Text, TB_nom.Text, TB_prenom.Text, TB_pwd.Text, adm);
                unUser.Save();
            }
            else
            {
                User unUser = new User(int.Parse(Admin.idCurrent), TB_log.Text, TB_nom.Text, TB_prenom.Text, TB_pwd.Text, adm);
                unUser.Save();
            }
            
            this.DialogResult = DialogResult.OK;
        }

        private void Bt_Del_Click(object sender, EventArgs e)
        {
            User unUser = new User(int.Parse(Admin.idCurrent), TB_log.Text, TB_nom.Text, TB_prenom.Text, TB_pwd.Text, adm);
            unUser.Delete();
            this.DialogResult = DialogResult.OK;
        }
    }
}
