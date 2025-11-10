namespace _2200_AndersonK_Participation05
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
            this.categoriesLstView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // categoriesLstView
            // 
            this.categoriesLstView.HideSelection = false;
            this.categoriesLstView.Location = new System.Drawing.Point(1, 1);
            this.categoriesLstView.Name = "categoriesLstView";
            this.categoriesLstView.Size = new System.Drawing.Size(798, 449);
            this.categoriesLstView.TabIndex = 2;
            this.categoriesLstView.UseCompatibleStateImageBehavior = false;
            this.categoriesLstView.View = System.Windows.Forms.View.Details;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoriesLstView);
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView categoriesLstView;
    }
}