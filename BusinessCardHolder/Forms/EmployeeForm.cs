using BusinessCardHolder.DataBase;
using BusinessCardHolder.Models;
using System;
using System.Windows.Forms;

namespace BusinessCardHolder.Forms
{
    public partial class EmployeeForm : Form
    {
        public Employee Employee { get; set; }
        public Button SaveButton { get { return btnSaveButton; } }
        public ComboBox CompanyComboBox {  get { return cmbCompanyName; } }

        public EmployeeForm(Employee employee, Company company = null)
        {
            InitializeComponent();
            Employee = employee;
            bsEmployee.DataSource = Employee;
            CompanyRepository companyRepository = new CompanyRepository();
            bsCompanies.DataSource = companyRepository.FindAll();
            if (company != null)
            {
                cmbCompanyName.SelectedValue = company.Id;
                cmbCompanyName.Text = company.Name;
            }
        }

        private void btnSaveButton_Click(object sender, EventArgs e)
        {
            Employee = (Employee)bsEmployee.Current;
            Employee.CompanyId = Convert.ToInt32(cmbCompanyName.SelectedValue);
            Close();
        }

        private void btnCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
