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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textAddressEv = new System.Windows.Forms.TextBox();
            this.textNumeEv = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateEvent = new System.Windows.Forms.DateTimePicker();
            this.textDescr = new System.Windows.Forms.RichTextBox();
            this.labelDescriere = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Events";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(37, 95);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            // 
            // textAddressEv
            // 
            this.textAddressEv.Location = new System.Drawing.Point(98, 147);
            this.textAddressEv.Name = "textAddressEv";
            this.textAddressEv.Size = new System.Drawing.Size(100, 20);
            this.textAddressEv.TabIndex = 13;
            // 
            // textNumeEv
            // 
            this.textNumeEv.Location = new System.Drawing.Point(98, 88);
            this.textNumeEv.Name = "textNumeEv";
            this.textNumeEv.Size = new System.Drawing.Size(100, 20);
            this.textNumeEv.TabIndex = 12;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(33, 206);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(61, 13);
            this.labelDate.TabIndex = 19;
            this.labelDate.Text = "Event Date";
            // 
            // dateEvent
            // 
            this.dateEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEvent.Location = new System.Drawing.Point(125, 206);
            this.dateEvent.Name = "dateEvent";
            this.dateEvent.Size = new System.Drawing.Size(120, 20);
            this.dateEvent.TabIndex = 18;
            // 
            // textDescr
            // 
            this.textDescr.Location = new System.Drawing.Point(125, 260);
            this.textDescr.Name = "textDescr";
            this.textDescr.Size = new System.Drawing.Size(120, 38);
            this.textDescr.TabIndex = 24;
            this.textDescr.Text = "";
            // 
            // labelDescriere
            // 
            this.labelDescriere.AutoSize = true;
            this.labelDescriere.Location = new System.Drawing.Point(34, 278);
            this.labelDescriere.Name = "labelDescriere";
            this.labelDescriere.Size = new System.Drawing.Size(60, 13);
            this.labelDescriere.TabIndex = 23;
            this.labelDescriere.Text = "Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(508, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 385);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textDescr);
            this.Controls.Add(this.labelDescriere);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.dateEvent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textAddressEv);
            this.Controls.Add(this.textNumeEv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Event";
            this.Text = "Upload";
            this.Load += new System.EventHandler(this.Upload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDescriere;
        public System.Windows.Forms.TextBox textAddressEv;
        public System.Windows.Forms.TextBox textNumeEv;
        public System.Windows.Forms.DateTimePicker dateEvent;
        public System.Windows.Forms.RichTextBox textDescr;
        private System.Windows.Forms.Button btnCancel;
    }
}