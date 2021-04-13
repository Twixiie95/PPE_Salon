using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreambulePPE
{
    public partial class PDFGenerer : Form
    {
        string _connectionString = "server=localhost;user id=root;database=ppe_csharp;";
        int idSalon = Utilisateur.idSalon;
        public PDFGenerer()
        {


            InitializeComponent();
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("select Email from participant where idSalon = '"+idSalon+"'", conn);
            MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds, "participant");
            cb_mail.DataSource = ds.Tables[0];
            cb_mail.DisplayMember = "Email";
        }

        private void bt_retour_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bt_pdf_Click(object sender, EventArgs e)
        {

            MySqlDataAdapter donnee = new MySqlDataAdapter();
            MySqlConnection conn = new MySqlConnection(_connectionString);
            conn.Open();
            string sql = "select * from participant where Email = '" + cb_mail.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            string prenom = rdr.GetString(3);
            string nom = rdr.GetString(2);
            string departement = rdr.GetString(4);
            PdfDocument document = new PdfDocument();
            document.Info.Title = prenom+cb_mail.Text;
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Code 128", 60, XFontStyle.Regular);
            XFont font2 = new XFont("LEMONMILK-Bold", 60, XFontStyle.Regular);
            gfx.DrawString(cb_mail.Text, font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);
            gfx.DrawString(nom + " " + prenom, font2, XBrushes.Black,
            new XRect(0, -350, page.Width, page.Height),
            XStringFormats.Center);
            gfx.DrawString(departement, font2, XBrushes.Black,
            new XRect(0, -150, page.Width, page.Height),
            XStringFormats.Center);
            const string filename = "BadgeUtilisateur.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}
