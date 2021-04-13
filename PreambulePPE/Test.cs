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
using System.Net;

namespace PreambulePPE
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();



            document.Info.Title = "Dylan 1 PDF";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Code 128", 60, XFontStyle.Regular);
            XFont font2 = new XFont("LEMONMILK-Bold", 60, XFontStyle.Regular);
            gfx.DrawString("informations de l'utilisateur", font, XBrushes.Black,
            new XRect(0, 0, page.Width, page.Height),
            XStringFormats.Center);
            gfx.DrawString("Bonjour",font2, XBrushes.Black,
            new XRect(0, -150, page.Width, page.Height),
            XStringFormats.Center);
            const string filename = "BadgeUtilisateur.pdf";
            document.Save(filename);
            Process.Start(filename);
        }
    }
}
