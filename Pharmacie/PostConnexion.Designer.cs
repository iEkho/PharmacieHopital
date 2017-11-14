namespace formHopital
{
    partial class PostConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostConnexion));
            this.btnRetrait = new System.Windows.Forms.Button();
            this.btnDepot = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblNomUtilisateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRetrait
            // 
            this.btnRetrait.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrait.Location = new System.Drawing.Point(168, 166);
            this.btnRetrait.Name = "btnRetrait";
            this.btnRetrait.Size = new System.Drawing.Size(116, 36);
            this.btnRetrait.TabIndex = 0;
            this.btnRetrait.Text = "Retrait ?";
            this.btnRetrait.UseVisualStyleBackColor = true;
            // 
            // btnDepot
            // 
            this.btnDepot.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepot.Location = new System.Drawing.Point(287, 166);
            this.btnDepot.Name = "btnDepot";
            this.btnDepot.Size = new System.Drawing.Size(116, 36);
            this.btnDepot.TabIndex = 1;
            this.btnDepot.Text = "Dépôt ?";
            this.btnDepot.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(212, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Contrôle des stocks ?";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblNomUtilisateur
            // 
            this.lblNomUtilisateur.AutoSize = true;
            this.lblNomUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUtilisateur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUtilisateur.ForeColor = System.Drawing.Color.White;
            this.lblNomUtilisateur.Location = new System.Drawing.Point(122, 122);
            this.lblNomUtilisateur.Name = "lblNomUtilisateur";
            this.lblNomUtilisateur.Size = new System.Drawing.Size(347, 16);
            this.lblNomUtilisateur.TabIndex = 3;
            this.lblNomUtilisateur.Text = "Bonjour Mr Desprez, voulez vous effectuer un :";
            // 
            // PostConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 362);
            this.Controls.Add(this.lblNomUtilisateur);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDepot);
            this.Controls.Add(this.btnRetrait);
            this.Name = "PostConnexion";
            this.Text = "Gestion de la pharmacie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetrait;
        private System.Windows.Forms.Button btnDepot;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblNomUtilisateur;
    }
}