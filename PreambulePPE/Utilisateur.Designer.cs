namespace PreambulePPE
{
    partial class Utilisateur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_salon = new System.Windows.Forms.ComboBox();
            this.bt_ajout = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_departement = new System.Windows.Forms.TextBox();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BT_recherche = new System.Windows.Forms.Button();
            this.cb_salonPDF = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.cb_salon);
            this.panel1.Controls.Add(this.bt_ajout);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_departement);
            this.panel1.Controls.Add(this.tb_prenom);
            this.panel1.Controls.Add(this.tb_nom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(37, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 363);
            this.panel1.TabIndex = 0;
            // 
            // cb_salon
            // 
            this.cb_salon.FormattingEnabled = true;
            this.cb_salon.Location = new System.Drawing.Point(61, 209);
            this.cb_salon.Name = "cb_salon";
            this.cb_salon.Size = new System.Drawing.Size(121, 21);
            this.cb_salon.TabIndex = 11;
            // 
            // bt_ajout
            // 
            this.bt_ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajout.ForeColor = System.Drawing.Color.Black;
            this.bt_ajout.Location = new System.Drawing.Point(82, 308);
            this.bt_ajout.Name = "bt_ajout";
            this.bt_ajout.Size = new System.Drawing.Size(75, 23);
            this.bt_ajout.TabIndex = 10;
            this.bt_ajout.Text = "Ajouter";
            this.bt_ajout.UseVisualStyleBackColor = true;
            this.bt_ajout.Click += new System.EventHandler(this.bt_ajout_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(140, 142);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(100, 20);
            this.tb_email.TabIndex = 9;
            // 
            // tb_departement
            // 
            this.tb_departement.Location = new System.Drawing.Point(12, 142);
            this.tb_departement.Name = "tb_departement";
            this.tb_departement.Size = new System.Drawing.Size(100, 20);
            this.tb_departement.TabIndex = 8;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(140, 80);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 20);
            this.tb_prenom.TabIndex = 7;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(12, 80);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Département";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un participant";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.cb_salonPDF);
            this.panel2.Controls.Add(this.BT_recherche);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(459, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 366);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Générer un PDF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(93, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Salon";
            // 
            // BT_recherche
            // 
            this.BT_recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_recherche.ForeColor = System.Drawing.Color.Black;
            this.BT_recherche.Location = new System.Drawing.Point(77, 160);
            this.BT_recherche.Name = "BT_recherche";
            this.BT_recherche.Size = new System.Drawing.Size(77, 23);
            this.BT_recherche.TabIndex = 12;
            this.BT_recherche.Text = "Chercher";
            this.BT_recherche.UseVisualStyleBackColor = true;
            this.BT_recherche.Click += new System.EventHandler(this.BT_recherche_Click);
            // 
            // cb_salonPDF
            // 
            this.cb_salonPDF.FormattingEnabled = true;
            this.cb_salonPDF.Location = new System.Drawing.Point(56, 118);
            this.cb_salonPDF.Name = "cb_salonPDF";
            this.cb_salonPDF.Size = new System.Drawing.Size(121, 21);
            this.cb_salonPDF.TabIndex = 13;
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Utilisateur";
            this.Text = "Opérateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_salon;
        private System.Windows.Forms.Button bt_ajout;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_departement;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_recherche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_salonPDF;
    }
}