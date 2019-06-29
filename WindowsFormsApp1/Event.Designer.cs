namespace ContentShare
{
    partial class Event
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
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textAddressEv = new System.Windows.Forms.TextBox();
            this.textNumeEv = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textDescr = new System.Windows.Forms.RichTextBox();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(9, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            // 
            // textAddressEv
            // 
            this.textAddressEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddressEv.Location = new System.Drawing.Point(70, 52);
            this.textAddressEv.Multiline = true;
            this.textAddressEv.Name = "textAddressEv";
            this.textAddressEv.Size = new System.Drawing.Size(297, 40);
            this.textAddressEv.TabIndex = 13;
            // 
            // textNumeEv
            // 
            this.textNumeEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumeEv.Location = new System.Drawing.Point(70, 8);
            this.textNumeEv.Name = "textNumeEv";
            this.textNumeEv.Size = new System.Drawing.Size(297, 20);
            this.textNumeEv.TabIndex = 12;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(8, 101);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(71, 13);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Event Date";
            this.labelDate.Click += new System.EventHandler(this.labelDate_Click);
            // 
            // textDescr
            // 
            this.textDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescr.Location = new System.Drawing.Point(50, 160);
            this.textDescr.Name = "textDescr";
            this.textDescr.Size = new System.Drawing.Size(317, 79);
            this.textDescr.TabIndex = 24;
            this.textDescr.Text = "";
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescriere.Location = new System.Drawing.Point(9, 144);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(71, 13);
            this.labelDescriere.TabIndex = 23;
            this.labelDescriere.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(292, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // textDate
            // 
            this.textDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDate.Location = new System.Drawing.Point(85, 98);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(282, 20);
            this.textDate.TabIndex = 26;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textDescr);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textAddressEv);
            this.Controls.Add(this.textNumeEv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 182);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event";
            this.Load += new System.EventHandler(this.Event_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDescriere;
        public System.Windows.Forms.TextBox textAddressEv;
        public System.Windows.Forms.TextBox textNumeEv;
        public System.Windows.Forms.RichTextBox textDescr;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox textDate;
    }
}