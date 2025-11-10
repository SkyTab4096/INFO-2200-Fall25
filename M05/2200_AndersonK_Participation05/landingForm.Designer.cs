namespace _2200_AndersonK_Participation05
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
            this.groupByBtn = new System.Windows.Forms.Button();
            this.productSearchBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupByBtn
            // 
            this.groupByBtn.BackColor = System.Drawing.SystemColors.Control;
            this.groupByBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupByBtn.ForeColor = System.Drawing.Color.Black;
            this.groupByBtn.Location = new System.Drawing.Point(248, 357);
            this.groupByBtn.Margin = new System.Windows.Forms.Padding(0);
            this.groupByBtn.Name = "groupByBtn";
            this.groupByBtn.Size = new System.Drawing.Size(193, 58);
            this.groupByBtn.TabIndex = 6;
            this.groupByBtn.Text = "Group By Category";
            this.groupByBtn.UseVisualStyleBackColor = false;
            this.groupByBtn.Click += new System.EventHandler(this.groupByBtn_Click);
            // 
            // productSearchBtn
            // 
            this.productSearchBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.productSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.productSearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.productSearchBtn.Location = new System.Drawing.Point(60, 357);
            this.productSearchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.productSearchBtn.Name = "productSearchBtn";
            this.productSearchBtn.Size = new System.Drawing.Size(165, 58);
            this.productSearchBtn.TabIndex = 5;
            this.productSearchBtn.Text = "Product Search";
            this.productSearchBtn.UseVisualStyleBackColor = false;
            this.productSearchBtn.Click += new System.EventHandler(this.productSearchBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_2200_AndersonK_Participation05.Properties.Resources.before;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(517, 646);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // landingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 446);
            this.Controls.Add(this.groupByBtn);
            this.Controls.Add(this.productSearchBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "landingForm";
            this.Text = "landingForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button groupByBtn;
        private System.Windows.Forms.Button productSearchBtn;
    }
}