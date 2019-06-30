namespace ContentShare
{
    partial class Other_Department
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
            this.panelMenuIT = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnTickets = new System.Windows.Forms.Button();
            this.PanelLogoIT = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.panelMenuIT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuIT
            // 
            this.panelMenuIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(72)))), ((int)(((byte)(85)))));
            this.panelMenuIT.Controls.Add(this.BtnLogout);
            this.panelMenuIT.Controls.Add(this.btnCreate);
            this.panelMenuIT.Controls.Add(this.btnTickets);
            this.panelMenuIT.Controls.Add(this.PanelLogoIT);
            this.panelMenuIT.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIT.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIT.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuIT.Name = "panelMenuIT";
            this.panelMenuIT.Size = new System.Drawing.Size(203, 450);
            this.panelMenuIT.TabIndex = 1;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.White;
            this.BtnLogout.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Location = new System.Drawing.Point(11, 417);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(67, 31);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(51, 165);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 25);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Ticket";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.BackColor = System.Drawing.Color.White;
            this.btnTickets.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTickets.Location = new System.Drawing.Point(51, 100);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.Size = new System.Drawing.Size(96, 27);
            this.btnTickets.TabIndex = 2;
            this.btnTickets.Text = "Tickets";
            this.btnTickets.UseVisualStyleBackColor = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // PanelLogoIT
            // 
            this.PanelLogoIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.PanelLogoIT.BackgroundImage = global::ContentShare.Properties.Resources.multimedia;
            this.PanelLogoIT.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogoIT.Location = new System.Drawing.Point(0, 0);
            this.PanelLogoIT.Name = "PanelLogoIT";
            this.PanelLogoIT.Size = new System.Drawing.Size(203, 65);
            this.PanelLogoIT.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.labelExit);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 65);
            this.panel1.TabIndex = 2;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.White;
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.Color.Red;
            this.labelExit.Location = new System.Drawing.Point(566, 18);
            this.labelExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(27, 26);
            this.labelExit.TabIndex = 5;
            this.labelExit.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(170)))), ((int)(((byte)(51)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 24);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Other Departments";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.White;
            this.panelDisplay.Controls.Add(this.dataGridViewTickets);
            this.panelDisplay.Location = new System.Drawing.Point(203, 65);
            this.panelDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(597, 385);
            this.panelDisplay.TabIndex = 3;
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.Size = new System.Drawing.Size(588, 150);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_CellContentClick);
            this.dataGridViewTickets.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewTickets_CellMouseDoubleClick);
            // 
            // Other_Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Other_Department";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Other_Department";
            this.Load += new System.EventHandler(this.Other_Department_Load);
            this.panelMenuIT.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIT;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnTickets;
        private System.Windows.Forms.FlowLayoutPanel PanelLogoIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
    }
}