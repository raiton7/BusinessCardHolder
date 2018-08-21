namespace BusinessCardHolder.Forms
{
    partial class CompanyForm
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSaveButton = new System.Windows.Forms.Button();
            this.btnCancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblEmployeesListLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMobilePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteButton = new System.Windows.Forms.Button();
            this.btnEditButton = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotesLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPhoneNumberLabel = new System.Windows.Forms.Label();
            this.lblPostCodeLabel = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblCityLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblNipLabel = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNip = new System.Windows.Forms.TextBox();
            this.lblCompanyNameLabel = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSaveButton);
            this.panel6.Controls.Add(this.btnCancelButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 471);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(756, 34);
            this.panel6.TabIndex = 2;
            // 
            // btnSaveButton
            // 
            this.btnSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveButton.Location = new System.Drawing.Point(668, 8);
            this.btnSaveButton.Name = "btnSaveButton";
            this.btnSaveButton.Size = new System.Drawing.Size(75, 23);
            this.btnSaveButton.TabIndex = 59;
            this.btnSaveButton.Text = "Zapisz";
            this.btnSaveButton.UseVisualStyleBackColor = true;
            this.btnSaveButton.Click += new System.EventHandler(this.btnSaveButton_Click);
            // 
            // btnCancelButton
            // 
            this.btnCancelButton.Location = new System.Drawing.Point(9, 8);
            this.btnCancelButton.Name = "btnCancelButton";
            this.btnCancelButton.Size = new System.Drawing.Size(75, 23);
            this.btnCancelButton.TabIndex = 58;
            this.btnCancelButton.Text = "Anuluj";
            this.btnCancelButton.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 508);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblEmployeesListLabel);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Controls.Add(this.btnDeleteButton);
            this.panel5.Controls.Add(this.btnEditButton);
            this.panel5.Controls.Add(this.btnAddButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 153);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(756, 312);
            this.panel5.TabIndex = 1;
            // 
            // lblEmployeesListLabel
            // 
            this.lblEmployeesListLabel.AutoSize = true;
            this.lblEmployeesListLabel.Location = new System.Drawing.Point(6, 9);
            this.lblEmployeesListLabel.Name = "lblEmployeesListLabel";
            this.lblEmployeesListLabel.Size = new System.Drawing.Size(55, 13);
            this.lblEmployeesListLabel.TabIndex = 61;
            this.lblEmployeesListLabel.Text = "Lista osób";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmLastName,
            this.clmCompanyName,
            this.clmJobTitle,
            this.clmPhoneNumber,
            this.clmMobilePhoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(10, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 229);
            this.dataGridView1.TabIndex = 60;
            // 
            // clmFirstName
            // 
            this.clmFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmFirstName.HeaderText = "Imię";
            this.clmFirstName.MinimumWidth = 100;
            this.clmFirstName.Name = "clmFirstName";
            // 
            // clmLastName
            // 
            this.clmLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLastName.HeaderText = "Nazwisko";
            this.clmLastName.MinimumWidth = 130;
            this.clmLastName.Name = "clmLastName";
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmCompanyName.HeaderText = "Firma";
            this.clmCompanyName.MinimumWidth = 120;
            this.clmCompanyName.Name = "clmCompanyName";
            // 
            // clmJobTitle
            // 
            this.clmJobTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmJobTitle.HeaderText = "Stanowisko";
            this.clmJobTitle.MinimumWidth = 180;
            this.clmJobTitle.Name = "clmJobTitle";
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmPhoneNumber.HeaderText = "Nr Telefonu";
            this.clmPhoneNumber.MinimumWidth = 80;
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            // 
            // clmMobilePhoneNumber
            // 
            this.clmMobilePhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmMobilePhoneNumber.HeaderText = "Nr Telefonu Komórkowego";
            this.clmMobilePhoneNumber.MinimumWidth = 80;
            this.clmMobilePhoneNumber.Name = "clmMobilePhoneNumber";
            // 
            // btnDeleteButton
            // 
            this.btnDeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteButton.Location = new System.Drawing.Point(171, 260);
            this.btnDeleteButton.Name = "btnDeleteButton";
            this.btnDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteButton.TabIndex = 59;
            this.btnDeleteButton.Text = "Usuń";
            this.btnDeleteButton.UseVisualStyleBackColor = true;
            // 
            // btnEditButton
            // 
            this.btnEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditButton.Location = new System.Drawing.Point(90, 260);
            this.btnEditButton.Name = "btnEditButton";
            this.btnEditButton.Size = new System.Drawing.Size(75, 23);
            this.btnEditButton.TabIndex = 58;
            this.btnEditButton.Text = "Edytuj";
            this.btnEditButton.UseVisualStyleBackColor = true;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddButton.Location = new System.Drawing.Point(9, 260);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(75, 23);
            this.btnAddButton.TabIndex = 57;
            this.btnAddButton.Text = "Dodaj";
            this.btnAddButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(756, 144);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNotes);
            this.panel3.Controls.Add(this.lblNotesLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(507, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 138);
            this.panel3.TabIndex = 2;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(6, 19);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(179, 49);
            this.txtNotes.TabIndex = 56;
            // 
            // lblNotesLabel
            // 
            this.lblNotesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotesLabel.AutoSize = true;
            this.lblNotesLabel.Location = new System.Drawing.Point(3, 3);
            this.lblNotesLabel.Name = "lblNotesLabel";
            this.lblNotesLabel.Size = new System.Drawing.Size(37, 13);
            this.lblNotesLabel.TabIndex = 55;
            this.lblNotesLabel.Text = "Uwagi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPhoneNumberLabel);
            this.panel2.Controls.Add(this.lblPostCodeLabel);
            this.panel2.Controls.Add(this.txtCity);
            this.panel2.Controls.Add(this.txtPhoneNumber);
            this.panel2.Controls.Add(this.txtPostCode);
            this.panel2.Controls.Add(this.lblCityLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(255, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 138);
            this.panel2.TabIndex = 1;
            // 
            // lblPhoneNumberLabel
            // 
            this.lblPhoneNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneNumberLabel.AutoSize = true;
            this.lblPhoneNumberLabel.Location = new System.Drawing.Point(4, 55);
            this.lblPhoneNumberLabel.Name = "lblPhoneNumberLabel";
            this.lblPhoneNumberLabel.Size = new System.Drawing.Size(63, 13);
            this.lblPhoneNumberLabel.TabIndex = 58;
            this.lblPhoneNumberLabel.Text = "Nr Telefonu";
            // 
            // lblPostCodeLabel
            // 
            this.lblPostCodeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostCodeLabel.AutoSize = true;
            this.lblPostCodeLabel.Location = new System.Drawing.Point(3, 29);
            this.lblPostCodeLabel.Name = "lblPostCodeLabel";
            this.lblPostCodeLabel.Size = new System.Drawing.Size(75, 13);
            this.lblPostCodeLabel.TabIndex = 57;
            this.lblPostCodeLabel.Text = "Kod Pocztowy";
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.Location = new System.Drawing.Point(84, 0);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 20);
            this.txtCity.TabIndex = 56;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(84, 52);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(151, 20);
            this.txtPhoneNumber.TabIndex = 55;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostCode.Location = new System.Drawing.Point(84, 26);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(151, 20);
            this.txtPostCode.TabIndex = 54;
            // 
            // lblCityLabel
            // 
            this.lblCityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCityLabel.AutoSize = true;
            this.lblCityLabel.Location = new System.Drawing.Point(3, 3);
            this.lblCityLabel.Name = "lblCityLabel";
            this.lblCityLabel.Size = new System.Drawing.Size(38, 13);
            this.lblCityLabel.TabIndex = 53;
            this.lblCityLabel.Text = "Miasto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAddressLabel);
            this.panel1.Controls.Add(this.lblNipLabel);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtNip);
            this.panel1.Controls.Add(this.lblCompanyNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 138);
            this.panel1.TabIndex = 0;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Location = new System.Drawing.Point(4, 55);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(34, 13);
            this.lblAddressLabel.TabIndex = 52;
            this.lblAddressLabel.Text = "Adres";
            // 
            // lblNipLabel
            // 
            this.lblNipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNipLabel.AutoSize = true;
            this.lblNipLabel.Location = new System.Drawing.Point(3, 29);
            this.lblNipLabel.Name = "lblNipLabel";
            this.lblNipLabel.Size = new System.Drawing.Size(25, 13);
            this.lblNipLabel.TabIndex = 51;
            this.lblNipLabel.Text = "NIP";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Location = new System.Drawing.Point(49, 0);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(151, 20);
            this.txtCompanyName.TabIndex = 50;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(49, 52);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 20);
            this.txtAddress.TabIndex = 49;
            // 
            // txtNip
            // 
            this.txtNip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNip.Location = new System.Drawing.Point(49, 26);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(151, 20);
            this.txtNip.TabIndex = 48;
            // 
            // lblCompanyNameLabel
            // 
            this.lblCompanyNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompanyNameLabel.AutoSize = true;
            this.lblCompanyNameLabel.Location = new System.Drawing.Point(3, 3);
            this.lblCompanyNameLabel.Name = "lblCompanyNameLabel";
            this.lblCompanyNameLabel.Size = new System.Drawing.Size(40, 13);
            this.lblCompanyNameLabel.TabIndex = 47;
            this.lblCompanyNameLabel.Text = "Nazwa";
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(778, 547);
            this.Name = "CompanyForm";
            this.Text = "Szczegóły firmy";
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblNipLabel;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNip;
        private System.Windows.Forms.Label lblCompanyNameLabel;
        private System.Windows.Forms.Label lblPhoneNumberLabel;
        private System.Windows.Forms.Label lblPostCodeLabel;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblCityLabel;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotesLabel;
        private System.Windows.Forms.Label lblEmployeesListLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteButton;
        private System.Windows.Forms.Button btnEditButton;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Button btnSaveButton;
        private System.Windows.Forms.Button btnCancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMobilePhoneNumber;
    }
}