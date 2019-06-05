namespace ContentShare
{
    partial class SignUp
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelExit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textEmpID = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelSingup = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCNP = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.textJob = new System.Windows.Forms.TextBox();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelHiringDate = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.dateHiring = new System.Windows.Forms.DateTimePicker();
            this.comboDepartment = new System.Windows.Forms.ComboBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.linkLabel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(121, 414);
            this.panelLeft.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ContentShare.Properties.Resources.multimedia;
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.comboDepartment);
            this.panelRight.Controls.Add(this.dateHiring);
            this.panelRight.Controls.Add(this.labelSingup);
            this.panelRight.Controls.Add(this.textJob);
            this.panelRight.Controls.Add(this.labelDepartment);
            this.panelRight.Controls.Add(this.labelHiringDate);
            this.panelRight.Controls.Add(this.labelJob);
            this.panelRight.Controls.Add(this.textFirstName);
            this.panelRight.Controls.Add(this.labelFirstName);
            this.panelRight.Controls.Add(this.labelAddress);
            this.panelRight.Controls.Add(this.labelCNP);
            this.panelRight.Controls.Add(this.labelLastName);
            this.panelRight.Controls.Add(this.labelPhone);
            this.panelRight.Controls.Add(this.textLastName);
            this.panelRight.Controls.Add(this.textCNP);
            this.panelRight.Controls.Add(this.textAddress);
            this.panelRight.Controls.Add(this.textPhone);
            this.panelRight.Controls.Add(this.labelExit);
            this.panelRight.Controls.Add(this.button1);
            this.panelRight.Controls.Add(this.textEmail);
            this.panelRight.Controls.Add(this.textEmpID);
            this.panelRight.Controls.Add(this.textPassword);
            this.panelRight.Controls.Add(this.textUserName);
            this.panelRight.Controls.Add(this.labelEmpID);
            this.panelRight.Controls.Add(this.labelEmail);
            this.panelRight.Controls.Add(this.labelPassword);
            this.panelRight.Controls.Add(this.labelUserName);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(121, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(412, 414);
            this.panelRight.TabIndex = 1;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(31, 296);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign In";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(383, 2);
            this.labelExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(27, 26);
            this.labelExit.TabIndex = 3;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(164, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(238, 107);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(163, 20);
            this.textEmail.TabIndex = 1;
            // 
            // textEmpID
            // 
            this.textEmpID.Location = new System.Drawing.Point(32, 107);
            this.textEmpID.Margin = new System.Windows.Forms.Padding(2);
            this.textEmpID.Name = "textEmpID";
            this.textEmpID.Size = new System.Drawing.Size(163, 20);
            this.textEmpID.TabIndex = 1;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(238, 316);
            this.textPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(163, 20);
            this.textPassword.TabIndex = 1;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(238, 275);
            this.textUserName.Margin = new System.Windows.Forms.Padding(2);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(163, 20);
            this.textUserName.TabIndex = 1;
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelEmpID.Location = new System.Drawing.Point(32, 88);
            this.labelEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(87, 17);
            this.labelEmpID.TabIndex = 0;
            this.labelEmpID.Text = "Employee ID";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelEmail.Location = new System.Drawing.Point(238, 88);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(42, 17);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPassword.Location = new System.Drawing.Point(238, 297);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.labelFullname_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelUserName.Location = new System.Drawing.Point(238, 255);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name";
            this.labelUserName.Click += new System.EventHandler(this.labeUserName_Click);
            // 
            // labelSingup
            // 
            this.labelSingup.AutoSize = true;
            this.labelSingup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSingup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelSingup.Location = new System.Drawing.Point(112, 22);
            this.labelSingup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSingup.Name = "labelSingup";
            this.labelSingup.Size = new System.Drawing.Size(178, 29);
            this.labelSingup.TabIndex = 0;
            this.labelSingup.Text = "New Employee";
            this.labelSingup.Click += new System.EventHandler(this.labelSingup_Click);
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(32, 315);
            this.textPhone.Margin = new System.Windows.Forms.Padding(2);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(163, 20);
            this.textPhone.TabIndex = 5;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(32, 275);
            this.textAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(163, 20);
            this.textAddress.TabIndex = 6;
            // 
            // textCNP
            // 
            this.textCNP.Location = new System.Drawing.Point(32, 231);
            this.textCNP.Margin = new System.Windows.Forms.Padding(2);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(163, 20);
            this.textCNP.TabIndex = 7;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(32, 190);
            this.textLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(163, 20);
            this.textLastName.TabIndex = 8;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelPhone.Location = new System.Drawing.Point(32, 296);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(49, 17);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "Phone";
            this.labelPhone.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelLastName.Location = new System.Drawing.Point(32, 171);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 10;
            this.labelLastName.Text = "Last Name";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCNP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelCNP.Location = new System.Drawing.Point(32, 212);
            this.labelCNP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(36, 17);
            this.labelCNP.TabIndex = 11;
            this.labelCNP.Text = "CNP";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelAddress.Location = new System.Drawing.Point(32, 253);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddress.TabIndex = 12;
            this.labelAddress.Text = "Address";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelFirstName.Location = new System.Drawing.Point(32, 130);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 13;
            this.labelFirstName.Text = "First Name";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(32, 149);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(163, 20);
            this.textFirstName.TabIndex = 14;
            // 
            // textJob
            // 
            this.textJob.Location = new System.Drawing.Point(238, 149);
            this.textJob.Margin = new System.Windows.Forms.Padding(2);
            this.textJob.Name = "textJob";
            this.textJob.Size = new System.Drawing.Size(163, 20);
            this.textJob.TabIndex = 20;
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelDepartment.Location = new System.Drawing.Point(238, 215);
            this.labelDepartment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(82, 17);
            this.labelDepartment.TabIndex = 15;
            this.labelDepartment.Text = "Department";
            // 
            // labelHiringDate
            // 
            this.labelHiringDate.AutoSize = true;
            this.labelHiringDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHiringDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelHiringDate.Location = new System.Drawing.Point(238, 171);
            this.labelHiringDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHiringDate.Name = "labelHiringDate";
            this.labelHiringDate.Size = new System.Drawing.Size(79, 17);
            this.labelHiringDate.TabIndex = 16;
            this.labelHiringDate.Text = "Hiring Date";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelJob.Location = new System.Drawing.Point(238, 129);
            this.labelJob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(62, 17);
            this.labelJob.TabIndex = 17;
            this.labelJob.Text = "Job Title";
            // 
            // dateHiring
            // 
            this.dateHiring.Location = new System.Drawing.Point(238, 189);
            this.dateHiring.Name = "dateHiring";
            this.dateHiring.Size = new System.Drawing.Size(163, 20);
            this.dateHiring.TabIndex = 21;
            // 
            // comboDepartment
            // 
            this.comboDepartment.FormattingEnabled = true;
            this.comboDepartment.Location = new System.Drawing.Point(238, 231);
            this.comboDepartment.Name = "comboDepartment";
            this.comboDepartment.Size = new System.Drawing.Size(163, 21);
            this.comboDepartment.TabIndex = 22;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 414);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelSingup;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textEmpID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textJob;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelHiringDate;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textCNP;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.ComboBox comboDepartment;
        private System.Windows.Forms.DateTimePicker dateHiring;
    }
}