namespace Labo5
{
    partial class frmAjouter
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.txtAcompte = new System.Windows.Forms.TextBox();
            this.cboVoyages = new System.Windows.Forms.ComboBox();
            this.cboVendeurs = new System.Windows.Forms.ComboBox();
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.bDVoyagesMarreroDataSet = new Labo5.BDVoyagesMarreroDataSet();
            this.nosEtDestinationsVoyagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtDestinationsVoyagesTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtDestinationsVoyagesTableAdapter();
            this.tableAdapterManager = new Labo5.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager();
            this.nosEtNomsClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsClientsTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtNomsClientsTableAdapter();
            this.nosEtNomsEmployesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nosEtNomsEmployesTableAdapter = new Labo5.BDVoyagesMarreroDataSetTableAdapters.nosEtNomsEmployesTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsEmployesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Acompte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voyage:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vendeur:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Client:";
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(148, 61);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(188, 20);
            this.txtMontant.TabIndex = 5;
            // 
            // txtAcompte
            // 
            this.txtAcompte.Location = new System.Drawing.Point(148, 124);
            this.txtAcompte.Name = "txtAcompte";
            this.txtAcompte.Size = new System.Drawing.Size(188, 20);
            this.txtAcompte.TabIndex = 6;
            // 
            // cboVoyages
            // 
            this.cboVoyages.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nosEtDestinationsVoyagesBindingSource, "voyNo", true));
            this.cboVoyages.DataSource = this.nosEtDestinationsVoyagesBindingSource;
            this.cboVoyages.DisplayMember = "Nom et Destination";
            this.cboVoyages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVoyages.FormattingEnabled = true;
            this.cboVoyages.Location = new System.Drawing.Point(148, 211);
            this.cboVoyages.Name = "cboVoyages";
            this.cboVoyages.Size = new System.Drawing.Size(294, 21);
            this.cboVoyages.TabIndex = 7;
            this.cboVoyages.ValueMember = "voyNo";
            // 
            // cboVendeurs
            // 
            this.cboVendeurs.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nosEtNomsEmployesBindingSource, "empNo", true));
            this.cboVendeurs.DataSource = this.nosEtNomsEmployesBindingSource;
            this.cboVendeurs.DisplayMember = "Nom complet";
            this.cboVendeurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendeurs.FormattingEnabled = true;
            this.cboVendeurs.Location = new System.Drawing.Point(148, 276);
            this.cboVendeurs.Name = "cboVendeurs";
            this.cboVendeurs.Size = new System.Drawing.Size(294, 21);
            this.cboVendeurs.TabIndex = 8;
            this.cboVendeurs.ValueMember = "empNo";
            // 
            // cboClients
            // 
            this.cboClients.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nosEtNomsClientsBindingSource, "cliNo", true));
            this.cboClients.DataSource = this.nosEtNomsClientsBindingSource;
            this.cboClients.DisplayMember = "Nom et Prenom ";
            this.cboClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(148, 363);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(294, 21);
            this.cboClients.TabIndex = 9;
            this.cboClients.ValueMember = "cliNo";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(367, 58);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 10;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(367, 128);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 11;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // bDVoyagesMarreroDataSet
            // 
            this.bDVoyagesMarreroDataSet.DataSetName = "BDVoyagesMarreroDataSet";
            this.bDVoyagesMarreroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nosEtDestinationsVoyagesBindingSource
            // 
            this.nosEtDestinationsVoyagesBindingSource.DataMember = "nosEtDestinationsVoyages";
            this.nosEtDestinationsVoyagesBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // nosEtDestinationsVoyagesTableAdapter
            // 
            this.nosEtDestinationsVoyagesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.contratTableAdapter = null;
            this.tableAdapterManager.employeTableAdapter = null;
            this.tableAdapterManager.faitLeVoyageTableAdapter = null;
            this.tableAdapterManager.hotelTableAdapter = null;
            this.tableAdapterManager.nosEtNomsEmployesTableAdapter = this.nosEtNomsEmployesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Labo5.BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.voyageTableAdapter = null;
            // 
            // nosEtNomsClientsBindingSource
            // 
            this.nosEtNomsClientsBindingSource.DataMember = "nosEtNomsClients";
            this.nosEtNomsClientsBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // nosEtNomsClientsTableAdapter
            // 
            this.nosEtNomsClientsTableAdapter.ClearBeforeFill = true;
            // 
            // nosEtNomsEmployesBindingSource
            // 
            this.nosEtNomsEmployesBindingSource.DataMember = "nosEtNomsEmployes";
            this.nosEtNomsEmployesBindingSource.DataSource = this.bDVoyagesMarreroDataSet;
            // 
            // nosEtNomsEmployesTableAdapter
            // 
            this.nosEtNomsEmployesTableAdapter.ClearBeforeFill = true;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cboClients);
            this.Controls.Add(this.cboVendeurs);
            this.Controls.Add(this.cboVoyages);
            this.Controls.Add(this.txtAcompte);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAjouter";
            this.Text = "frmAjouter";
            this.Load += new System.EventHandler(this.frmAjouter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDVoyagesMarreroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtDestinationsVoyagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nosEtNomsEmployesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.TextBox txtAcompte;
        private System.Windows.Forms.ComboBox cboVoyages;
        private System.Windows.Forms.ComboBox cboVendeurs;
        private System.Windows.Forms.ComboBox cboClients;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFermer;
        private BDVoyagesMarreroDataSet bDVoyagesMarreroDataSet;
        private System.Windows.Forms.BindingSource nosEtDestinationsVoyagesBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtDestinationsVoyagesTableAdapter nosEtDestinationsVoyagesTableAdapter;
        private BDVoyagesMarreroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource nosEtNomsClientsBindingSource;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtNomsClientsTableAdapter nosEtNomsClientsTableAdapter;
        private BDVoyagesMarreroDataSetTableAdapters.nosEtNomsEmployesTableAdapter nosEtNomsEmployesTableAdapter;
        private System.Windows.Forms.BindingSource nosEtNomsEmployesBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}