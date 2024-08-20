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
    public partial class FormRegisterS : Form
    {
        public FormRegisterS()
        {
            InitializeComponent();
        }

        private void btnRegistrationSubmit_Click(object sender, EventArgs e)
        {
            if (txtRegistrationEmail.Text.Contains("@")) // the email must contain (@) sign
            {
                lblError.Visible = false;
            

            FileStream filestream1 = new FileStream("D:\\MedicalSystem\\Records\\Students\\" + txtRegisterID.Text + ".txt", FileMode.Append, FileAccess.Write);
            StreamWriter filewriter=new StreamWriter(filestream1);
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
            filewriter.WriteLine(txtRegistrationGuardian.Text);
            filewriter.WriteLine(textBox1.Text);
            filewriter.WriteLine(textBox2.Text);
            filewriter.WriteLine(txtRegistrationRelationship.Text);
            filewriter.WriteLine(txtRegistrationGuardPNum.Text);
            filewriter.WriteLine(txtRegistrationGuardNum.Text);
            filewriter.WriteLine(txtRegistrationAddress.Text);
            filewriter.WriteLine(cobBloodType.Text);
            filewriter.WriteLine(txtBloodPressure.Text);
            filewriter.WriteLine(txtRegistrationHeight.Text);
            filewriter.WriteLine(txtRegistrationWeight.Text);
            if (chbRegistrationMeasles.Checked)
                filewriter.Write(" " + chbRegistrationMeasles.Text);
            if (chbRegistrationChikenPox.Checked)
                filewriter.Write(" "+ chbRegistrationChikenPox.Text);
            if (chbRegistrationTyphoid.Checked)
                filewriter.Write(" " + chbRegistrationTyphoid.Text);
            if (chbRegistrationWCough.Checked)
                filewriter.Write(" " + chbRegistrationWCough.Text);
	{
		 
	}
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

        private void txtRegisterLastN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationDoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
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

        private void txtRegistrationGuardian_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationRelationship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationGuardPNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationGuardNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtBloodPressure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegistrationWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtRegisterID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRegisterFirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegistrationGuardian_TextChanged(object sender, EventArgs e)
        {

        }       
    }
}
