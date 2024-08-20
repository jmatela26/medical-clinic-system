using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MedicalSystem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdmin registerS = new FormAdmin();
            registerS.Show();

        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            FormClinicSystem clinic = new FormClinicSystem();
            //login for the Nurse or doctor. Nurse for 9 user id and student for 10 numbers
            if (cboLogin.Text == "Doctor/Nurse")
            {
                if (txtUser.TextLength == 9 && File.Exists("D:\\MedicalSystem\\Records\\Nurse\\" + txtUser.Text + ".txt"))
                {   
                    clinic.Show();
                    this.Hide();
                }
                else
                {
                    lblUError.Show();
                }

            }
            else if (cboLogin.Text == "Student")
            {
                if (txtUser.TextLength == 10 && File.Exists("D:\\MedicalSystem\\Records\\Students\\" + txtUser.Text + ".txt"))
                {
                    clinic.Show();
                    this.Hide();
                }
                else
                {
                    lblUError.Show();
                }
            }
        }
        public void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {   //exception handling
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}