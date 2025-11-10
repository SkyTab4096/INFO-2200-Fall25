namespace _2200_AndersonK_Participation05
{
    partial class AddProductForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.newTxtBox = new System.Windows.Forms.TextBox();
            this.newLbl = new System.Windows.Forms.Label();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.priceTxtBx = new System.Windows.Forms.TextBox();
            this.priceLbl = new System.Windows.Forms.Label();
            this.unitsTxtBx = new System.Windows.Forms.TextBox();
            this.unitsLbl = new System.Windows.Forms.Label();
            this.descriptionTxtBox = new System.Windows.Forms.TextBox();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.productNumberTxtBx = new System.Windows.Forms.TextBox();
            this.productNumberLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cancelBtn.Location = new System.Drawing.Point(398, 327);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(131, 32);
            this.cancelBtn.TabIndex = 41;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addBtn.Location = new System.Drawing.Point(172, 230);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(309, 48);
            this.addBtn.TabIndex = 40;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // newTxtBox
            // 
            this.newTxtBox.Location = new System.Drawing.Point(375, 177);
            this.newTxtBox.Name = "newTxtBox";
            this.newTxtBox.Size = new System.Drawing.Size(106, 20);
            this.newTxtBox.TabIndex = 39;
            this.newTxtBox.Visible = false;
            // 
            // newLbl
            // 
            this.newLbl.AutoSize = true;
            this.newLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newLbl.Location = new System.Drawing.Point(312, 174);
            this.newLbl.Name = "newLbl";
            this.newLbl.Size = new System.Drawing.Size(57, 25);
            this.newLbl.TabIndex = 38;
            this.newLbl.Text = "New:";
            this.newLbl.Visible = false;
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(172, 174);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(121, 21);
            this.categoryCB.TabIndex = 37;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.categoryLbl.Location = new System.Drawing.Point(73, 172);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(92, 25);
            this.categoryLbl.TabIndex = 36;
            this.categoryLbl.Text = "Category";
            // 
            // priceTxtBx
            // 
            this.priceTxtBx.Location = new System.Drawing.Point(172, 134);
            this.priceTxtBx.Name = "priceTxtBx";
            this.priceTxtBx.Size = new System.Drawing.Size(309, 20);
            this.priceTxtBx.TabIndex = 35;
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.priceLbl.Location = new System.Drawing.Point(109, 129);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(56, 25);
            this.priceLbl.TabIndex = 34;
            this.priceLbl.Text = "Price";
            // 
            // unitsTxtBx
            // 
            this.unitsTxtBx.Location = new System.Drawing.Point(172, 93);
            this.unitsTxtBx.Name = "unitsTxtBx";
            this.unitsTxtBx.Size = new System.Drawing.Size(309, 20);
            this.unitsTxtBx.TabIndex = 33;
            // 
            // unitsLbl
            // 
            this.unitsLbl.AutoSize = true;
            this.unitsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.unitsLbl.Location = new System.Drawing.Point(30, 88);
            this.unitsLbl.Name = "unitsLbl";
            this.unitsLbl.Size = new System.Drawing.Size(135, 25);
            this.unitsLbl.TabIndex = 32;
            this.unitsLbl.Text = "Units on Hand";
            // 
            // descriptionTxtBox
            // 
            this.descriptionTxtBox.Location = new System.Drawing.Point(172, 54);
            this.descriptionTxtBox.Name = "descriptionTxtBox";
            this.descriptionTxtBox.Size = new System.Drawing.Size(309, 20);
            this.descriptionTxtBox.TabIndex = 31;
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.descriptionLbl.Location = new System.Drawing.Point(56, 49);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(109, 25);
            this.descriptionLbl.TabIndex = 30;
            this.descriptionLbl.Text = "Description";
            // 
            // productNumberTxtBx
            // 
            this.productNumberTxtBx.Location = new System.Drawing.Point(172, 13);
            this.productNumberTxtBx.Name = "productNumberTxtBx";
            this.productNumberTxtBx.Size = new System.Drawing.Size(309, 20);
            this.productNumberTxtBx.TabIndex = 29;
            // 
            // productNumberLbl
            // 
            this.productNumberLbl.AutoSize = true;
            this.productNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.productNumberLbl.Location = new System.Drawing.Point(12, 9);
            this.productNumberLbl.Name = "productNumberLbl";
            this.productNumberLbl.Size = new System.Drawing.Size(153, 25);
            this.productNumberLbl.TabIndex = 28;
            this.productNumberLbl.Text = "Product Number";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 362);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.newTxtBox);
            this.Controls.Add(this.newLbl);
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.priceTxtBx);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.unitsTxtBx);
            this.Controls.Add(this.unitsLbl);
            this.Controls.Add(this.descriptionTxtBox);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.productNumberTxtBx);
            this.Controls.Add(this.productNumberLbl);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox newTxtBox;
        private System.Windows.Forms.Label newLbl;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.TextBox priceTxtBx;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox unitsTxtBx;
        private System.Windows.Forms.Label unitsLbl;
        private System.Windows.Forms.TextBox descriptionTxtBox;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.TextBox productNumberTxtBx;
        private System.Windows.Forms.Label productNumberLbl;
    }
}