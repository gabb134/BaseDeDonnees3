namespace Labo2
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
            this.laboratoire2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageEnregistrementParEnregistrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageTabulaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageÀPartirDePlusieursTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageMaîtredétailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageAvecFiltreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratoire2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // laboratoire2ToolStripMenuItem
            // 
            this.laboratoire2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageEnregistrementParEnregistrementToolStripMenuItem,
            this.affichageTabulaireToolStripMenuItem,
            this.affichageÀPartirDePlusieursTablesToolStripMenuItem,
            this.affichageMaîtredétailToolStripMenuItem,
            this.affichageAvecFiltreToolStripMenuItem});
            this.laboratoire2ToolStripMenuItem.Name = "laboratoire2ToolStripMenuItem";
            this.laboratoire2ToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.laboratoire2ToolStripMenuItem.Text = "Laboratoire 2";
            // 
            // affichageEnregistrementParEnregistrementToolStripMenuItem
            // 
            this.affichageEnregistrementParEnregistrementToolStripMenuItem.Name = "affichageEnregistrementParEnregistrementToolStripMenuItem";
            this.affichageEnregistrementParEnregistrementToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.affichageEnregistrementParEnregistrementToolStripMenuItem.Text = "Affichage enregistrement par enregistrement";
            this.affichageEnregistrementParEnregistrementToolStripMenuItem.Click += new System.EventHandler(this.affichageEnregistrementParEnregistrementToolStripMenuItem_Click);
            // 
            // affichageTabulaireToolStripMenuItem
            // 
            this.affichageTabulaireToolStripMenuItem.Name = "affichageTabulaireToolStripMenuItem";
            this.affichageTabulaireToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.affichageTabulaireToolStripMenuItem.Text = "Affichage tabulaire";
            this.affichageTabulaireToolStripMenuItem.Click += new System.EventHandler(this.affichageTabulaireToolStripMenuItem_Click);
            // 
            // affichageÀPartirDePlusieursTablesToolStripMenuItem
            // 
            this.affichageÀPartirDePlusieursTablesToolStripMenuItem.Name = "affichageÀPartirDePlusieursTablesToolStripMenuItem";
            this.affichageÀPartirDePlusieursTablesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.affichageÀPartirDePlusieursTablesToolStripMenuItem.Text = "Affichage à partir de plusieurs tables";
            this.affichageÀPartirDePlusieursTablesToolStripMenuItem.Click += new System.EventHandler(this.affichageÀPartirDePlusieursTablesToolStripMenuItem_Click);
            // 
            // affichageMaîtredétailToolStripMenuItem
            // 
            this.affichageMaîtredétailToolStripMenuItem.Name = "affichageMaîtredétailToolStripMenuItem";
            this.affichageMaîtredétailToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.affichageMaîtredétailToolStripMenuItem.Text = "Affichage maître/détail";
            this.affichageMaîtredétailToolStripMenuItem.Click += new System.EventHandler(this.affichageMaîtredétailToolStripMenuItem_Click);
            // 
            // affichageAvecFiltreToolStripMenuItem
            // 
            this.affichageAvecFiltreToolStripMenuItem.Name = "affichageAvecFiltreToolStripMenuItem";
            this.affichageAvecFiltreToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
            this.affichageAvecFiltreToolStripMenuItem.Text = "Affichage avec filtre";
            this.affichageAvecFiltreToolStripMenuItem.Click += new System.EventHandler(this.affichageAvecFiltreToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu(Marrero)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laboratoire2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageEnregistrementParEnregistrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageTabulaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageÀPartirDePlusieursTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageMaîtredétailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageAvecFiltreToolStripMenuItem;
    }
}

