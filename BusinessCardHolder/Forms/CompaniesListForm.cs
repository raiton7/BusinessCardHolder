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

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            CompanyForm frmCompanyForm = new CompanyForm(company);
            frmCompanyForm.MdiParent = MdiParent;
            frmCompanyForm.AddButton.Enabled = false;
            frmCompanyForm.EditButton.Enabled = false;
            frmCompanyForm.DeleteButton.Enabled = false;
            frmCompanyForm.Show();
            frmCompanyForm.Text = "Szczegóły firmy - Dodaj firmę";
            frmCompanyForm.SaveButton.Click += delegate
            {
                company = frmCompanyForm.Company;
                CompanyRepository companyRepository = new CompanyRepository();
                companyRepository.Add(company);
                bsCompanies.DataSource = companyRepository.FindAll();
                bsCompanies.ResetBindings(false);
            };
        }


        private void btnEditButton_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            company = (Company)bsCompanies.Current;
            CompanyForm frmCompanyForm = new CompanyForm(company);
            frmCompanyForm.MdiParent = MdiParent;
            frmCompanyForm.Show();
            frmCompanyForm.Text = "Szczegóły firmy - Edytuj dane firmy";
            frmCompanyForm.SaveButton.Click += delegate
            {
                company = frmCompanyForm.Company;
                CompanyRepository companyRepository = new CompanyRepository();
                companyRepository.Update(company);
                bsCompanies.DataSource = companyRepository.FindAll();
                bsCompanies.ResetBindings(false);
            };
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

        private void @delegate(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            CompanyRepository companyRepository = new CompanyRepository();
            bsCompanies.DataSource = companyRepository.Search(txtSearchCompanyName.Text, txtSearchNip.Text, txtSearchAddress.Text,
                                                                txtSearchCity.Text, txtSearchPostCode.Text, txtSearchPhoneNumber.Text);
            bsCompanies.ResetBindings(false);
        }
    }
}
