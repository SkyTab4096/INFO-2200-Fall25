namespace ClientApplication
{
    partial class landingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landingForm));
            this.requestGrpBox = new System.Windows.Forms.GroupBox();
            this.requestLbl = new System.Windows.Forms.Label();
            this.requestTxtBox = new System.Windows.Forms.TextBox();
            this.requestBtn = new System.Windows.Forms.Button();
            this.responseGrpBox = new System.Windows.Forms.GroupBox();
            this.responseTxtBox = new System.Windows.Forms.TextBox();
            this.requestGrpBox.SuspendLayout();
            this.responseGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestGrpBox
            // 
            this.requestGrpBox.Controls.Add(this.requestBtn);
            this.requestGrpBox.Controls.Add(this.requestTxtBox);
            this.requestGrpBox.Controls.Add(this.requestLbl);
            this.requestGrpBox.Location = new System.Drawing.Point(13, 13);
            this.requestGrpBox.Name = "requestGrpBox";
            this.requestGrpBox.Size = new System.Drawing.Size(341, 100);
            this.requestGrpBox.TabIndex = 0;
            this.requestGrpBox.TabStop = false;
            this.requestGrpBox.Text = "REQUEST";
            // 
            // requestLbl
            // 
            this.requestLbl.AutoSize = true;
            this.requestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.requestLbl.Location = new System.Drawing.Point(7, 20);
            this.requestLbl.Name = "requestLbl";
            this.requestLbl.Size = new System.Drawing.Size(328, 20);
            this.requestLbl.TabIndex = 0;
            this.requestLbl.Text = "Message the Server (UVUFact or UVUMajor)";
            // 
            // requestTxtBox
            // 
            this.requestTxtBox.Location = new System.Drawing.Point(11, 48);
            this.requestTxtBox.Name = "requestTxtBox";
            this.requestTxtBox.Size = new System.Drawing.Size(233, 20);
            this.requestTxtBox.TabIndex = 1;
            // 
            // requestBtn
            // 
            this.requestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.requestBtn.Location = new System.Drawing.Point(251, 44);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(84, 23);
            this.requestBtn.TabIndex = 2;
            this.requestBtn.Text = "Submit";
            this.requestBtn.UseVisualStyleBackColor = true;
            this.requestBtn.Click += new System.EventHandler(this.requestBtn_Click);
            // 
            // responseGrpBox
            // 
            this.responseGrpBox.Controls.Add(this.responseTxtBox);
            this.responseGrpBox.Location = new System.Drawing.Point(13, 129);
            this.responseGrpBox.Name = "responseGrpBox";
            this.responseGrpBox.Size = new System.Drawing.Size(341, 223);
            this.responseGrpBox.TabIndex = 1;
            this.responseGrpBox.TabStop = false;
            this.responseGrpBox.Text = "RESPONSE";
            // 
            // responseTxtBox
            // 
            this.responseTxtBox.Location = new System.Drawing.Point(11, 29);
            this.responseTxtBox.Multiline = true;
            this.responseTxtBox.Name = "responseTxtBox";
            this.responseTxtBox.ReadOnly = true;
            this.responseTxtBox.Size = new System.Drawing.Size(314, 188);
            this.responseTxtBox.TabIndex = 0;
            // 
            // landingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 362);
            this.Controls.Add(this.responseGrpBox);
            this.Controls.Add(this.requestGrpBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "landingForm";
            this.Text = "Ask the Server";
            this.requestGrpBox.ResumeLayout(false);
            this.requestGrpBox.PerformLayout();
            this.responseGrpBox.ResumeLayout(false);
            this.responseGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox requestGrpBox;
        private System.Windows.Forms.Label requestLbl;
        private System.Windows.Forms.Button requestBtn;
        private System.Windows.Forms.TextBox requestTxtBox;
        private System.Windows.Forms.GroupBox responseGrpBox;
        private System.Windows.Forms.TextBox responseTxtBox;
    }
}

