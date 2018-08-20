using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessCardHolder.Forms;

namespace BusinessCardHolder
{
    public partial class BusinessCardHolderForm : Form
    {
        public BusinessCardHolderForm()
        {
            InitializeComponent();
        }

        private CompaniesListForm frmCompaniesListForm;
        private void tlsCompaniesList_Click(object sender, EventArgs e)
        {
            if (frmCompaniesListForm == null)
            {
                frmCompaniesListForm = new CompaniesListForm();
                frmCompaniesListForm.MdiParent = this;
                frmCompaniesListForm.FormClosed += new FormClosedEventHandler(frmCompaniesListForm_FormClosed);
                frmCompaniesListForm.Show();
            }
            else
                frmCompaniesListForm.Activate();
        }

        private void frmCompaniesListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCompaniesListForm = null;
        }

        private EmployeesListForm frmEmployeesListForm;
        private void tlsEmployeesList_Click(object sender, EventArgs e)
        {
            if (frmEmployeesListForm == null)
            {
                frmEmployeesListForm = new EmployeesListForm();
                frmEmployeesListForm.MdiParent = this;
                frmEmployeesListForm.FormClosed += new FormClosedEventHandler(frmEmployeesListForm_FormClosed);
                frmEmployeesListForm.Show();
            }
            else
                frmEmployeesListForm.Activate();
        }

        private void frmEmployeesListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmEmployeesListForm = null;
        }
    }
}
