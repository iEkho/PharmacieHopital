namespace formHopital
{
    partial class Depot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retrait));
            this.cbMedicament = new System.Windows.Forms.ComboBox();
            this.lblDepot = new System.Windows.Forms.Label();
            this.lblMedicament = new System.Windows.Forms.Label();
            this.lblQtte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnValiderDepot = new System.Windows.Forms.Button();
            this.lblMedecin = new System.Windows.Forms.Label();
            this.cbMedecin = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(189, 135);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(157, 21);
            this.cbMedicament.TabIndex = 0;
            // 
            // lblDepot
            // 
            this.lblDepot.AutoSize = true;
            this.lblDepot.BackColor = System.Drawing.Color.Transparent;
            this.lblDepot.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepot.ForeColor = System.Drawing.Color.White;
            this.lblDepot.Location = new System.Drawing.Point(304, 57);
            this.lblDepot.Name = "lblDepot";
            this.lblDepot.Size = new System.Drawing.Size(111, 29);
            this.lblDepot.TabIndex = 1;
            this.lblDepot.Text = "Dépôt :";
            // 
            // lblMedicament
            // 
            this.lblMedicament.AutoSize = true;
            this.lblMedicament.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicament.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicament.ForeColor = System.Drawing.Color.White;
            this.lblMedicament.Location = new System.Drawing.Point(69, 135);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(98, 16);
            this.lblMedicament.TabIndex = 2;
            this.lblMedicament.Text = "Médicament :";
            // 
            // lblQtte
            // 
            this.lblQtte.AutoSize = true;
            this.lblQtte.BackColor = System.Drawing.Color.Transparent;
            this.lblQtte.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtte.ForeColor = System.Drawing.Color.White;
            this.lblQtte.Location = new System.Drawing.Point(403, 135);
            this.lblQtte.Name = "lblQtte";
            this.lblQtte.Size = new System.Drawing.Size(76, 16);
            this.lblQtte.TabIndex = 3;
            this.lblQtte.Text = "Quantité :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(485, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnValiderDepot
            // 
            this.btnValiderDepot.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderDepot.Location = new System.Drawing.Point(278, 255);
            this.btnValiderDepot.Name = "btnValiderDepot";
            this.btnValiderDepot.Size = new System.Drawing.Size(149, 37);
            this.btnValiderDepot.TabIndex = 5;
            this.btnValiderDepot.Text = "Valider";
            this.btnValiderDepot.UseVisualStyleBackColor = true;
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.BackColor = System.Drawing.Color.Transparent;
            this.lblMedecin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.ForeColor = System.Drawing.Color.White;
            this.lblMedecin.Location = new System.Drawing.Point(69, 192);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(114, 16);
            this.lblMedecin.TabIndex = 7;
            this.lblMedecin.Text = "Médecin client :";
            // 
            // cbMedecin
            // 
            this.cbMedecin.FormattingEnabled = true;
            this.cbMedecin.Location = new System.Drawing.Point(189, 191);
            this.cbMedecin.Name = "cbMedecin";
            this.cbMedecin.Size = new System.Drawing.Size(157, 21);
            this.cbMedecin.TabIndex = 6;
            // 
            // Retrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 337);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cbMedecin);
            this.Controls.Add(this.btnValiderDepot);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQtte);
            this.Controls.Add(this.lblMedicament);
            this.Controls.Add(this.lblDepot);
            this.Controls.Add(this.cbMedicament);
            this.Name = "Retrait";
            this.Text = "Gestion de la pharmacie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.Label lblDepot;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.Label lblQtte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnValiderDepot;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.ComboBox cbMedecin;
    }
}