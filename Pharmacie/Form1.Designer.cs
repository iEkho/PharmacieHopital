namespace formHopital
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAdrMail = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblGestion = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdrMail
            // 
            this.lblAdrMail.AutoSize = true;
            this.lblAdrMail.BackColor = System.Drawing.Color.Transparent;
            this.lblAdrMail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdrMail.ForeColor = System.Drawing.Color.White;
            this.lblAdrMail.Location = new System.Drawing.Point(113, 110);
            this.lblAdrMail.Name = "lblAdrMail";
            this.lblAdrMail.Size = new System.Drawing.Size(116, 16);
            this.lblAdrMail.TabIndex = 0;
            this.lblAdrMail.Text = "Adresse e-mail :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.BackColor = System.Drawing.Color.Transparent;
            this.lblMdp.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.White;
            this.lblMdp.Location = new System.Drawing.Point(113, 162);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(108, 16);
            this.lblMdp.TabIndex = 1;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // lblGestion
            // 
            this.lblGestion.AutoSize = true;
            this.lblGestion.BackColor = System.Drawing.Color.Transparent;
            this.lblGestion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.White;
            this.lblGestion.Location = new System.Drawing.Point(191, 38);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(218, 18);
            this.lblGestion.TabIndex = 2;
            this.lblGestion.Text = "Gestion de la pharmacie";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(235, 109);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(229, 20);
            this.txtMail.TabIndex = 3;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(235, 161);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(229, 20);
            this.txtMdp.TabIndex = 4;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(235, 212);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(123, 28);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(599, 281);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblGestion);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblAdrMail);
            this.Name = "Form1";
            this.Text = "Gestion de la pharmacie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdrMail;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Button btnConnexion;
    }
}

