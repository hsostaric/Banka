﻿namespace BankaHS.PAL
{
    partial class frmKlijenti
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDodajKlijenta = new System.Windows.Forms.Button();
            this.btnAzurirajKlijenta = new System.Windows.Forms.Button();
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uiFullClientData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiClientName = new System.Windows.Forms.TextBox();
            this.uiClientSurname = new System.Windows.Forms.TextBox();
            this.uiClientOIB = new System.Windows.Forms.TextBox();
            this.uiReset = new System.Windows.Forms.Button();
            this.uiSearchClients = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nazadToolStripMenuItem.Text = "Nazad";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click_1);
            // 
            // btnDodajKlijenta
            // 
            this.btnDodajKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajKlijenta.Location = new System.Drawing.Point(63, 322);
            this.btnDodajKlijenta.Name = "btnDodajKlijenta";
            this.btnDodajKlijenta.Size = new System.Drawing.Size(127, 64);
            this.btnDodajKlijenta.TabIndex = 2;
            this.btnDodajKlijenta.Text = "Dodaj klijenta";
            this.btnDodajKlijenta.UseVisualStyleBackColor = true;
            this.btnDodajKlijenta.Click += new System.EventHandler(this.btnDodajKlijenta_Click);
            // 
            // btnAzurirajKlijenta
            // 
            this.btnAzurirajKlijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAzurirajKlijenta.Location = new System.Drawing.Point(228, 322);
            this.btnAzurirajKlijenta.Name = "btnAzurirajKlijenta";
            this.btnAzurirajKlijenta.Size = new System.Drawing.Size(127, 64);
            this.btnAzurirajKlijenta.TabIndex = 3;
            this.btnAzurirajKlijenta.Text = "Ažuriraj klijenta";
            this.btnAzurirajKlijenta.UseVisualStyleBackColor = true;
            this.btnAzurirajKlijenta.Click += new System.EventHandler(this.btnAzurirajKlijenta_Click);
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKlijenti.AutoGenerateColumns = false;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.oIBDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.kontaktDataGridViewTextBoxColumn});
            this.dgvKlijenti.DataSource = this.klijentBindingSource;
            this.dgvKlijenti.Location = new System.Drawing.Point(63, 53);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(569, 198);
            this.dgvKlijenti.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // kontaktDataGridViewTextBoxColumn
            // 
            this.kontaktDataGridViewTextBoxColumn.DataPropertyName = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.HeaderText = "Kontakt";
            this.kontaktDataGridViewTextBoxColumn.Name = "kontaktDataGridViewTextBoxColumn";
            this.kontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(BankaHS.BLL.Klijent);
            // 
            // uiFullClientData
            // 
            this.uiFullClientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiFullClientData.Location = new System.Drawing.Point(383, 322);
            this.uiFullClientData.Name = "uiFullClientData";
            this.uiFullClientData.Size = new System.Drawing.Size(148, 64);
            this.uiFullClientData.TabIndex = 4;
            this.uiFullClientData.Text = "Pune informacije o klijentu";
            this.uiFullClientData.UseVisualStyleBackColor = true;
            this.uiFullClientData.Click += new System.EventHandler(this.uiFullClientData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(684, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "OIB";
            // 
            // uiClientName
            // 
            this.uiClientName.Location = new System.Drawing.Point(754, 47);
            this.uiClientName.Name = "uiClientName";
            this.uiClientName.Size = new System.Drawing.Size(254, 22);
            this.uiClientName.TabIndex = 8;
            // 
            // uiClientSurname
            // 
            this.uiClientSurname.Location = new System.Drawing.Point(754, 89);
            this.uiClientSurname.Name = "uiClientSurname";
            this.uiClientSurname.Size = new System.Drawing.Size(254, 22);
            this.uiClientSurname.TabIndex = 9;
            // 
            // uiClientOIB
            // 
            this.uiClientOIB.Location = new System.Drawing.Point(754, 130);
            this.uiClientOIB.Name = "uiClientOIB";
            this.uiClientOIB.Size = new System.Drawing.Size(254, 22);
            this.uiClientOIB.TabIndex = 10;
            // 
            // uiReset
            // 
            this.uiReset.Location = new System.Drawing.Point(754, 185);
            this.uiReset.Name = "uiReset";
            this.uiReset.Size = new System.Drawing.Size(105, 39);
            this.uiReset.TabIndex = 11;
            this.uiReset.Text = "Reset";
            this.uiReset.UseVisualStyleBackColor = true;
            this.uiReset.Click += new System.EventHandler(this.uiReset_Click);
            // 
            // uiSearchClients
            // 
            this.uiSearchClients.Location = new System.Drawing.Point(903, 185);
            this.uiSearchClients.Name = "uiSearchClients";
            this.uiSearchClients.Size = new System.Drawing.Size(105, 39);
            this.uiSearchClients.TabIndex = 12;
            this.uiSearchClients.Text = "Pretrazi";
            this.uiSearchClients.UseVisualStyleBackColor = true;
            this.uiSearchClients.Click += new System.EventHandler(this.uiSearchClients_Click);
            // 
            // frmKlijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.uiSearchClients);
            this.Controls.Add(this.uiReset);
            this.Controls.Add(this.uiClientOIB);
            this.Controls.Add(this.uiClientSurname);
            this.Controls.Add(this.uiClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiFullClientData);
            this.Controls.Add(this.btnAzurirajKlijenta);
            this.Controls.Add(this.btnDodajKlijenta);
            this.Controls.Add(this.dgvKlijenti);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKlijenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klijenti";
            this.Load += new System.EventHandler(this.frmKlijenti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajKlijenta;
        private System.Windows.Forms.Button btnAzurirajKlijenta;
        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.Button uiFullClientData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiClientName;
        private System.Windows.Forms.TextBox uiClientSurname;
        private System.Windows.Forms.TextBox uiClientOIB;
        private System.Windows.Forms.Button uiReset;
        private System.Windows.Forms.Button uiSearchClients;
    }
}