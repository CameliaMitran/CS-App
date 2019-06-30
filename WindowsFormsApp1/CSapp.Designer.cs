namespace WindowsFormsApp1
{
    partial class CSapp
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
            this.btnTickets = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.BtnEvent = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnNewEmp = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTickets.Location = new System.Drawing.Point(51, 109);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(96, 27);
            this.btnTickets.TabIndex = 0;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateEvent.Location = new System.Drawing.Point(51, 207);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(96, 27);
            this.btnCreateEvent.TabIndex = 1;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = false;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEmployees.Location = new System.Drawing.Point(51, 361);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(96, 27);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(85)))));
            this.panelMenu.Controls.Add(this.BtnEvent);
            this.panelMenu.Controls.Add(this.BtnLogout);
            this.panelMenu.Controls.Add(this.BtnNewEmp);
            this.panelMenu.Controls.Add(this.btnCreate);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.btnTickets);
            this.panelMenu.Controls.Add(this.btnEmployees);
            this.panelMenu.Controls.Add(this.btnCreateEvent);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(203, 450);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // BtnEvent
            // 
            this.BtnEvent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEvent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnEvent.Location = new System.Drawing.Point(51, 264);
            this.BtnEvent.Name = "BtnEvent";
            this.BtnEvent.Size = new System.Drawing.Size(96, 23);
            this.BtnEvent.TabIndex = 6;
            this.BtnEvent.Text = "Events";
            this.BtnEvent.UseVisualStyleBackColor = false;
            this.BtnEvent.Click += new System.EventHandler(this.BtnEvent_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnLogout.Location = new System.Drawing.Point(11, 417);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(55, 22);
            this.BtnLogout.TabIndex = 5;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnNewEmp
            // 
            this.BtnNewEmp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNewEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewEmp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNewEmp.Location = new System.Drawing.Point(51, 316);
            this.BtnNewEmp.Name = "BtnNewEmp";
            this.BtnNewEmp.Size = new System.Drawing.Size(96, 24);
            this.BtnNewEmp.TabIndex = 4;
            this.BtnNewEmp.Text = "New Employee";
            this.BtnNewEmp.UseVisualStyleBackColor = false;
            this.BtnNewEmp.Click += new System.EventHandler(this.BtnNewEmp_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreate.Location = new System.Drawing.Point(51, 155);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 25);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create Ticket";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panelLogo.BackgroundImage = global::ContentShare.Properties.Resources.multimedia;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(203, 65);
            this.panelLogo.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.labelExit);
            this.panelHeader.Controls.Add(this.textBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(203, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(597, 65);
            this.panelHeader.TabIndex = 4;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.White;
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.Red;
            this.labelExit.Location = new System.Drawing.Point(566, 21);
            this.labelExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(27, 26);
            this.labelExit.TabIndex = 4;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(0, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 24);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Human Resources";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.White;
            this.panelDisplay.Controls.Add(this.Calendar);
            this.panelDisplay.Controls.Add(this.dataGridViewTickets);
            this.panelDisplay.Location = new System.Drawing.Point(203, 65);
            this.panelDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(597, 385);
            this.panelDisplay.TabIndex = 5;
            this.panelDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplay_Paint);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(11, 199);
            this.Calendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.Calendar.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 1;
            this.Calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateChanged);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.AllowUserToOrderColumns = true;
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.Size = new System.Drawing.Size(588, 182);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_CellContentClick);
            this.dataGridViewTickets.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTickets_CellMouseDoubleClick);
            // 
            // CSapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CSapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSapp";
            this.Load += new System.EventHandler(this.CSapp_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button btnCreate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Button BtnNewEmp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Button BtnEvent;
    }
}