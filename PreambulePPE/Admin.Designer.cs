namespace PreambulePPE
{
    partial class Admin
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
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_jour = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_erreurCo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BT_Date = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP_date = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Utilisateur = new System.Windows.Forms.TabPage();
            this.DGV_User = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_jour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_erreurCo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Utilisateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(220, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Connexions du jour";
            // 
            // DGV_jour
            // 
            this.DGV_jour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_jour.Location = new System.Drawing.Point(6, 16);
            this.DGV_jour.Name = "DGV_jour";
            this.DGV_jour.Size = new System.Drawing.Size(578, 233);
            this.DGV_jour.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(164, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Echec de connexions des 3 derniers jours";
            // 
            // DGV_erreurCo
            // 
            this.DGV_erreurCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_erreurCo.Location = new System.Drawing.Point(21, 87);
            this.DGV_erreurCo.Name = "DGV_erreurCo";
            this.DGV_erreurCo.Size = new System.Drawing.Size(578, 230);
            this.DGV_erreurCo.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(85, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 78);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajouter un utilisateur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Utilisateur);
            this.tabControl1.Location = new System.Drawing.Point(81, 135);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 417);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BT_Date);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DTP_date);
            this.tabPage1.Controls.Add(this.DGV_jour);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connexion du jour";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BT_Date
            // 
            this.BT_Date.Location = new System.Drawing.Point(248, 340);
            this.BT_Date.Name = "BT_Date";
            this.BT_Date.Size = new System.Drawing.Size(75, 23);
            this.BT_Date.TabIndex = 15;
            this.BT_Date.Text = "Rechercher";
            this.BT_Date.UseVisualStyleBackColor = true;
            this.BT_Date.Click += new System.EventHandler(this.BT_Date_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Rechercher par date";
            // 
            // DTP_date
            // 
            this.DTP_date.Location = new System.Drawing.Point(201, 314);
            this.DTP_date.Name = "DTP_date";
            this.DTP_date.Size = new System.Drawing.Size(200, 20);
            this.DTP_date.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGV_erreurCo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Echec de connexions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Utilisateur
            // 
            this.Utilisateur.Controls.Add(this.DGV_User);
            this.Utilisateur.Location = new System.Drawing.Point(4, 22);
            this.Utilisateur.Name = "Utilisateur";
            this.Utilisateur.Padding = new System.Windows.Forms.Padding(3);
            this.Utilisateur.Size = new System.Drawing.Size(632, 391);
            this.Utilisateur.TabIndex = 2;
            this.Utilisateur.Text = "Utilisateur";
            this.Utilisateur.UseVisualStyleBackColor = true;
            // 
            // DGV_User
            // 
            this.DGV_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_User.Location = new System.Drawing.Point(6, 16);
            this.DGV_User.Name = "DGV_User";
            this.DGV_User.ReadOnly = true;
            this.DGV_User.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_User.Size = new System.Drawing.Size(620, 357);
            this.DGV_User.TabIndex = 0;
            this.DGV_User.DoubleClick += new System.EventHandler(this.DGV_User_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Partie administrateur";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(308, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 78);
            this.button2.TabIndex = 18;
            this.button2.Text = "Ajouter un salon";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(815, 587);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_jour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_erreurCo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Utilisateur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_User)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_jour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV_erreurCo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Utilisateur;
        private System.Windows.Forms.DataGridView DGV_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP_date;
        private System.Windows.Forms.Button BT_Date;
        private System.Windows.Forms.Button button2;
    }
}