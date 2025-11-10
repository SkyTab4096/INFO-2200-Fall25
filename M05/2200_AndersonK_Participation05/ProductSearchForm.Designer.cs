namespace _2200_AndersonK_Participation05
{
    partial class ProductSearchForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIdLbl = new System.Windows.Forms.Label();
            this.deleteProductCB = new System.Windows.Forms.ComboBox();
            this.deleteProductBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.productDescriptionTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 273);
            this.dataGridView1.TabIndex = 28;
            // 
            // productIdLbl
            // 
            this.productIdLbl.AutoSize = true;
            this.productIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productIdLbl.Location = new System.Drawing.Point(333, 357);
            this.productIdLbl.Name = "productIdLbl";
            this.productIdLbl.Size = new System.Drawing.Size(89, 20);
            this.productIdLbl.TabIndex = 27;
            this.productIdLbl.Text = "Product ID:";
            // 
            // deleteProductCB
            // 
            this.deleteProductCB.FormattingEnabled = true;
            this.deleteProductCB.Location = new System.Drawing.Point(428, 357);
            this.deleteProductCB.Name = "deleteProductCB";
            this.deleteProductCB.Size = new System.Drawing.Size(152, 21);
            this.deleteProductCB.TabIndex = 26;
            // 
            // deleteProductBtn
            // 
            this.deleteProductBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteProductBtn.Location = new System.Drawing.Point(586, 348);
            this.deleteProductBtn.Name = "deleteProductBtn";
            this.deleteProductBtn.Size = new System.Drawing.Size(145, 35);
            this.deleteProductBtn.TabIndex = 25;
            this.deleteProductBtn.Text = "Delete Product";
            this.deleteProductBtn.UseVisualStyleBackColor = false;
            this.deleteProductBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addProductBtn.Location = new System.Drawing.Point(586, 281);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(145, 35);
            this.addProductBtn.TabIndex = 24;
            this.addProductBtn.Text = "Add New Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // productDescriptionTxtBox
            // 
            this.productDescriptionTxtBox.Location = new System.Drawing.Point(159, 287);
            this.productDescriptionTxtBox.Name = "productDescriptionTxtBox";
            this.productDescriptionTxtBox.Size = new System.Drawing.Size(267, 20);
            this.productDescriptionTxtBox.TabIndex = 23;
            this.productDescriptionTxtBox.TextChanged += new System.EventHandler(this.productDescriptionTxtBox_TextChanged);
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.descriptionLbl.Location = new System.Drawing.Point(1, 285);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(152, 20);
            this.descriptionLbl.TabIndex = 22;
            this.descriptionLbl.Text = "Product Description:";
            // 
            // ProductSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 405);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.productIdLbl);
            this.Controls.Add(this.deleteProductCB);
            this.Controls.Add(this.deleteProductBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productDescriptionTxtBox);
            this.Controls.Add(this.descriptionLbl);
            this.Name = "ProductSearchForm";
            this.Text = "ProductSearchForm";
            this.Load += new System.EventHandler(this.ProductSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label productIdLbl;
        private System.Windows.Forms.ComboBox deleteProductCB;
        private System.Windows.Forms.Button deleteProductBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.TextBox productDescriptionTxtBox;
        private System.Windows.Forms.Label descriptionLbl;
    }
}