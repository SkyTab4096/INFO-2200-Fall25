namespace _2200_AndersonK_Participation06
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
            this.requestSubmitBtn = new System.Windows.Forms.Button();
            this.requestTxtBox = new System.Windows.Forms.TextBox();
            this.requestLbl = new System.Windows.Forms.Label();
            this.responseGrpBox = new System.Windows.Forms.GroupBox();
            this.responseTxtBox = new System.Windows.Forms.TextBox();
            this.requestGrpBox.SuspendLayout();
            this.responseGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // requestGrpBox
            // 
            this.requestGrpBox.Controls.Add(this.requestSubmitBtn);
            this.requestGrpBox.Controls.Add(this.requestTxtBox);
            this.requestGrpBox.Controls.Add(this.requestLbl);
            this.requestGrpBox.Location = new System.Drawing.Point(13, 13);
            this.requestGrpBox.Name = "requestGrpBox";
            this.requestGrpBox.Size = new System.Drawing.Size(364, 100);
            this.requestGrpBox.TabIndex = 0;
            this.requestGrpBox.TabStop = false;
            this.requestGrpBox.Text = "REQUEST";
            // 
            // requestSubmitBtn
            // 
            this.requestSubmitBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.requestSubmitBtn.Location = new System.Drawing.Point(267, 48);
            this.requestSubmitBtn.Name = "requestSubmitBtn";
            this.requestSubmitBtn.Size = new System.Drawing.Size(91, 23);
            this.requestSubmitBtn.TabIndex = 2;
            this.requestSubmitBtn.Text = "Submit";
            this.requestSubmitBtn.UseVisualStyleBackColor = false;
            this.requestSubmitBtn.Click += new System.EventHandler(this.requestSubmitBtn_Click);
            // 
            // requestTxtBox
            // 
            this.requestTxtBox.Location = new System.Drawing.Point(7, 48);
            this.requestTxtBox.Name = "requestTxtBox";
            this.requestTxtBox.Size = new System.Drawing.Size(254, 20);
            this.requestTxtBox.TabIndex = 1;
            // 
            // requestLbl
            // 
            this.requestLbl.AutoSize = true;
            this.requestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.requestLbl.Location = new System.Drawing.Point(7, 20);
            this.requestLbl.Name = "requestLbl";
            this.requestLbl.Size = new System.Drawing.Size(353, 24);
            this.requestLbl.TabIndex = 0;
            this.requestLbl.Text = "Message the Server (conspiracy or joke):";
            // 
            // responseGrpBox
            // 
            this.responseGrpBox.Controls.Add(this.responseTxtBox);
            this.responseGrpBox.Location = new System.Drawing.Point(13, 133);
            this.responseGrpBox.Name = "responseGrpBox";
            this.responseGrpBox.Size = new System.Drawing.Size(364, 206);
            this.responseGrpBox.TabIndex = 1;
            this.responseGrpBox.TabStop = false;
            this.responseGrpBox.Text = "RESPONSE";
            // 
            // responseTxtBox
            // 
            this.responseTxtBox.Location = new System.Drawing.Point(7, 20);
            this.responseTxtBox.Multiline = true;
            this.responseTxtBox.Name = "responseTxtBox";
            this.responseTxtBox.ReadOnly = true;
            this.responseTxtBox.Size = new System.Drawing.Size(351, 180);
            this.responseTxtBox.TabIndex = 0;
            // 
            // landingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 355);
            this.Controls.Add(this.responseGrpBox);
            this.Controls.Add(this.requestGrpBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "landingForm";
            this.Text = "Ask the Server";
            this.Load += new System.EventHandler(this.landingForm_Load);
            this.requestGrpBox.ResumeLayout(false);
            this.requestGrpBox.PerformLayout();
            this.responseGrpBox.ResumeLayout(false);
            this.responseGrpBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox requestGrpBox;
        private System.Windows.Forms.Button requestSubmitBtn;
        private System.Windows.Forms.TextBox requestTxtBox;
        private System.Windows.Forms.Label requestLbl;
        private System.Windows.Forms.GroupBox responseGrpBox;
        private System.Windows.Forms.TextBox responseTxtBox;
    }
}

