using BusinessCardHolder.DataBase;
using BusinessCardHolder.Models;
using System;
using System.Windows.Forms;

namespace BusinessCardHolder.Forms
{
    public partial class CompanyForm : Form
    {
        public Company Company { get; set; }
        public Button SaveButton { get { return btnSaveButton; } } 
        public Button CancelChangesButton { get { return btnCancelButton; } }
        public Button AddButton { get { return btnAddButton; } }
        public Button EditButton { get { return btnEditButton; } }
        public Button DeleteButton { get { return btnDeleteButton; } }

        public CompanyForm(Company company)
        {
            InitializeComponent();
            Company = company;
            bsCompany.DataSource = Company;
            grdEmployees.AutoGenerateColumns = false;
            EmployeeRepository employeeRepository = new EmployeeRepository();
            bsEmployees.DataSource = employeeRepository.FindByCompanyId(company.Id);
            grdEmployees.DataSource = bsEmployees;
        }

        private void btnSaveButton_Click(object sender, EventArgs e)
        {
            Company = (Company)bsCompany.Current;
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            EmployeeForm frmEmployeeForm = new EmployeeForm(employee, Company);
            frmEmployeeForm.MdiParent = MdiParent;
            frmEmployeeForm.CompanyComboBox.Enabled = false;
            frmEmployeeForm.Show();
            frmEmployeeForm.SaveButton.Click += delegate
            {
                employee = frmEmployeeForm.Employee;
                string errorText = string.Empty;
                EmployeeRepository employeeRepository = new EmployeeRepository();
                if (Validation.ValidateEmployee(employee, ref errorText))
                {
                    employeeRepository.Add(employee);
                    frmEmployeeForm.Close();
                }
                else
                {
                    ShowErrorMessage(errorText);
                }
                bsEmployees.DataSource = employeeRepository.FindByCompanyId(Company.Id);
                grdEmployees.DataSource = bsEmployees;
                grdEmployees.Refresh();
            };
        }


        private void btnEditButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee = (Employee)bsEmployees.Current;
            EmployeeForm frmEmployeeForm = new EmployeeForm(employee, Company);
            frmEmployeeForm.MdiParent = MdiParent;
            frmEmployeeForm.CompanyComboBox.Enabled = false;
            frmEmployeeForm.Show();
            frmEmployeeForm.SaveButton.Click += delegate
            {
                employee = frmEmployeeForm.Employee;
                EmployeeRepository employeeRepository = new EmployeeRepository();
                string errorText = string.Empty;
                if (Validation.ValidateEmployee(employee, ref errorText))
                {
                    employeeRepository.Update(employee);
                    frmEmployeeForm.Close();
                }
                else
                {
                    ShowErrorMessage(errorText);
                }
                bsEmployees.DataSource = employeeRepository.FindByCompanyId(Company.Id);
                grdEmployees.DataSource = bsEmployees;
                grdEmployees.Refresh();
            };
            frmEmployeeForm.CancelChangesButton.Click += delegate
            {
                EmployeeRepository employeeRepository = new EmployeeRepository();
                bsEmployees.DataSource = employeeRepository.FindByCompanyId(Company.Id);
                grdEmployees.DataSource = bsEmployees;
                grdEmployees.Refresh();
            };
        }

        private void btnDeleteButton_Click(object sender, EventArgs e)
        {
            if (bsEmployees.Current is Employee)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wybraną osobę?", "Potwierdzenie usunięcia", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    EmployeeRepository employeeRepository = new EmployeeRepository();
                    employeeRepository.DeleteById(((Employee)bsEmployees.Current).Id);
                    bsEmployees.DataSource = employeeRepository.FindByCompanyId(Company.Id);
                    grdEmployees.DataSource = bsEmployees;
                    grdEmployees.Refresh();
                }
            }
        }

        private void @delegate(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowErrorMessage(string errorText)
        {
            switch (errorText)
            {
                case "firstName":
                    {
                        MessageBox.Show("Błędne imię", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "lastName":
                    {
                        MessageBox.Show("Błędne nazwisko", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "jobTitle":
                    {
                        MessageBox.Show("Błędna nazwa stanowiska", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "phone":
                    {
                        MessageBox.Show("Błędny numer telefonu", "Błąd", MessageBoxButtons.OK);
                        break;
                    }
                case "mobile":
                    {
                        MessageBox.Show("Błędny numer komórkowy", "Błąd", MessageBoxButtons.OK);
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
