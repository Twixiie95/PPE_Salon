
namespace PreambulePPE
{
    partial class AjoutSalon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Lieu = new System.Windows.Forms.TextBox();
            this.BT_Ajout = new System.Windows.Forms.Button();
            this.DTP_debut = new System.Windows.Forms.DateTimePicker();
            this.DTP_Fin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout d\'un salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lieu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de début";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date de fin";
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(303, 129);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(150, 20);
            this.TB_Nom.TabIndex = 5;
            // 
            // TB_Lieu
            // 
            this.TB_Lieu.Location = new System.Drawing.Point(303, 185);
            this.TB_Lieu.Name = "TB_Lieu";
            this.TB_Lieu.Size = new System.Drawing.Size(150, 20);
            this.TB_Lieu.TabIndex = 6;
            // 
            // BT_Ajout
            // 
            this.BT_Ajout.ForeColor = System.Drawing.Color.Black;
            this.BT_Ajout.Location = new System.Drawing.Point(313, 382);
            this.BT_Ajout.Name = "BT_Ajout";
            this.BT_Ajout.Size = new System.Drawing.Size(140, 23);
            this.BT_Ajout.TabIndex = 9;
            this.BT_Ajout.Text = "Ajouter";
            this.BT_Ajout.UseVisualStyleBackColor = true;
            this.BT_Ajout.Click += new System.EventHandler(this.BT_Ajout_Click);
            // 
            // DTP_debut
            // 
            this.DTP_debut.Location = new System.Drawing.Point(277, 254);
            this.DTP_debut.Name = "DTP_debut";
            this.DTP_debut.Size = new System.Drawing.Size(200, 20);
            this.DTP_debut.TabIndex = 10;
            // 
            // DTP_Fin
            // 
            this.DTP_Fin.Location = new System.Drawing.Point(277, 315);
            this.DTP_Fin.Name = "DTP_Fin";
            this.DTP_Fin.Size = new System.Drawing.Size(200, 20);
            this.DTP_Fin.TabIndex = 11;
            // 
            // AjoutSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DTP_Fin);
            this.Controls.Add(this.DTP_debut);
            this.Controls.Add(this.BT_Ajout);
            this.Controls.Add(this.TB_Lieu);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AjoutSalon";
            this.Text = "AjoutSalon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Lieu;
        private System.Windows.Forms.Button BT_Ajout;
        private System.Windows.Forms.DateTimePicker DTP_debut;
        private System.Windows.Forms.DateTimePicker DTP_Fin;
    }
}