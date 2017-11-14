namespace formHopital
{
    partial class Retrait
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedicament = new System.Windows.Forms.Label();
            this.lblQtte = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnValiderRetrait = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbMedicament
            // 
            this.cbMedicament.FormattingEnabled = true;
            this.cbMedicament.Location = new System.Drawing.Point(173, 134);
            this.cbMedicament.Name = "cbMedicament";
            this.cbMedicament.Size = new System.Drawing.Size(157, 21);
            this.cbMedicament.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(304, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Retrait :";
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
            // btnValiderRetrait
            // 
            this.btnValiderRetrait.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderRetrait.Location = new System.Drawing.Point(290, 211);
            this.btnValiderRetrait.Name = "btnValiderRetrait";
            this.btnValiderRetrait.Size = new System.Drawing.Size(149, 37);
            this.btnValiderRetrait.TabIndex = 5;
            this.btnValiderRetrait.Text = "Valider";
            this.btnValiderRetrait.UseVisualStyleBackColor = true;
            // 
            // Retrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 296);
            this.Controls.Add(this.btnValiderRetrait);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQtte);
            this.Controls.Add(this.lblMedicament);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMedicament);
            this.Name = "Retrait";
            this.Text = "Gestion de la pharmacie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMedicament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.Label lblQtte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnValiderRetrait;
    }
}