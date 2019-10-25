namespace Labo9
{
    partial class frmLabo9
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnTousLesCliens = new System.Windows.Forms.Button();
            this.btnClientParVille = new System.Windows.Forms.Button();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnRemplacerVille = new System.Windows.Forms.Button();
            this.tbVilleSource = new System.Windows.Forms.TextBox();
            this.tbVilleCible = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 256);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.clientDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion des clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AutoGenerateColumns = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clientDataGridView.DataSource = this.clientBindingSource;
            this.clientDataGridView.Location = new System.Drawing.Point(0, 0);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(645, 220);
            this.clientDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cliNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "cliNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cliPrenom";
            this.dataGridViewTextBoxColumn2.HeaderText = "cliPrenom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cliNom";
            this.dataGridViewTextBoxColumn3.HeaderText = "cliNom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cliRue";
            this.dataGridViewTextBoxColumn4.HeaderText = "cliRue";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cliVille";
            this.dataGridViewTextBoxColumn5.HeaderText = "cliVille";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cliTelephone";
            this.dataGridViewTextBoxColumn6.HeaderText = "cliTelephone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Labo9.client);
            this.clientBindingSource.CurrentChanged += new System.EventHandler(this.clientBindingSource_CurrentChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnTousLesCliens
            // 
            this.btnTousLesCliens.Location = new System.Drawing.Point(15, 272);
            this.btnTousLesCliens.Name = "btnTousLesCliens";
            this.btnTousLesCliens.Size = new System.Drawing.Size(118, 23);
            this.btnTousLesCliens.TabIndex = 2;
            this.btnTousLesCliens.Text = "Tous les cliens";
            this.btnTousLesCliens.UseVisualStyleBackColor = true;
            this.btnTousLesCliens.Click += new System.EventHandler(this.btnTousLesCliens_Click);
            // 
            // btnClientParVille
            // 
            this.btnClientParVille.Location = new System.Drawing.Point(139, 272);
            this.btnClientParVille.Name = "btnClientParVille";
            this.btnClientParVille.Size = new System.Drawing.Size(273, 23);
            this.btnClientParVille.TabIndex = 3;
            this.btnClientParVille.Text = "Tous les cliens qui demeurent dans cette ville";
            this.btnClientParVille.UseVisualStyleBackColor = true;
            this.btnClientParVille.Click += new System.EventHandler(this.btnClientParVille_Click);
            // 
            // tbVille
            // 
            this.tbVille.Location = new System.Drawing.Point(418, 274);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(111, 20);
            this.tbVille.TabIndex = 4;
            // 
            // contratBindingSource
            // 
            this.contratBindingSource.DataSource = typeof(Labo9.contrat);
            // 
            // contratDataGridView
            // 
            this.contratDataGridView.AutoGenerateColumns = false;
            this.contratDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contratDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn15});
            this.contratDataGridView.DataSource = this.contratBindingSource;
            this.contratDataGridView.Location = new System.Drawing.Point(15, 328);
            this.contratDataGridView.Name = "contratDataGridView";
            this.contratDataGridView.Size = new System.Drawing.Size(645, 220);
            this.contratDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "conNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "conNo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "conDate";
            this.dataGridViewTextBoxColumn8.HeaderText = "conDate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "conAcompte";
            this.dataGridViewTextBoxColumn9.HeaderText = "conAcompte";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "conMontant";
            this.dataGridViewTextBoxColumn10.HeaderText = "conMontant";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ConPaye";
            this.dataGridViewTextBoxColumn11.HeaderText = "ConPaye";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "cliNo";
            this.dataGridViewTextBoxColumn15.HeaderText = "cliNo";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(543, 274);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(118, 48);
            this.btnEnregistrer.TabIndex = 5;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnRemplacerVille
            // 
            this.btnRemplacerVille.Location = new System.Drawing.Point(169, 298);
            this.btnRemplacerVille.Name = "btnRemplacerVille";
            this.btnRemplacerVille.Size = new System.Drawing.Size(203, 23);
            this.btnRemplacerVille.TabIndex = 6;
            this.btnRemplacerVille.Text = "Remplacer cette ville par celle-ci";
            this.btnRemplacerVille.UseVisualStyleBackColor = true;
            this.btnRemplacerVille.Click += new System.EventHandler(this.btnRemplacerVille_Click);
            // 
            // tbVilleSource
            // 
            this.tbVilleSource.Location = new System.Drawing.Point(12, 301);
            this.tbVilleSource.Name = "tbVilleSource";
            this.tbVilleSource.Size = new System.Drawing.Size(151, 20);
            this.tbVilleSource.TabIndex = 7;
            // 
            // tbVilleCible
            // 
            this.tbVilleCible.Location = new System.Drawing.Point(378, 301);
            this.tbVilleCible.Name = "tbVilleCible";
            this.tbVilleCible.Size = new System.Drawing.Size(151, 20);
            this.tbVilleCible.TabIndex = 8;
            // 
            // frmLabo9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 560);
            this.Controls.Add(this.tbVilleCible);
            this.Controls.Add(this.tbVilleSource);
            this.Controls.Add(this.btnRemplacerVille);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.contratDataGridView);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(this.btnClientParVille);
            this.Controls.Add(this.btnTousLesCliens);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmLabo9";
            this.Text = "Form labo 9";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLabo9_FormClosed);
            this.Load += new System.EventHandler(this.frmLabo9_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnTousLesCliens;
        private System.Windows.Forms.Button btnClientParVille;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private System.Windows.Forms.DataGridView contratDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnRemplacerVille;
        private System.Windows.Forms.TextBox tbVilleSource;
        private System.Windows.Forms.TextBox tbVilleCible;
    }
}

