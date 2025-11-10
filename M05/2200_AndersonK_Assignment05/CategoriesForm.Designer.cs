namespace _2200_AndersonK_Assignment05
{
    partial class CategoriesForm
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
            this.categoriesListView = new System.Windows.Forms.ListView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoriesListView
            // 
            this.categoriesListView.HideSelection = false;
            this.categoriesListView.Location = new System.Drawing.Point(0, 0);
            this.categoriesListView.Name = "categoriesListView";
            this.categoriesListView.Size = new System.Drawing.Size(292, 249);
            this.categoriesListView.TabIndex = 0;
            this.categoriesListView.UseCompatibleStateImageBehavior = false;
            this.categoriesListView.View = System.Windows.Forms.View.Details;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.closeBtn.Location = new System.Drawing.Point(204, 255);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 285);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.categoriesListView);
            this.Name = "CategoriesForm";
            this.Text = "Jelly Belly Categories";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView categoriesListView;
        private System.Windows.Forms.Button closeBtn;
    }
}