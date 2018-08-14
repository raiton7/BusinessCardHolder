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
            this.grdCompanies = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPostCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.txtSearchNip = new System.Windows.Forms.TextBox();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            this.txtSearchCompanyName = new System.Windows.Forms.TextBox();
            this.txtSearchCity = new System.Windows.Forms.TextBox();
            this.txtSearchPostCode = new System.Windows.Forms.TextBox();
            this.txtSearchPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSearchButton = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.btnEditButton = new System.Windows.Forms.Button();
            this.btnDeleteButton = new System.Windows.Forms.Button();
            this.btnBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCompanies
            // 
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
            this.grdCompanies.Location = new System.Drawing.Point(12, 127);
            this.grdCompanies.Name = "grdCompanies";
            this.grdCompanies.Size = new System.Drawing.Size(864, 250);
            this.grdCompanies.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.HeaderText = "ID";
            this.clmId.Name = "clmId";
            this.clmId.Width = 35;
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.HeaderText = "Nazwa";
            this.clmCompanyName.Name = "clmCompanyName";
            this.clmCompanyName.Width = 120;
            // 
            // clmNip
            // 
            this.clmNip.HeaderText = "NIP";
            this.clmNip.Name = "clmNip";
            this.clmNip.Width = 80;
            // 
            // clmAddress
            // 
            this.clmAddress.HeaderText = "Adres";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.Width = 175;
            // 
            // clmCity
            // 
            this.clmCity.HeaderText = "Miasto";
            this.clmCity.Name = "clmCity";
            // 
            // clmPostCode
            // 
            this.clmPostCode.HeaderText = "Kod Pocztowy";
            this.clmPostCode.Name = "clmPostCode";
            this.clmPostCode.Width = 60;
            // 
            // clmPhoneNumber
            // 
            this.clmPhoneNumber.HeaderText = "Telefon";
            this.clmPhoneNumber.Name = "clmPhoneNumber";
            // 
            // clmNotes
            // 
            this.clmNotes.HeaderText = "Uwagi";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.Width = 150;
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Location = new System.Drawing.Point(9, 22);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(42, 13);
            this.lblSearchLabel.TabIndex = 1;
            this.lblSearchLabel.Text = "Szukaj:";
            // 
            // txtSearchNip
            // 
            this.txtSearchNip.Location = new System.Drawing.Point(371, 19);
            this.txtSearchNip.Name = "txtSearchNip";
            this.txtSearchNip.Size = new System.Drawing.Size(150, 20);
            this.txtSearchNip.TabIndex = 2;
            this.txtSearchNip.Text = "NIP";
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Location = new System.Drawing.Point(583, 19);
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(150, 20);
            this.txtSearchAddress.TabIndex = 3;
            this.txtSearchAddress.Text = "Adres";
            // 
            // txtSearchCompanyName
            // 
            this.txtSearchCompanyName.Location = new System.Drawing.Point(159, 19);
            this.txtSearchCompanyName.Name = "txtSearchCompanyName";
            this.txtSearchCompanyName.Size = new System.Drawing.Size(150, 20);
            this.txtSearchCompanyName.TabIndex = 4;
            this.txtSearchCompanyName.Text = "Nazwa";
            // 
            // txtSearchCity
            // 
            this.txtSearchCity.Location = new System.Drawing.Point(159, 45);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.Size = new System.Drawing.Size(150, 20);
            this.txtSearchCity.TabIndex = 5;
            this.txtSearchCity.Text = "Miasto";
            // 
            // txtSearchPostCode
            // 
            this.txtSearchPostCode.Location = new System.Drawing.Point(371, 45);
            this.txtSearchPostCode.Name = "txtSearchPostCode";
            this.txtSearchPostCode.Size = new System.Drawing.Size(150, 20);
            this.txtSearchPostCode.TabIndex = 6;
            this.txtSearchPostCode.Text = "Kod pocztowy";
            // 
            // txtSearchPhoneNumber
            // 
            this.txtSearchPhoneNumber.Location = new System.Drawing.Point(583, 45);
            this.txtSearchPhoneNumber.Name = "txtSearchPhoneNumber";
            this.txtSearchPhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.txtSearchPhoneNumber.TabIndex = 7;
            this.txtSearchPhoneNumber.Text = "Telefon";
            // 
            // btnSearchButton
            // 
            this.btnSearchButton.Location = new System.Drawing.Point(658, 71);
            this.btnSearchButton.Name = "btnSearchButton";
            this.btnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.btnSearchButton.TabIndex = 8;
            this.btnSearchButton.Text = "Szukaj";
            this.btnSearchButton.UseVisualStyleBackColor = true;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(13, 384);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(75, 23);
            this.btnAddButton.TabIndex = 9;
            this.btnAddButton.Text = "Dodaj";
            this.btnAddButton.UseVisualStyleBackColor = true;
            // 
            // btnEditButton
            // 
            this.btnEditButton.Location = new System.Drawing.Point(94, 384);
            this.btnEditButton.Name = "btnEditButton";
            this.btnEditButton.Size = new System.Drawing.Size(75, 23);
            this.btnEditButton.TabIndex = 10;
            this.btnEditButton.Text = "Edytuj";
            this.btnEditButton.UseVisualStyleBackColor = true;
            // 
            // btnDeleteButton
            // 
            this.btnDeleteButton.Location = new System.Drawing.Point(175, 384);
            this.btnDeleteButton.Name = "btnDeleteButton";
            this.btnDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteButton.TabIndex = 11;
            this.btnDeleteButton.Text = "Usuń";
            this.btnDeleteButton.UseVisualStyleBackColor = true;
            // 
            // btnBackButton
            // 
            this.btnBackButton.Location = new System.Drawing.Point(12, 465);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(75, 23);
            this.btnBackButton.TabIndex = 12;
            this.btnBackButton.Text = "Wróć";
            this.btnBackButton.UseVisualStyleBackColor = true;
            // 
            // CompaniesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 500);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.btnDeleteButton);
            this.Controls.Add(this.btnEditButton);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.btnSearchButton);
            this.Controls.Add(this.txtSearchPhoneNumber);
            this.Controls.Add(this.txtSearchPostCode);
            this.Controls.Add(this.txtSearchCity);
            this.Controls.Add(this.txtSearchCompanyName);
            this.Controls.Add(this.txtSearchAddress);
            this.Controls.Add(this.txtSearchNip);
            this.Controls.Add(this.lblSearchLabel);
            this.Controls.Add(this.grdCompanies);
            this.MinimumSize = new System.Drawing.Size(904, 539);
            this.Name = "CompaniesListForm";
            this.Text = "Lista firm";
            ((System.ComponentModel.ISupportInitialize)(this.grdCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCompanies;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearchNip;
        private System.Windows.Forms.TextBox txtSearchAddress;
        private System.Windows.Forms.TextBox txtSearchCompanyName;
        private System.Windows.Forms.TextBox txtSearchCity;
        private System.Windows.Forms.TextBox txtSearchPostCode;
        private System.Windows.Forms.TextBox txtSearchPhoneNumber;
        private System.Windows.Forms.Button btnSearchButton;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Button btnEditButton;
        private System.Windows.Forms.Button btnDeleteButton;
        private System.Windows.Forms.Button btnBackButton;
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