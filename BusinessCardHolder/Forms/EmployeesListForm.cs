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

        private void btnDeleteButton_Click(object sender, EventArgs e)
        {
            if (bsEmployees.Current is Employee)
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć wybraną osobę?", "Potwierdzenie usunięcia", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    EmployeeRepository employeeRepository = new EmployeeRepository();
                    employeeRepository.DeleteById(((Employee)bsEmployees.Current).Id);
                    bsEmployees.DataSource = employeeRepository.FindAll();
                    bsEmployees.ResetBindings(false);
                }
            }
        }
    }
}
