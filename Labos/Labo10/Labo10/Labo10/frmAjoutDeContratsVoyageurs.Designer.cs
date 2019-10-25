namespace Labo10
{
    partial class frmAjoutDeContratsVoyageurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.nudAcompte = new System.Windows.Forms.NumericUpDown();
            this.nudMontant = new System.Windows.Forms.NumericUpDown();
            this.nudPaye = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEmploye = new System.Windows.Forms.ComboBox();
            this.noEtNomEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboVoyage = new System.Windows.Forms.ComboBox();
            this.noEtDestinationVoyageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.noEtNomClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcompte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDestinationVoyageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomClientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "La date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(181, 43);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDate_Validating);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acompte:";
            // 
            // nudAcompte
            // 
            this.nudAcompte.DecimalPlaces = 2;
            this.nudAcompte.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudAcompte.Location = new System.Drawing.Point(181, 83);
            this.nudAcompte.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.nudAcompte.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAcompte.Name = "nudAcompte";
            this.nudAcompte.Size = new System.Drawing.Size(200, 20);
            this.nudAcompte.TabIndex = 5;
            this.nudAcompte.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAcompte.Validating += new System.ComponentModel.CancelEventHandler(this.nudAcompte_Validating);
            // 
            // nudMontant
            // 
            this.nudMontant.DecimalPlaces = 2;
            this.nudMontant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMontant.Location = new System.Drawing.Point(181, 120);
            this.nudMontant.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.nudMontant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMontant.Name = "nudMontant";
            this.nudMontant.Size = new System.Drawing.Size(200, 20);
            this.nudMontant.TabIndex = 6;
            this.nudMontant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMontant.Validating += new System.ComponentModel.CancelEventHandler(this.nudMontant_Validating);
            // 
            // nudPaye
            // 
            this.nudPaye.DecimalPlaces = 2;
            this.nudPaye.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPaye.Location = new System.Drawing.Point(181, 167);
            this.nudPaye.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            131072});
            this.nudPaye.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPaye.Name = "nudPaye";
            this.nudPaye.Size = new System.Drawing.Size(200, 20);
            this.nudPaye.TabIndex = 7;
            this.nudPaye.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPaye.Validating += new System.ComponentModel.CancelEventHandler(this.nudPaye_Validating);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(181, 207);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Montant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Payé:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nb places:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(87, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Client:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Voyages:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Employé:";
            // 
            // cboEmploye
            // 
            this.cboEmploye.DataSource = this.noEtNomEmployeBindingSource;
            this.cboEmploye.DisplayMember = "nomCompletEmploye";
            this.cboEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmploye.FormattingEnabled = true;
            this.cboEmploye.Location = new System.Drawing.Point(181, 252);
            this.cboEmploye.Name = "cboEmploye";
            this.cboEmploye.Size = new System.Drawing.Size(200, 21);
            this.cboEmploye.TabIndex = 13;
            this.cboEmploye.ValueMember = "noEmploye";
            // 
            // noEtNomEmployeBindingSource
            // 
            this.noEtNomEmployeBindingSource.DataSource = typeof(Labo10.NoEtNomEmploye);
            // 
            // cboVoyage
            // 
            this.cboVoyage.DataSource = this.noEtDestinationVoyageBindingSource;
            this.cboVoyage.DisplayMember = "destinationVoyage";
            this.cboVoyage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoyage.FormattingEnabled = true;
            this.cboVoyage.Location = new System.Drawing.Point(181, 296);
            this.cboVoyage.Name = "cboVoyage";
            this.cboVoyage.Size = new System.Drawing.Size(200, 21);
            this.cboVoyage.TabIndex = 14;
            this.cboVoyage.ValueMember = "destinationVoyage";
            // 
            // noEtDestinationVoyageBindingSource
            // 
            this.noEtDestinationVoyageBindingSource.DataSource = typeof(Labo10.NoEtDestinationVoyage);
            // 
            // cboClient
            // 
            this.cboClient.DataSource = this.noEtNomClientBindingSource;
            this.cboClient.DisplayMember = "nomCompletClient";
            this.cboClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(181, 339);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(200, 21);
            this.cboClient.TabIndex = 15;
            this.cboClient.ValueMember = "noClient";
            // 
            // noEtNomClientBindingSource
            // 
            this.noEtNomClientBindingSource.DataSource = typeof(Labo10.NoEtNomClient);
            // 
            // frmAjoutDeContratsVoyageurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.cboClient);
            this.Controls.Add(this.cboVoyage);
            this.Controls.Add(this.cboEmploye);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudPaye);
            this.Controls.Add(this.nudMontant);
            this.Controls.Add(this.nudAcompte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label1);
            this.Name = "frmAjoutDeContratsVoyageurs";
            this.Text = "Ajout de contrats et de voyageurs(Gabriel Marrero)";
            this.Load += new System.EventHandler(this.frmAjoutDeContratsVoyageurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAcompte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtDestinationVoyageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noEtNomClientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPaye;
        private System.Windows.Forms.NumericUpDown nudMontant;
        private System.Windows.Forms.NumericUpDown nudAcompte;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cboEmploye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.ComboBox cboVoyage;
        private System.Windows.Forms.BindingSource noEtNomClientBindingSource;
        private System.Windows.Forms.BindingSource noEtDestinationVoyageBindingSource;
        private System.Windows.Forms.BindingSource noEtNomEmployeBindingSource;
    }
}

