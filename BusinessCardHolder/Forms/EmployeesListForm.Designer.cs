namespace BusinessCardHolder.Forms
{
    partial class EmployeesListForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMobilePhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackButton = new System.Windows.Forms.Button();
            this.btnDeleteButton = new System.Windows.Forms.Button();
            this.btnEditButton = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.btnSearchButton = new System.Windows.Forms.Button();
            this.txtSearchPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSearchMobilePhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSearchJobTitle = new System.Windows.Forms.TextBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.txtSearchCompanyName = new System.Windows.Forms.TextBox();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 229);
            this.dataGridView1.TabIndex = 40;
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
            // btnBackButton
            // 
            this.btnBackButton.Location = new System.Drawing.Point(12, 457);
            this.btnBackButton.Name = "btnBackButton";
            this.btnBackButton.Size = new System.Drawing.Size(75, 23);
            this.btnBackButton.TabIndex = 39;
            this.btnBackButton.Text = "Wróć";
            this.btnBackButton.UseVisualStyleBackColor = true;
            // 
            // btnDeleteButton
            // 
            this.btnDeleteButton.Location = new System.Drawing.Point(173, 377);
            this.btnDeleteButton.Name = "btnDeleteButton";
            this.btnDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteButton.TabIndex = 38;
            this.btnDeleteButton.Text = "Usuń";
            this.btnDeleteButton.UseVisualStyleBackColor = true;
            // 
            // btnEditButton
            // 
            this.btnEditButton.Location = new System.Drawing.Point(92, 377);
            this.btnEditButton.Name = "btnEditButton";
            this.btnEditButton.Size = new System.Drawing.Size(75, 23);
            this.btnEditButton.TabIndex = 37;
            this.btnEditButton.Text = "Edytuj";
            this.btnEditButton.UseVisualStyleBackColor = true;
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(11, 377);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(75, 23);
            this.btnAddButton.TabIndex = 36;
            this.btnAddButton.Text = "Dodaj";
            this.btnAddButton.UseVisualStyleBackColor = true;
            // 
            // btnSearchButton
            // 
            this.btnSearchButton.Location = new System.Drawing.Point(616, 82);
            this.btnSearchButton.Name = "btnSearchButton";
            this.btnSearchButton.Size = new System.Drawing.Size(75, 23);
            this.btnSearchButton.TabIndex = 48;
            this.btnSearchButton.Text = "Szukaj";
            this.btnSearchButton.UseVisualStyleBackColor = true;
            // 
            // txtSearchPhoneNumber
            // 
            this.txtSearchPhoneNumber.Location = new System.Drawing.Point(329, 56);
            this.txtSearchPhoneNumber.Name = "txtSearchPhoneNumber";
            this.txtSearchPhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.txtSearchPhoneNumber.TabIndex = 47;
            this.txtSearchPhoneNumber.Text = "Nr Telefonu";
            // 
            // txtSearchMobilePhoneNumber
            // 
            this.txtSearchMobilePhoneNumber.Location = new System.Drawing.Point(541, 56);
            this.txtSearchMobilePhoneNumber.Name = "txtSearchMobilePhoneNumber";
            this.txtSearchMobilePhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.txtSearchMobilePhoneNumber.TabIndex = 46;
            this.txtSearchMobilePhoneNumber.Text = "Nr Tel. Komórkowego";
            // 
            // txtSearchJobTitle
            // 
            this.txtSearchJobTitle.Location = new System.Drawing.Point(117, 56);
            this.txtSearchJobTitle.Name = "txtSearchJobTitle";
            this.txtSearchJobTitle.Size = new System.Drawing.Size(150, 20);
            this.txtSearchJobTitle.TabIndex = 45;
            this.txtSearchJobTitle.Text = "Stanowisko";
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(117, 30);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtSearchFirstName.TabIndex = 44;
            this.txtSearchFirstName.Text = "Imię";
            // 
            // txtSearchCompanyName
            // 
            this.txtSearchCompanyName.Location = new System.Drawing.Point(541, 30);
            this.txtSearchCompanyName.Name = "txtSearchCompanyName";
            this.txtSearchCompanyName.Size = new System.Drawing.Size(150, 20);
            this.txtSearchCompanyName.TabIndex = 43;
            this.txtSearchCompanyName.Text = "Firma";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(329, 30);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(150, 20);
            this.txtSearchLastName.TabIndex = 42;
            this.txtSearchLastName.Text = "Nazwisko";
            // 
            // lblSearchLabel
            // 
            this.lblSearchLabel.AutoSize = true;
            this.lblSearchLabel.Location = new System.Drawing.Point(9, 33);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(42, 13);
            this.lblSearchLabel.TabIndex = 41;
            this.lblSearchLabel.Text = "Szukaj:";
            // 
            // EmployeesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 492);
            this.Controls.Add(this.btnSearchButton);
            this.Controls.Add(this.txtSearchPhoneNumber);
            this.Controls.Add(this.txtSearchMobilePhoneNumber);
            this.Controls.Add(this.txtSearchJobTitle);
            this.Controls.Add(this.txtSearchFirstName);
            this.Controls.Add(this.txtSearchCompanyName);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.lblSearchLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBackButton);
            this.Controls.Add(this.btnDeleteButton);
            this.Controls.Add(this.btnEditButton);
            this.Controls.Add(this.btnAddButton);
            this.MinimumSize = new System.Drawing.Size(775, 531);
            this.Name = "EmployeesListForm";
            this.Text = "Lista osób";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMobilePhoneNumber;
        private System.Windows.Forms.Button btnBackButton;
        private System.Windows.Forms.Button btnDeleteButton;
        private System.Windows.Forms.Button btnEditButton;
        private System.Windows.Forms.Button btnAddButton;
        private System.Windows.Forms.Button btnSearchButton;
        private System.Windows.Forms.TextBox txtSearchPhoneNumber;
        private System.Windows.Forms.TextBox txtSearchMobilePhoneNumber;
        private System.Windows.Forms.TextBox txtSearchJobTitle;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.TextBox txtSearchCompanyName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Label lblSearchLabel;
    }
}