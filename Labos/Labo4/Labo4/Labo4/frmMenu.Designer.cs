namespace Labo4
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.laboratoire4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageParProgrammationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réservationDeVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratoire4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratoire4ToolStripMenuItem
            // 
            this.laboratoire4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageParProgrammationToolStripMenuItem,
            this.réservationDeVoyagesToolStripMenuItem});
            this.laboratoire4ToolStripMenuItem.Name = "laboratoire4ToolStripMenuItem";
            this.laboratoire4ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.laboratoire4ToolStripMenuItem.Text = "Laboratoire 4";
            // 
            // affichageParProgrammationToolStripMenuItem
            // 
            this.affichageParProgrammationToolStripMenuItem.Name = "affichageParProgrammationToolStripMenuItem";
            this.affichageParProgrammationToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.affichageParProgrammationToolStripMenuItem.Text = "Affichage par programmation";
            this.affichageParProgrammationToolStripMenuItem.Click += new System.EventHandler(this.affichageParProgrammationToolStripMenuItem_Click);
            // 
            // réservationDeVoyagesToolStripMenuItem
            // 
            this.réservationDeVoyagesToolStripMenuItem.Name = "réservationDeVoyagesToolStripMenuItem";
            this.réservationDeVoyagesToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.réservationDeVoyagesToolStripMenuItem.Text = "Réservation de voyages";
            this.réservationDeVoyagesToolStripMenuItem.Click += new System.EventHandler(this.réservationDeVoyagesToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu (Marrero)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratoire4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageParProgrammationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réservationDeVoyagesToolStripMenuItem;
    }
}

