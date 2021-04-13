
namespace PreambulePPE
{
    partial class PDFGenerer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_mail = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_pdf = new System.Windows.Forms.Button();
            this.bt_retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_mail
            // 
            this.cb_mail.FormattingEnabled = true;
            this.cb_mail.Location = new System.Drawing.Point(303, 156);
            this.cb_mail.Name = "cb_mail";
            this.cb_mail.Size = new System.Drawing.Size(121, 21);
            this.cb_mail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // bt_pdf
            // 
            this.bt_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pdf.Location = new System.Drawing.Point(269, 244);
            this.bt_pdf.Name = "bt_pdf";
            this.bt_pdf.Size = new System.Drawing.Size(75, 23);
            this.bt_pdf.TabIndex = 2;
            this.bt_pdf.Text = "Générer";
            this.bt_pdf.UseVisualStyleBackColor = true;
            this.bt_pdf.Click += new System.EventHandler(this.bt_pdf_Click);
            // 
            // bt_retour
            // 
            this.bt_retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_retour.Location = new System.Drawing.Point(377, 244);
            this.bt_retour.Name = "bt_retour";
            this.bt_retour.Size = new System.Drawing.Size(75, 23);
            this.bt_retour.TabIndex = 3;
            this.bt_retour.Text = "Retour";
            this.bt_retour.UseVisualStyleBackColor = true;
            this.bt_retour.Click += new System.EventHandler(this.bt_retour_Click);
            // 
            // PDFGenerer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_retour);
            this.Controls.Add(this.bt_pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_mail);
            this.Name = "PDFGenerer";
            this.Text = "PDFGenerer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_mail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_pdf;
        private System.Windows.Forms.Button bt_retour;
    }
}