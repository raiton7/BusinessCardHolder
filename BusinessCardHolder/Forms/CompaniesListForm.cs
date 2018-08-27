using System;
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
                string errorText = string.Empty;
                CompanyRepository companyRepository = new CompanyRepository();
                if (Validation.ValidateCompany(company, ref errorText))
                {
                    companyRepository.Add(company);
                    frmCompanyForm.Close();
                }
                else
                {
                    ShowErrorMessage(errorText);
                }
                bsCompanies.DataSource = companyRepository.FindAll();
                grdCompanies.Refresh();
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
                string errorText = string.Empty;
                CompanyRepository companyRepository = new CompanyRepository();
                if (Validation.ValidateCompany(company, ref errorText))
                {
                    companyRepository.Update(company);
                    frmCompanyForm.Close();
                }
                else
                {
                    ShowErrorMessage(errorText);
                }
                bsCompanies.DataSource = companyRepository.FindAll();
                grdCompanies.Refresh();

            };
            frmCompanyForm.CancelChangesButton.Click += delegate
            {
                CompanyRepository companyRepository = new CompanyRepository();
                bsCompanies.DataSource = companyRepository.FindAll();
                grdCompanies.Refresh();
            };
        }



        private void btnDeleteButton_Click(object sender, EventArgs e)
        {
            if (bsCompanies.Current is Company)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wybraną firmę?"
                    , "Potwierdzienie usunięcia"
                    , MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    CompanyRepository companyRepository = new CompanyRepository();
                    companyRepository.DeleteById(((Company)bsCompanies.Current).Id);
                    bsCompanies.DataSource = companyRepository.FindAll();
                    grdCompanies.Refresh();
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
            grdCompanies.Refresh();
        }

        private void ShowErrorMessage(string errorText)
        {
            switch (errorText)
            {
                case "name":
                    {
                        MessageBox.Show("Błędna nazwa firmy", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "nip":
                    {
                        MessageBox.Show("Błędny NIP", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "address":
                    {
                        MessageBox.Show("Błędny adres", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "city":
                    {
                        MessageBox.Show("Błędna nazwa miasta", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "postCode":
                    {
                        MessageBox.Show("Błędny kod pocztowy", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "phone":
                    {
                        MessageBox.Show("Błędny numer telefonu", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Nieznany błąd", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
            }
        }
    }
}
