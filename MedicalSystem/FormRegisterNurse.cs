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
    public partial class FormRegisterNurse : Form
    {
        public FormRegisterNurse()
        {
            InitializeComponent();
        }

        private void btnRegistrationSubmit_Click(object sender, EventArgs e)
        {
            //string email = txtRegistrationEmail.Text;
            //if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
            //{
            //    MessageBox.Show("Error Email");
            //}
             if (txtRegistrationEmail.Text.Contains("@")) // the email must contain (@) sign
            {
                lblError.Visible = false;
            FileStream filestream1 = new FileStream("D:\\MedicalSystem\\Records\\Nurse\\" + txtRegisterID.Text + ".txt", FileMode.Append, FileAccess.Write);
            StreamWriter filewriter = new StreamWriter(filestream1);
            try
            {
                filewriter.WriteLine(txtRegisterFirstN.Text);
                filewriter.WriteLine(txtRegistrationMName.Text);
                filewriter.WriteLine(txtRegisterLastN.Text);
                filewriter.WriteLine(txtRegistrationDoB.Text);
                filewriter.WriteLine(txtRegistrationAge.Text);
                filewriter.WriteLine(txtRegistrationGender.Text);
                filewriter.WriteLine(txtRegistrationCNum.Text);
                filewriter.WriteLine(txtRegistrationNationality.Text);
                filewriter.WriteLine(txtRegistrationProg.Text);
                filewriter.WriteLine(txtRegistrationEmail.Text);
                //filewriter.WriteLine("Parent/Guardian: " + txtRegistrationGuardian.Text);
                //filewriter.WriteLine("Relation: " + txtRegistrationRelationship.Text);
                //filewriter.WriteLine("PPhone No: " + txtRegistrationGuardPNum.Text);
                //filewriter.WriteLine("PContact No.: " + txtRegistrationGuardNum.Text);
                filewriter.WriteLine("Address: " + txtRegistrationAddress.Text);
                //filewriter.WriteLine("Blood Type: " + cobBloodType.Text);
                //filewriter.WriteLine("Blood Pressure: " + txtBloodPressure.Text);
                //filewriter.WriteLine("Height: " + txtRegistrationHeight.Text);
                //filewriter.WriteLine("Weight: " + txtRegistrationGender.Text);
                //filewriter.Write("Has Patient has:");
                //if (chbRegistrationMeasles.Checked)
                //    filewriter.Write(" " + chbRegistrationMeasles.Text);
                //if (chbRegistrationChikenPox.Checked)
                //    filewriter.Write(" "+ chbRegistrationChikenPox.Text);
                //if (chbRegistrationTyphoid.Checked)
                //    filewriter.Write(" " + chbRegistrationTyphoid.Text);
                //if (chbRegistrationWCough.Checked)
                //    filewriter.Write(" " + chbRegistrationWCough.Text);
                filewriter.Flush();
            }
            finally
            {
                filestream1.Close();
            }

            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
            }
             else
                 lblError.Visible = true;
        }

        private void txtRegisterFirstN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationCNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationProg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }
     
        private void txtRegisterID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegisterLastN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationDoB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegisterID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void btnRegistrationExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRegistrationAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegistrationMName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegistrationGuardian_TextChanged(object sender, EventArgs e)
        {

        }
        //private void txtRegistrationEmail_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string email = txtRegistrationEmail.Text;
        //    if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1)
        //    {
        //        MessageBox.Show("Error Email");
        //    }
        }
    }