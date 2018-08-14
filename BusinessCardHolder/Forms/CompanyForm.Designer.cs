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
            this.btnCancelButton = new System.Windows.Forms.Button();
            this.btnDeleteButton = new System.Windows.Forms.Button();
            this.btnEditButton = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtNip = new System.Windows.Forms.TextBox();
            this.lblCompanyNameLabel = new System.Windows.Forms.Label();
            this.lblNipLabel = new System.Windows.Forms.Label();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblPhoneNumberLabel = new System.Windows.Forms.Label();
            this.lblPostCodeLabel = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.lblCityLabel = new System.Windows.Forms.Label();
            this.lblNotesLabel = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMobilePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmployeesListLabel = new System.Windows.Forms.Label();
            this.btnSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelButton
            // 
            this.btnCancelButton.Location = new System.Drawing.Point(12, 473);
            this.btnCancelButton.Name = "btnCancelButton";
            this.btnCancelButton.Size = new System.Drawing.Size(75, 23);
            this.btnCancelButton.TabIndex = 23;
            this.btnCancelButton.Text = "Anuluj";
            this.btnCancelButton.UseVisualStyleBackColor = true;
            // 
            // btnDeleteButton
            // 
            this.btnDeleteButton.Location = new System.Drawing.Point(177, 391);
            this.btnDeleteButton.Name = "btnDeleteButton";
            this.btnDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteButton.TabIndex = 22;
            this.btnDeleteButton.Text = "Usuń";
            this.btnDeleteButton.UseVisualStyleBackColor = true;
            // 
            // btnEditButton
            // 
            this.btnEditButton.Location = new System.Drawing.Point(96, 391);
            this.btnEditButton.Name = "btnEditButton";
            this.btnEditButton.Size = new System.Drawing.Size(75, 23);
            this.btnEditButton.TabIndex = 21;
            this.btnEditButton.Text = "Edytuj";
            this.btnEditButton.UseVisualStyleBackColor = true;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(15, 391);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(75, 23);
            this.btnAddButton.TabIndex = 20;
            this.btnAddButton.Text = "Dodaj";
            this.btnAddButton.UseVisualStyleBackColor = true;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(58, 27);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(150, 20);
            this.txtCompanyName.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(58, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 20);
            this.txtAddress.TabIndex = 15;
            // 
            // txtNip
            // 
            this.txtNip.Location = new System.Drawing.Point(58, 53);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(150, 20);
            this.txtNip.TabIndex = 14;
            // 
            // lblCompanyNameLabel
            // 
            this.lblCompanyNameLabel.AutoSize = true;
            this.lblCompanyNameLabel.Location = new System.Drawing.Point(12, 30);
            this.lblCompanyNameLabel.Name = "lblCompanyNameLabel";
            this.lblCompanyNameLabel.Size = new System.Drawing.Size(40, 13);
            this.lblCompanyNameLabel.TabIndex = 13;
            this.lblCompanyNameLabel.Text = "Nazwa";
            // 
            // lblNipLabel
            // 
            this.lblNipLabel.AutoSize = true;
            this.lblNipLabel.Location = new System.Drawing.Point(12, 56);
            this.lblNipLabel.Name = "lblNipLabel";
            this.lblNipLabel.Size = new System.Drawing.Size(25, 13);
            this.lblNipLabel.TabIndex = 24;
            this.lblNipLabel.Text = "NIP";
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Location = new System.Drawing.Point(13, 82);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(34, 13);
            this.lblAddressLabel.TabIndex = 25;
            this.lblAddressLabel.Text = "Adres";
            // 
            // lblPhoneNumberLabel
            // 
            this.lblPhoneNumberLabel.AutoSize = true;
            this.lblPhoneNumberLabel.Location = new System.Drawing.Point(244, 82);
            this.lblPhoneNumberLabel.Name = "lblPhoneNumberLabel";
            this.lblPhoneNumberLabel.Size = new System.Drawing.Size(63, 13);
            this.lblPhoneNumberLabel.TabIndex = 31;
            this.lblPhoneNumberLabel.Text = "Nr Telefonu";
            // 
            // lblPostCodeLabel
            // 
            this.lblPostCodeLabel.AutoSize = true;
            this.lblPostCodeLabel.Location = new System.Drawing.Point(243, 56);
            this.lblPostCodeLabel.Name = "lblPostCodeLabel";
            this.lblPostCodeLabel.Size = new System.Drawing.Size(75, 13);
            this.lblPostCodeLabel.TabIndex = 30;
            this.lblPostCodeLabel.Text = "Kod Pocztowy";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(324, 27);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 29;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(324, 79);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.txtPhoneNumber.TabIndex = 28;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(324, 53);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(150, 20);
            this.txtPostCode.TabIndex = 27;
            // 
            // lblCityLabel
            // 
            this.lblCityLabel.AutoSize = true;
            this.lblCityLabel.Location = new System.Drawing.Point(243, 30);
            this.lblCityLabel.Name = "lblCityLabel";
            this.lblCityLabel.Size = new System.Drawing.Size(38, 13);
            this.lblCityLabel.TabIndex = 26;
            this.lblCityLabel.Text = "Miasto";
            // 
            // lblNotesLabel
            // 
            this.lblNotesLabel.AutoSize = true;
            this.lblNotesLabel.Location = new System.Drawing.Point(565, 30);
            this.lblNotesLabel.Name = "lblNotesLabel";
            this.lblNotesLabel.Size = new System.Drawing.Size(37, 13);
            this.lblNotesLabel.TabIndex = 32;
            this.lblNotesLabel.Text = "Uwagi";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(568, 46);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(181, 49);
            this.txtNotes.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFirstName,
            this.clmLastName,
            this.clmCompanyName,
            this.clmJobTitle,
            this.clmPhoneNumber,
            this.clmMobilePhoneNumber});
            this.dataGridView1.Location = new System.Drawing.Point(16, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 229);
            this.dataGridView1.TabIndex = 34;
            // 
            // clmFirstName
            // 
            this.clmFirstName.HeaderText = "Imię";
            this.clmFirstName.Name = "clmFirstName";
            // 
            // clmLastName
            // 
            this.clmLastName.HeaderText = "Nazwisko";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.Width = 130;
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.HeaderText = "Firma";
            this.clmCompanyName.Name = "clmCompanyName";
            this.clmCompanyName.Width = 120;
            // 
            // clmJobTitle
            // 
            this.clmJobTitle.HeaderText = "Stanowisko";
            this.clmJobTitle.Name = "clmJobTitle";
            this.clmJobTitle.Width = 180;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.HeaderText = "Nr Telefonu";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            this.clmPhoneNumber.Width = 80;
            // 
            // clmMobilePhoneNumber
            // 
            this.clmMobilePhoneNumber.HeaderText = "Nr Telefonu Komórkowego";
            this.clmMobilePhoneNumber.Name = "clmMobilePhoneNumber";
            this.clmMobilePhoneNumber.Width = 80;
            // 
            // lblEmployeesListLabel
            // 
            this.lblEmployeesListLabel.AutoSize = true;
            this.lblEmployeesListLabel.Location = new System.Drawing.Point(12, 140);
            this.lblEmployeesListLabel.Name = "lblEmployeesListLabel";
            this.lblEmployeesListLabel.Size = new System.Drawing.Size(55, 13);
            this.lblEmployeesListLabel.TabIndex = 35;
            this.lblEmployeesListLabel.Text = "Lista osób";
            // 
            // btnSaveButton
            // 
            this.btnSaveButton.Location = new System.Drawing.Point(673, 473);
            this.btnSaveButton.Name = "btnSaveButton";
            this.btnSaveButton.Size = new System.Drawing.Size(75, 23);
            this.btnSaveButton.TabIndex = 36;
            this.btnSaveButton.Text = "Zapisz";
            this.btnSaveButton.UseVisualStyleBackColor = true;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 508);
            this.Controls.Add(this.btnSaveButton);
            this.Controls.Add(this.lblEmployeesListLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotesLabel);
            this.Controls.Add(this.lblPhoneNumberLabel);
            this.Controls.Add(this.lblPostCodeLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.lblCityLabel);
            this.Controls.Add(this.lblAddressLabel);
            this.Controls.Add(this.lblNipLabel);
            this.Controls.Add(this.btnCancelButton);
            this.Controls.Add(this.btnDeleteButton);
            this.Controls.Add(this.btnEditButton);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNip);
            this.Controls.Add(this.lblCompanyNameLabel);
            this.MinimumSize = new System.Drawing.Size(778, 547);
            this.Name = "CompanyForm";
            this.Text = "Szczegóły firmy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelButton;
        private System.Windows.Forms.Button btnDeleteButton;
        private System.Windows.Forms.Button btnEditButton;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNip;
        private System.Windows.Forms.Label lblCompanyNameLabel;
        private System.Windows.Forms.Label lblNipLabel;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblPhoneNumberLabel;
        private System.Windows.Forms.Label lblPostCodeLabel;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.Label lblCityLabel;
        private System.Windows.Forms.Label lblNotesLabel;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMobilePhoneNumber;
        private System.Windows.Forms.Label lblEmployeesListLabel;
        private System.Windows.Forms.Button btnSaveButton;
    }
}