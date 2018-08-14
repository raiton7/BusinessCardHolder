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

        private void tlsCompaniesList_Click(object sender, EventArgs e)
        {
            CompaniesListForm frmCompaniesListForm = new CompaniesListForm();
            frmCompaniesListForm.MdiParent = this;
            frmCompaniesListForm.Show();
        }

        private void tlsEmployeesList_Click(object sender, EventArgs e)
        {

        }
    }
}
