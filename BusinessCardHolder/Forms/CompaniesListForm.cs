using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCardHolder.DataBase;
using BusinessCardHolder.Models;

namespace BusinessCardHolder.Forms
{
    public partial class CompaniesListForm : Form
    {
        public CompaniesListForm()
        {
            InitializeComponent();
            
            CompanyRepository companyRepository = new CompanyRepository();
            bsCompanies.DataSource = companyRepository.FindAll();
            grdCompanies.AutoGenerateColumns = false;
            grdCompanies.DataSource = bsCompanies;
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteButton_Click(object sender, EventArgs e)
        {
            if (bsCompanies.Current is Company)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wybraną firmę?", "Potwierdzienie usunięcia", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    CompanyRepository companyRepository = new CompanyRepository();
                    companyRepository.DeleteById(((Company)bsCompanies.Current).Id);
                    bsCompanies.DataSource = companyRepository.FindAll();
                    bsCompanies.ResetBindings(false);
                }
            }
        }

        private CompanyForm frmCompanyForm;
        private void btnAddButton_Click(object sender, EventArgs e)
        {
            if (frmCompanyForm != null)
            {
                frmCompanyForm = new CompanyForm();
                frmCompanyForm.MdiParent = MdiParent;
                frmCompanyForm.FormClosed += new FormClosedEventHandler(frmCompanyForm_FormClosed);
                frmCompanyForm.Show();
            }
            else
            {
                frmCompanyForm.Activate();
            }
        }

        private void frmCompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCompanyForm = null;
        }
    }
}
