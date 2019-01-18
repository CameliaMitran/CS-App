namespace ContentShare
{
    partial class CreateTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTickets));
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmployerID = new System.Windows.Forms.TextBox();
            this.labelService = new System.Windows.Forms.Label();
            this.textService = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textShortDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // textName
            // 
            resources.ApplyResources(this.textName, "textName");
            this.textName.Name = "textName";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textEmployerID
            // 
            resources.ApplyResources(this.textEmployerID, "textEmployerID");
            this.textEmployerID.Name = "textEmployerID";
            // 
            // labelService
            // 
            resources.ApplyResources(this.labelService, "labelService");
            this.labelService.Name = "labelService";
            // 
            // textService
            // 
            resources.ApplyResources(this.textService, "textService");
            this.textService.Name = "textService";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textShortDescription
            // 
            resources.ApplyResources(this.textShortDescription, "textShortDescription");
            this.textShortDescription.Name = "textShortDescription";
            // 
            // labelDescription
            // 
            resources.ApplyResources(this.labelDescription, "labelDescription");
            this.labelDescription.Name = "labelDescription";
            // 
            // textDescription
            // 
            resources.ApplyResources(this.textDescription, "textDescription");
            this.textDescription.Name = "textDescription";
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // CreateTickets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textShortDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textService);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.textEmployerID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEmployerID;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.TextBox textService;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textShortDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox textDescription;
        private System.Windows.Forms.Button btnSend;
    }
}