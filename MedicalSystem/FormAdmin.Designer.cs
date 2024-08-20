namespace MedicalSystem
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnNurse = new System.Windows.Forms.Button();
            this.lblAError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(68, 17);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(64, 20);
            this.txtPass.TabIndex = 1;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(40, 54);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(132, 26);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Register a Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnNurse
            // 
            this.btnNurse.Location = new System.Drawing.Point(40, 84);
            this.btnNurse.Margin = new System.Windows.Forms.Padding(2);
            this.btnNurse.Name = "btnNurse";
            this.btnNurse.Size = new System.Drawing.Size(132, 26);
            this.btnNurse.TabIndex = 3;
            this.btnNurse.Text = "Register a Nurse/Doctor";
            this.btnNurse.UseVisualStyleBackColor = true;
            this.btnNurse.Click += new System.EventHandler(this.btnNurse_Click);
            // 
            // lblAError
            // 
            this.lblAError.AutoSize = true;
            this.lblAError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAError.Location = new System.Drawing.Point(136, 20);
            this.lblAError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAError.Name = "lblAError";
            this.lblAError.Size = new System.Drawing.Size(43, 15);
            this.lblAError.TabIndex = 6;
            this.lblAError.Text = "Error!";
            this.lblAError.Visible = false;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 123);
            this.Controls.Add(this.lblAError);
            this.Controls.Add(this.btnNurse);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnNurse;
        private System.Windows.Forms.Label lblAError;
    }
}