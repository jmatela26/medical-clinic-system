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
    public partial class FormClinicSystem : Form
    {
        public FormClinicSystem()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //pagsusulat sa file
            if (File.Exists("D:\\MedicalSystem\\Records\\Students\\" + txtFind.Text + ".txt"))
            {
                FileStream filestream1 = new FileStream("D:\\MedicalSystem\\Records\\Students\\" + txtFind.Text + ".txt", FileMode.Append, FileAccess.Write);
                StreamWriter filewriter = new StreamWriter(filestream1);

                //for complain
                filewriter.WriteLine("Complain: " + txtComplain.Text);
                //for assesment listview
                for (int i = 0; i < this.lstViewConsult.Items.Count; i++)
                {
                    filewriter.WriteLine("Assesment: " + lstViewConsult.Items[i].Text +
                        "\n Remarks " + lstViewConsult.Items[i].SubItems[1].ToString() +
                        "\n Plan " + lstViewConsult.Items[i].SubItems[2].ToString());
                }
                
                //for medical list view
                for (int x = 0; x < this.lstViewMed.Items.Count; x++)
                {
                    filewriter.WriteLine("Medicine: " + lstViewMed.Items[x].Text +
                        "\n Quantity " + lstViewMed.Items[x].SubItems[1].ToString() +
                        "\n Unit Cost " + lstViewMed.Items[x].SubItems[2].ToString());
                }
                //filewriter.Flush();
                //filewriter.Close();
                //if (File.Exists("E:\\MedicalSystem\\Records\\Med.txt"))
                //{
                //    FileStream filestream2 = new FileStream("E:\\MedicalSystem\\Records\\Med.txt", FileMode.Append, FileAccess.Write);
                //    StreamWriter filewriter1 = new StreamWriter(filestream2);
                //    {
                //        for (int y = 0; y < lstViewMed.Items.Count; y++)
                //        {

                //            filewriter.WriteLine("Medicine: " + lstViewMed.Items[y].Text +
                //            "\n Quantity " + lstViewMed.Items[y].SubItems[1].ToString() +
                //            "\n Unit Cost " + lstViewMed.Items[y].SubItems[2].ToString());
                //        }
                //        filestream1.Flush();
                //        filewriter1.Close();
                //    }
                //}
                filewriter.Flush();
                filewriter.Close();

                //filewriter.WriteLine("Total Cost:" + txtTotalCost.Text);

                //sarado ng file
                //filewriter.Flush();
                //filewriter.Close();
                MessageBox.Show("You have saved it!");
                this.Hide();
                FormLogin logIn = new FormLogin();
                logIn.Show();
            }

        }
   
        private void btnFind_Click(object sender, EventArgs e)
        {   //pagbaba sa file para sa students
            if (File.Exists("D:\\MedicalSystem\\Records\\Students\\" + txtFind.Text + ".txt"))
            {

                string[] files1 = File.ReadAllLines("D:\\MedicalSystem\\Records\\Students\\" + txtFind.Text + ".txt");

                txtRegisterFirstN.Text = files1[0];
                txtRegistrationMName.Text = files1[1];
                txtRegisterLastN.Text = files1[2];
                txtRegistrationDoB.Text = files1[3];
                txtRegistrationAge.Text = files1[4];
                txtRegistrationGender.Text = files1[5];
                txtRegistrationCNum.Text = files1[6];
                txtRegistrationNationality.Text = files1[7];
                txtRegistrationProg.Text = files1[8];
                txtRegistrationEmail.Text = files1[9];
                txtRegistrationGuardian.Text = files1[10];
                textBox1.Text = files1[11];
                textBox2.Text = files1[12];
                txtRegistrationRelationship.Text = files1[13];
                txtRegistrationGuardPNum.Text = files1[14];
                txtRegistrationGuardNum.Text = files1[15];
                txtRegistrationAddress.Text = files1[16];
            }
        }

        private void txtFind_KeyPress(object sender, KeyPressEventArgs e)
        {   //exception handling
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   //ayaw gumana ng if statement
            if (txtAssesment.Text != " " | txtRemarks.Text != " " || txtPlans.Text != " ")
            {
                ListViewItem listVconsult = new ListViewItem(txtAssesment.Text);
                listVconsult.SubItems.Add(txtRemarks.Text);
                listVconsult.SubItems.Add(txtPlans.Text);
                lstViewConsult.Items.Add(listVconsult);
            }
            else
            {
                MessageBox.Show("Input First");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {   //ayaw din gumana
            if (txtAssesment.Text == "" || txtRemarks.Text == "" || txtPlans.Text == "")
            {
                MessageBox.Show("Input first!");
            }
            else if (lstViewConsult.SelectedIndices != null)
            {
                int index = lstViewConsult.SelectedIndices[0];
                lstViewConsult.Items[index].Text = txtAssesment.Text.ToString();
                lstViewConsult.Items[index].SubItems[1].Text = txtRemarks.Text.ToString();
                lstViewConsult.Items[index].SubItems[2].Text = txtPlans.Text.ToString();
            }
            else
            {
                MessageBox.Show("Select First");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {   //gumagana
            try
            {
                this.lstViewConsult.SelectedItems[0].Remove();
            }
            catch
            {
                MessageBox.Show("Select first");
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {   //para sa class medicine
            Medicine addMedicine = new Medicine();
            //assigning ng value sa text box
            //paglagay sa listview control
            ListViewItem lvi = new ListViewItem(cobMedName.Text);
            lvi.SubItems.Add(txtTotalQuantity.Text);
            //lvi.SubItems.Add(addMedicine.cost.ToString());
            if (cobMedName.Text == "Lagundi")
                lvi.SubItems.Add((addMedicine.getTotalCost(5.0 , double.Parse(txtTotalQuantity.Text)).ToString()));
            if (cobMedName.Text == "Neozep")
                lvi.SubItems.Add((addMedicine.getTotalCost(5.0, double.Parse(txtTotalQuantity.Text)).ToString()));
            if (cobMedName.Text == "Benadryl")
                lvi.SubItems.Add((addMedicine.getTotalCost(7.0, double.Parse(txtTotalQuantity.Text)).ToString()));
            if (cobMedName.Text == "Advil")
                lvi.SubItems.Add((addMedicine.getTotalCost(6.0, double.Parse(txtTotalQuantity.Text)).ToString()));
            if (cobMedName.Text == "Biogesic")
                lvi.SubItems.Add((addMedicine.getTotalCost(5.0, double.Parse(txtTotalQuantity.Text)).ToString()));
            if (cobMedName.Text == "Antibiotic")
                lvi.SubItems.Add((addMedicine.getTotalCost(15.0, double.Parse(txtTotalQuantity.Text)).ToString()));
            lstViewMed.Items.Add(lvi);

        }

        private void editBtn_Click(object sender, EventArgs e)
        {   //editing sa medicine list
            int index = lstViewMed.SelectedIndices[0];
            lstViewMed.Items[index].Text = cobMedName.Text.ToString();
            lstViewMed.Items[index].SubItems[1].Text = txtTotalQuantity.Text.ToString();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {   //sa remove medicine
            try
            {
                this.lstViewMed.SelectedItems[0].Remove();
            }
            catch
            {
                MessageBox.Show("Select first");
            }
        }

        //private void btnGetTotal_Click(object sender, EventArgs e)
        //{       //compute button
        //    Medicine addMedicine = new Medicine();

        //    addMedicine.quantity = int.Parse(txtTotalQuantity.Text);
        //    //para malaman cost
        //    if (cobMedName.Text.Contains("Neozep"))
        //    {
        //        addMedicine.cost = 5.0;
        //    }
        //    if (cobMedName.Text.Contains("Benadryl"))
        //    {
        //        addMedicine.cost = 6.0;
        //    }
        //    if (cobMedName.Text.Contains("Advil"))
        //    {
        //        addMedicine.cost = 7.0;
        //    }
        //    if (cobMedName.Text.Contains("Biogesic"))
        //    {
        //        addMedicine.cost = 8.0;
        //    }
        //    if (cobMedName.Text.Contains("Lagundi"))
        //    {
        //        addMedicine.cost = 9.0;
        //    }
        //    if (cobMedName.Text.Contains("Antibiotic"))
        //    {
        //        addMedicine.cost = 10.0;
        //    }
        //    //method ng class
        //    addMedicine.getTotalCost(addMedicine.cost, addMedicine.quantity);
        //    //txtTotalCost.Text = addMedicine.totalCost.ToString();
        //}

        public void medName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Invetory lvi = new Invetory();
            //medName.Items.ToString() = lvi.listView1_SelectedIndexChanged();
        }

        private void txtRegisterFirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegistrationGuardian_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}