namespace BusinessCardHolder
{
    partial class BusinessCardHolderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlsCompaniesList = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsEmployeesList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsCompaniesList,
            this.tlsEmployeesList});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlsCompaniesList
            // 
            this.tlsCompaniesList.Name = "tlsCompaniesList";
            this.tlsCompaniesList.Size = new System.Drawing.Size(68, 20);
            this.tlsCompaniesList.Text = "Lista firm";
            this.tlsCompaniesList.Click += new System.EventHandler(this.tlsCompaniesList_Click);
            // 
            // tlsEmployeesList
            // 
            this.tlsEmployeesList.Name = "tlsEmployeesList";
            this.tlsEmployeesList.Size = new System.Drawing.Size(72, 20);
            this.tlsEmployeesList.Text = "Lista osób";
            this.tlsEmployeesList.Click += new System.EventHandler(this.tlsEmployeesList_Click);
            // 
            // BusinessCardHolderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BusinessCardHolderForm";
            this.Text = "Wizytownik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlsCompaniesList;
        private System.Windows.Forms.ToolStripMenuItem tlsEmployeesList;
    }
}

