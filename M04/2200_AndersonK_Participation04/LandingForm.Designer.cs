namespace _2200_AndersonK_Participation04
{
    partial class LandingForm
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
            this.LocalBtn = new System.Windows.Forms.Button();
            this.OnlineBtn = new System.Windows.Forms.Button();
            this.ImportedBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocalBtn
            // 
            this.LocalBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LocalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LocalBtn.Location = new System.Drawing.Point(74, 59);
            this.LocalBtn.Margin = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.LocalBtn.Name = "LocalBtn";
            this.LocalBtn.Size = new System.Drawing.Size(287, 127);
            this.LocalBtn.TabIndex = 0;
            this.LocalBtn.Text = "Local Phone Numbers";
            this.LocalBtn.UseVisualStyleBackColor = false;
            this.LocalBtn.Click += new System.EventHandler(this.LocalBtn_Click);
            // 
            // OnlineBtn
            // 
            this.OnlineBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.OnlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.OnlineBtn.Location = new System.Drawing.Point(74, 233);
            this.OnlineBtn.Margin = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.OnlineBtn.Name = "OnlineBtn";
            this.OnlineBtn.Size = new System.Drawing.Size(287, 127);
            this.OnlineBtn.TabIndex = 1;
            this.OnlineBtn.Text = "Online Phone Numbers";
            this.OnlineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.OnlineBtn.UseVisualStyleBackColor = false;
            // 
            // ImportedBtn
            // 
            this.ImportedBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImportedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ImportedBtn.Location = new System.Drawing.Point(461, 59);
            this.ImportedBtn.Margin = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.ImportedBtn.Name = "ImportedBtn";
            this.ImportedBtn.Size = new System.Drawing.Size(287, 127);
            this.ImportedBtn.TabIndex = 2;
            this.ImportedBtn.Text = "Imported Phone Numbers";
            this.ImportedBtn.UseVisualStyleBackColor = false;
            this.ImportedBtn.Click += new System.EventHandler(this.ImportedBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.CloseBtn.Location = new System.Drawing.Point(461, 233);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(287, 127);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ImportedBtn);
            this.Controls.Add(this.OnlineBtn);
            this.Controls.Add(this.LocalBtn);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LocalBtn;
        private System.Windows.Forms.Button OnlineBtn;
        private System.Windows.Forms.Button ImportedBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}

