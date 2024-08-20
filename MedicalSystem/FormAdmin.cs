using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            
            FormRegisterS clinicS = new FormRegisterS();
            if (txtPass.Text == "admin")
            {
                clinicS.Show();
                this.Hide();
            }
            else
            {
                lblAError.Visible = true;
            }
        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            FormRegisterNurse clinicN = new FormRegisterNurse();
            if (txtPass.Text == "admin")
            {
                clinicN.Show();
                lblAError.Hide();
            }
            else
            {
                lblAError.Visible = true;
            }
        }

        //private void btnViewS_Click(object sender, EventArgs e)
        //{
        //    FormViewStudents viewStudent = new FormViewStudents();
        //    if (txtPass.Text == "admin")
        //    {
        //        viewStudent.Show();
        //        lblAError.Hide();
        //    }
        //    else
        //    {
        //        lblAError.Visible = true;
        //    }
        //}

        //private void btnViewNurse_Click(object sender, EventArgs e)
        //{
        //    FormViewNurse viewNurse = new FormViewNurse();
        //    if (txtPass.Text == "admin")
        //    {
        //        viewNurse.Show();
        //        lblAError.Hide();
        //    }
        //    else
        //    {
        //        lblAError.Visible = true;
        //    }
        //}

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
