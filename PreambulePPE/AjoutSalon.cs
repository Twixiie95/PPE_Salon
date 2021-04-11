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
    public partial class AjoutSalon : Form
    {
        public AjoutSalon()
        {
            InitializeComponent();
        }

        private void BT_Ajout_Click(object sender, EventArgs e)
        {
            
            try
            {
                Salon unSalon = new Salon(TB_Nom.Text, TB_Lieu.Text,DTP_debut.Value, DTP_Fin.Value);
                unSalon.Save();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
