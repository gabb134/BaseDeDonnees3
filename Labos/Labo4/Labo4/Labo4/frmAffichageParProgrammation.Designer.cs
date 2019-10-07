namespace Labo4
{
    partial class frmAffichageParProgrammation
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
            this.btnAfficherEmployes = new System.Windows.Forms.Button();
            this.lstEmployes = new System.Windows.Forms.ListBox();
            this.lstContrats = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAfficherEmployes
            // 
            this.btnAfficherEmployes.Location = new System.Drawing.Point(27, 54);
            this.btnAfficherEmployes.Name = "btnAfficherEmployes";
            this.btnAfficherEmployes.Size = new System.Drawing.Size(249, 23);
            this.btnAfficherEmployes.TabIndex = 2;
            this.btnAfficherEmployes.Text = "Afficher les employés";
            this.btnAfficherEmployes.UseVisualStyleBackColor = true;
            this.btnAfficherEmployes.Click += new System.EventHandler(this.btnAfficherEmployes_Click);
            // 
            // lstEmployes
            // 
            this.lstEmployes.FormattingEnabled = true;
            this.lstEmployes.Location = new System.Drawing.Point(27, 83);
            this.lstEmployes.Name = "lstEmployes";
            this.lstEmployes.Size = new System.Drawing.Size(249, 212);
            this.lstEmployes.TabIndex = 3;
            this.lstEmployes.SelectedIndexChanged += new System.EventHandler(this.lstEmployes_SelectedIndexChanged);
            // 
            // lstContrats
            // 
            this.lstContrats.FormattingEnabled = true;
            this.lstContrats.Location = new System.Drawing.Point(298, 83);
            this.lstContrats.Name = "lstContrats";
            this.lstContrats.Size = new System.Drawing.Size(186, 212);
            this.lstContrats.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contrats";
            // 
            // frmAffichageParProgrammation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstContrats);
            this.Controls.Add(this.lstEmployes);
            this.Controls.Add(this.btnAfficherEmployes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAffichageParProgrammation";
            this.Text = "Affichage par programmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherEmployes;
        private System.Windows.Forms.ListBox lstEmployes;
        private System.Windows.Forms.ListBox lstContrats;
        private System.Windows.Forms.Label label1;
    }
}