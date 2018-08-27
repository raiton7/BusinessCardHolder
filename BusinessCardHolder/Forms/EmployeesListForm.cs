using System;
using System.Windows.Forms;
using BusinessCardHolder.DataBase;
using BusinessCardHolder.Models;

namespace BusinessCardHolder.Forms
{
    public partial class EmployeesListForm : Form
    {
        public EmployeesListForm()
        {
            InitializeComponent();

            EmployeeRepository employeeRepository = new EmployeeRepository();
            bsEmployees.DataSource = employeeRepository.FindAll();
            grdEmployees.AutoGenerateColumns = false;
            grdEmployees.DataSource = bsEmployees;
        }

        private void btnBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            EmployeeForm frmEmployeeForm = new EmployeeForm(employee);
            frmEmployeeForm.MdiParent = MdiParent;
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
                bsEmployees.DataSource = employeeRepository.FindAll();
                grdEmployees.Refresh();
            };
        }

        private void btnEditButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee = (Employee)bsEmployees.Current;
            EmployeeForm frmEmployeeForm = new EmployeeForm(employee);
            frmEmployeeForm.MdiParent = MdiParent;
            frmEmployeeForm.Show();
            frmEmployeeForm.SaveButton.Click += delegate
            {
                employee = frmEmployeeForm.Employee;
                string errorText = string.Empty;
                EmployeeRepository employeeRepository = new EmployeeRepository();
                if (Validation.ValidateEmployee(employee, ref errorText))
                {
                    employeeRepository.Update(employee);
                    frmEmployeeForm.Close();
                }
                else
                {
                    ShowErrorMessage(errorText);
                }
                bsEmployees.DataSource = employeeRepository.FindAll();
                grdEmployees.Refresh();
            };
            frmEmployeeForm.CancelChangesButton.Click += delegate
            {
                EmployeeRepository employeeRepository = new EmployeeRepository();
                bsEmployees.DataSource = employeeRepository.FindAll();
                grdEmployees.Refresh();
            };
        }


        private void btnDeleteButton_Click(object sender, EventArgs e)
        {
            if (bsEmployees.Current is Employee)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wybraną osobę?"
                    , "Potwierdzenie usunięcia"
                    , MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    EmployeeRepository employeeRepository = new EmployeeRepository();
                    employeeRepository.DeleteById(((Employee)bsEmployees.Current).Id);
                    bsEmployees.DataSource = employeeRepository.FindAll();
                    grdEmployees.Refresh();
                }
            }
        }

        private void @delegate(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnSearchButton_Click(object sender, EventArgs e)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            bsEmployees.DataSource = employeeRepository.Search(txtSearchFirstName.Text, txtSearchLastName.Text, txtSearchCompanyName.Text,
                                                                txtSearchJobTitle.Text, txtSearchPhoneNumber.Text, txtSearchMobilePhoneNumber.Text);
            grdEmployees.Refresh();
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
