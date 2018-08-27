namespace BusinessCardHolder.Forms
{
    partial class CompaniesListForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteButton = new System.Windows.Forms.Button();
            this.btnEditButton = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.grdCompanies = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSearchButton = new System.Windows.Forms.Button();
            this.txtSearchPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblNip = new System.Windows.Forms.Label();
            this.txtSearchPostCode = new System.Windows.Forms.TextBox();
            this.txtSearchNip = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtSearchCity = new System.Windows.Forms.TextBox();
            this.txtSearchCompanyName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.bsCompanies = new System.Windows.Forms.BindingSource(this.components);
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnBackButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 463);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(882, 34);
            this.panel6.TabIndex = 2;
            // 
            // btnBackButton
            // 
            this.btnBackButton.Location = new System.Drawing.Point(9, 8);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(75, 23);
            this.btnBackButton.TabIndex = 10;
            this.btnBackButton.Text = "Zamknij";
            this.btnBackButton.UseVisualStyleBackColor = true;
            this.btnBackButton.Click += new System.EventHandler(this.btnBackButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteButton);
            this.panel5.Controls.Add(this.btnEditButton);
            this.panel5.Controls.Add(this.btnAddButton);
            this.panel5.Controls.Add(this.grdCompanies);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(882, 304);
            this.panel5.TabIndex = 1;
            // 
            // btnDeleteButton
            // 
            this.btnDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteButton.Location = new System.Drawing.Point(171, 245);
            this.btnDeleteButton.Name = "btnDeleteButton";
            this.btnDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteButton.TabIndex = 9;
            this.btnDeleteButton.Text = "Usuń";
            this.btnDeleteButton.UseVisualStyleBackColor = true;
            this.btnDeleteButton.Click += new System.EventHandler(this.btnDeleteButton_Click);
            // 
            // btnEditButton
            // 
            this.btnEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditButton.Location = new System.Drawing.Point(90, 245);
            this.btnEditButton.Name = "btnEditButton";
            this.btnEditButton.Size = new System.Drawing.Size(75, 23);
            this.btnEditButton.TabIndex = 8;
            this.btnEditButton.Text = "Edytuj";
            this.btnEditButton.UseVisualStyleBackColor = true;
            this.btnEditButton.Click += new System.EventHandler(this.btnEditButton_Click);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddButton.Location = new System.Drawing.Point(9, 245);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(75, 23);
            this.btnAddButton.TabIndex = 7;
            this.btnAddButton.Text = "Dodaj";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // grdCompanies
            // 
            this.grdCompanies.AllowUserToAddRows = false;
            this.grdCompanies.AllowUserToDeleteRows = false;
            this.grdCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmCompanyName,
            this.clmNip,
            this.clmAddress,
            this.clmCity,
            this.clmPostCode,
            this.clmPhoneNumber,
            this.clmNotes});
            this.grdCompanies.Location = new System.Drawing.Point(9, 3);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.ReadOnly = true;
            this.grdCompanies.Size = new System.Drawing.Size(863, 223);
            this.grdCompanies.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(882, 144);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblPhoneNumber);
            this.panel4.Controls.Add(this.lblAddress);
            this.panel4.Controls.Add(this.btnSearchButton);
            this.panel4.Controls.Add(this.txtSearchPhoneNumber);
            this.panel4.Controls.Add(this.txtSearchAddress);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(619, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 138);
            this.panel4.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 57);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(43, 13);
            this.lblPhoneNumber.TabIndex = 63;
            this.lblPhoneNumber.Text = "Telefon";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(3, 18);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(34, 13);
            this.lblAddress.TabIndex = 62;
            this.lblAddress.Text = "Adres";
            // 
            // btnSearchButton
            // 
            this.btnSearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchButton.Location = new System.Drawing.Point(148, 99);
            this.btnSearchButton.Name = "btnSearchButton";
            this.btnSearchButton.Size = new System.Drawing.Size(74, 23);
            this.btnSearchButton.TabIndex = 6;
            this.btnSearchButton.Text = "Szukaj";
            this.btnSearchButton.UseVisualStyleBackColor = true;
            this.btnSearchButton.Click += new System.EventHandler(this.btnSearchButton_Click);
            // 
            // txtSearchPhoneNumber
            // 
            this.txtSearchPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPhoneNumber.Location = new System.Drawing.Point(3, 73);
            this.txtSearchPhoneNumber.Name = "txtSearchPhoneNumber";
            this.txtSearchPhoneNumber.Size = new System.Drawing.Size(219, 20);
            this.txtSearchPhoneNumber.TabIndex = 5;
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchAddress.Location = new System.Drawing.Point(3, 34);
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(219, 20);
            this.txtSearchAddress.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPostCode);
            this.panel3.Controls.Add(this.lblNip);
            this.panel3.Controls.Add(this.txtSearchPostCode);
            this.panel3.Controls.Add(this.txtSearchNip);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(355, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 138);
            this.panel3.TabIndex = 2;
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(3, 57);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(75, 13);
            this.lblPostCode.TabIndex = 63;
            this.lblPostCode.Text = "Kod Pocztowy";
            // 
            // lblNip
            // 
            this.lblNip.AutoSize = true;
            this.lblNip.Location = new System.Drawing.Point(3, 18);
            this.lblNip.Name = "lblNip";
            this.lblNip.Size = new System.Drawing.Size(25, 13);
            this.lblNip.TabIndex = 62;
            this.lblNip.Text = "NIP";
            // 
            // txtSearchPostCode
            // 
            this.txtSearchPostCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPostCode.Location = new System.Drawing.Point(3, 73);
            this.txtSearchPostCode.Name = "txtSearchPostCode";
            this.txtSearchPostCode.Size = new System.Drawing.Size(220, 20);
            this.txtSearchPostCode.TabIndex = 4;
            // 
            // txtSearchNip
            // 
            this.txtSearchNip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchNip.Location = new System.Drawing.Point(3, 34);
            this.txtSearchNip.Name = "txtSearchNip";
            this.txtSearchNip.Size = new System.Drawing.Size(220, 20);
            this.txtSearchNip.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCity);
            this.panel2.Controls.Add(this.lblCompanyName);
            this.panel2.Controls.Add(this.txtSearchCity);
            this.panel2.Controls.Add(this.txtSearchCompanyName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(91, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 138);
            this.panel2.TabIndex = 1;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(3, 57);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 13);
            this.lblCity.TabIndex = 63;
            this.lblCity.Text = "Miasto";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(3, 18);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(40, 13);
            this.lblCompanyName.TabIndex = 62;
            this.lblCompanyName.Text = "Nazwa";
            // 
            // txtSearchCity
            // 
            this.txtSearchCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCity.Location = new System.Drawing.Point(3, 73);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.Size = new System.Drawing.Size(220, 20);
            this.txtSearchCity.TabIndex = 3;
            // 
            // txtSearchCompanyName
            // 
            this.txtSearchCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchCompanyName.Location = new System.Drawing.Point(3, 34);
            this.txtSearchCompanyName.Name = "txtSearchCompanyName";
            this.txtSearchCompanyName.Size = new System.Drawing.Size(220, 20);
            this.txtSearchCompanyName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSearchLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(82, 138);
            this.panel1.TabIndex = 0;
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSearchLabel.Location = new System.Drawing.Point(6, 18);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(49, 13);
            this.lblSearchLabel.TabIndex = 15;
            this.lblSearchLabel.Text = "Szukaj:";
            // 
            // bsCompanies
            // 
            this.bsCompanies.DataSource = typeof(BusinessCardHolder.Models.Company);
            // 
            // clmId
            // 
            this.clmId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmId.DataPropertyName = "Id";
            this.clmId.HeaderText = "ID";
            this.clmId.MinimumWidth = 2;
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCompanyName.DataPropertyName = "Name";
            this.clmCompanyName.HeaderText = "Nazwa";
            this.clmCompanyName.MinimumWidth = 2;
            this.clmCompanyName.Name = "clmCompanyName";
            this.clmCompanyName.ReadOnly = true;
            // 
            // clmNip
            // 
            this.clmNip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNip.DataPropertyName = "Nip";
            this.clmNip.HeaderText = "NIP";
            this.clmNip.MinimumWidth = 2;
            this.clmNip.Name = "clmNip";
            this.clmNip.ReadOnly = true;
            // 
            // clmAddress
            // 
            this.clmAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmAddress.DataPropertyName = "Address";
            this.clmAddress.HeaderText = "Adres";
            this.clmAddress.MinimumWidth = 2;
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            // 
            // clmCity
            // 
            this.clmCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCity.DataPropertyName = "City";
            this.clmCity.HeaderText = "Miasto";
            this.clmCity.MinimumWidth = 2;
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            // 
            // clmPostCode
            // 
            this.clmPostCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPostCode.DataPropertyName = "PostCode";
            this.clmPostCode.HeaderText = "Kod Pocztowy";
            this.clmPostCode.MinimumWidth = 2;
            this.clmPostCode.Name = "clmPostCode";
            this.clmPostCode.ReadOnly = true;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPhoneNumber.DataPropertyName = "PhoneNumber";
            this.clmPhoneNumber.HeaderText = "Telefon";
            this.clmPhoneNumber.MinimumWidth = 2;
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.ReadOnly = true;
            // 
            // clmNotes
            // 
            this.clmNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmNotes.DataPropertyName = "Notes";
            this.clmNotes.HeaderText = "Uwagi";
            this.clmNotes.MinimumWidth = 2;
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.ReadOnly = true;
            // 
            // CompaniesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(594, 440);
            this.Name = "CompaniesListForm";
            this.Text = "Lista firm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearchCity;
        private System.Windows.Forms.TextBox txtSearchCompanyName;
        private System.Windows.Forms.TextBox txtSearchPostCode;
        private System.Windows.Forms.TextBox txtSearchNip;
        private System.Windows.Forms.Button btnSearchButton;
        private System.Windows.Forms.TextBox txtSearchPhoneNumber;
        private System.Windows.Forms.TextBox txtSearchAddress;
        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Button btnDeleteButton;
        private System.Windows.Forms.Button btnEditButton;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.DataGridView grdCompanies;
        private System.Windows.Forms.BindingSource bsCompanies;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblNip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNip;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPostCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
    }
}