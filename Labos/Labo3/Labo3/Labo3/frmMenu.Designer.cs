namespace Labo3
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
            this.modèleMVCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modèleMVCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chargementDynamiqueDesDonnéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modèleMVCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modèleMVCToolStripMenuItem
            // 
            this.modèleMVCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modèleMVCToolStripMenuItem1,
            this.chargementDynamiqueDesDonnéesToolStripMenuItem});
            this.modèleMVCToolStripMenuItem.Name = "modèleMVCToolStripMenuItem";
            this.modèleMVCToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.modèleMVCToolStripMenuItem.Text = "Laboratoire 3";
            // 
            // modèleMVCToolStripMenuItem1
            // 
            this.modèleMVCToolStripMenuItem1.Name = "modèleMVCToolStripMenuItem1";
            this.modèleMVCToolStripMenuItem1.Size = new System.Drawing.Size(272, 22);
            this.modèleMVCToolStripMenuItem1.Text = "Modèle MVC";
            this.modèleMVCToolStripMenuItem1.Click += new System.EventHandler(this.modèleMVCToolStripMenuItem1_Click);
            // 
            // chargementDynamiqueDesDonnéesToolStripMenuItem
            // 
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Name = "chargementDynamiqueDesDonnéesToolStripMenuItem";
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Text = "Chargement dynamique des données";
            this.chargementDynamiqueDesDonnéesToolStripMenuItem.Click += new System.EventHandler(this.chargementDynamiqueDesDonnéesToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modèleMVCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modèleMVCToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chargementDynamiqueDesDonnéesToolStripMenuItem;
    }
}

