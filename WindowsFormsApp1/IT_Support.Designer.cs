namespace ContentShare
{
    partial class IT_Support
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
            this.BtnTickets = new System.Windows.Forms.Button();
            this.PanelLogoIT = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelExit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.panelMenuIT.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuIT
            // 
            this.panelMenuIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panelMenuIT.Controls.Add(this.BtnLogout);
            this.panelMenuIT.Controls.Add(this.btnCreate);
            this.panelMenuIT.Controls.Add(this.BtnTickets);
            this.panelMenuIT.Controls.Add(this.PanelLogoIT);
            this.panelMenuIT.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuIT.Location = new System.Drawing.Point(0, 0);
            this.panelMenuIT.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenuIT.Name = "panelMenuIT";
            this.panelMenuIT.Size = new System.Drawing.Size(203, 450);
            this.panelMenuIT.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.BtnLogout.Location = new System.Drawing.Point(11, 417);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(55, 22);
            this.BtnLogout.TabIndex = 6;
            this.BtnLogout.Text = "Log Out";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(51, 165);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 25);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create Ticket";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // BtnTickets
            // 
            this.BtnTickets.Location = new System.Drawing.Point(51, 100);
            this.BtnTickets.Name = "BtnTickets";
            this.BtnTickets.Size = new System.Drawing.Size(96, 27);
            this.BtnTickets.TabIndex = 2;
            this.BtnTickets.Text = "Tickets";
            this.BtnTickets.UseVisualStyleBackColor = true;
            this.BtnTickets.Click += new System.EventHandler(this.BtnTickets_Click);
            // 
            // PanelLogoIT
            // 
            this.PanelLogoIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PanelLogoIT.BackgroundImage = global::ContentShare.Properties.Resources.multimedia;
            this.PanelLogoIT.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogoIT.Location = new System.Drawing.Point(0, 0);
            this.PanelLogoIT.Name = "PanelLogoIT";
            this.PanelLogoIT.Size = new System.Drawing.Size(203, 65);
            this.PanelLogoIT.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelExit);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(203, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 65);
            this.panel1.TabIndex = 1;
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(566, 6);
            this.labelExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(27, 26);
            this.labelExit.TabIndex = 5;
            this.labelExit.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(597, 24);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "IT Support";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.White;
            this.panelDisplay.Controls.Add(this.Refresh);
            this.panelDisplay.Controls.Add(this.dataGridViewTickets);
            this.panelDisplay.Location = new System.Drawing.Point(203, 65);
            this.panelDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(597, 385);
            this.panelDisplay.TabIndex = 2;
            this.panelDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDisplay_Paint);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(304, 244);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 1;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTickets.Size = new System.Drawing.Size(597, 176);
            this.dataGridViewTickets.TabIndex = 0;
            this.dataGridViewTickets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTickets_CellDoubleClick);
            // 
            // IT_Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuIT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IT_Support";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT_Support";
            this.Load += new System.EventHandler(this.IT_Support_Load);
            this.panelMenuIT.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuIT;
        private System.Windows.Forms.FlowLayoutPanel PanelLogoIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnTickets;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.Button Refresh;
    }
}