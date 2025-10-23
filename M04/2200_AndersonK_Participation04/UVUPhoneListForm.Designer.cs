namespace _2200_AndersonK_Participation04
{
    partial class UVUPhoneListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UVUPhoneListForm));
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label mailStopLabel;
            System.Windows.Forms.Label officeLocationLabel;
            System.Windows.Forms.Label uvuPhoneDirectoryIdLabel;
            this.uvuPhoneDirectoryId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uVUPhoneNumsDataSet = new _2200_AndersonK_Participation04.UVUPhoneNumsDataSet();
            this.uvuPhoneDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uvuPhoneDirectoryTableAdapter = new _2200_AndersonK_Participation04.UVUPhoneNumsDataSetTableAdapters.UvuPhoneDirectoryTableAdapter();
            this.tableAdapterManager = new _2200_AndersonK_Participation04.UVUPhoneNumsDataSetTableAdapters.TableAdapterManager();
            this.uvuPhoneDirectoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uvuPhoneDirectoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.mailStopTextBox = new System.Windows.Forms.TextBox();
            this.officeLocationTextBox = new System.Windows.Forms.TextBox();
            this.uvuPhoneDirectoryIdLabel1 = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            mailStopLabel = new System.Windows.Forms.Label();
            officeLocationLabel = new System.Windows.Forms.Label();
            uvuPhoneDirectoryIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingNavigator)).BeginInit();
            this.uvuPhoneDirectoryBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // uvuPhoneDirectoryId
            // 
            this.uvuPhoneDirectoryId.AutoSize = true;
            this.uvuPhoneDirectoryId.Location = new System.Drawing.Point(12, 9);
            this.uvuPhoneDirectoryId.Name = "uvuPhoneDirectoryId";
            this.uvuPhoneDirectoryId.Size = new System.Drawing.Size(124, 13);
            this.uvuPhoneDirectoryId.TabIndex = 0;
            this.uvuPhoneDirectoryId.Text = "UVU Phone Directory Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // uVUPhoneNumsDataSet
            // 
            this.uVUPhoneNumsDataSet.DataSetName = "UVUPhoneNumsDataSet";
            this.uVUPhoneNumsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uvuPhoneDirectoryBindingSource
            // 
            this.uvuPhoneDirectoryBindingSource.DataMember = "UvuPhoneDirectory";
            this.uvuPhoneDirectoryBindingSource.DataSource = this.uVUPhoneNumsDataSet;
            // 
            // uvuPhoneDirectoryTableAdapter
            // 
            this.uvuPhoneDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = _2200_AndersonK_Participation04.UVUPhoneNumsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UvuPhoneDirectoryTableAdapter = this.uvuPhoneDirectoryTableAdapter;
            // 
            // uvuPhoneDirectoryBindingNavigator
            // 
            this.uvuPhoneDirectoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uvuPhoneDirectoryBindingNavigator.BindingSource = this.uvuPhoneDirectoryBindingSource;
            this.uvuPhoneDirectoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uvuPhoneDirectoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uvuPhoneDirectoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uvuPhoneDirectoryBindingNavigatorSaveItem});
            this.uvuPhoneDirectoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uvuPhoneDirectoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uvuPhoneDirectoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uvuPhoneDirectoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uvuPhoneDirectoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uvuPhoneDirectoryBindingNavigator.Name = "uvuPhoneDirectoryBindingNavigator";
            this.uvuPhoneDirectoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uvuPhoneDirectoryBindingNavigator.Size = new System.Drawing.Size(401, 25);
            this.uvuPhoneDirectoryBindingNavigator.TabIndex = 12;
            this.uvuPhoneDirectoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // uvuPhoneDirectoryBindingNavigatorSaveItem
            // 
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uvuPhoneDirectoryBindingNavigatorSaveItem.Image")));
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Name = "uvuPhoneDirectoryBindingNavigatorSaveItem";
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Text = "Save Data";
            this.uvuPhoneDirectoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.uvuPhoneDirectoryBindingNavigatorSaveItem_Click);
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(12, 63);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 14;
            departmentLabel.Text = "Department:";
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(139, 60);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(250, 20);
            this.departmentTextBox.TabIndex = 15;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(12, 89);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 16;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(139, 86);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(250, 20);
            this.phoneNumberTextBox.TabIndex = 17;
            // 
            // mailStopLabel
            // 
            mailStopLabel.AutoSize = true;
            mailStopLabel.Location = new System.Drawing.Point(12, 115);
            mailStopLabel.Name = "mailStopLabel";
            mailStopLabel.Size = new System.Drawing.Size(54, 13);
            mailStopLabel.TabIndex = 18;
            mailStopLabel.Text = "Mail Stop:";
            // 
            // mailStopTextBox
            // 
            this.mailStopTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "MailStop", true));
            this.mailStopTextBox.Location = new System.Drawing.Point(139, 112);
            this.mailStopTextBox.Name = "mailStopTextBox";
            this.mailStopTextBox.Size = new System.Drawing.Size(250, 20);
            this.mailStopTextBox.TabIndex = 19;
            // 
            // officeLocationLabel
            // 
            officeLocationLabel.AutoSize = true;
            officeLocationLabel.Location = new System.Drawing.Point(12, 141);
            officeLocationLabel.Name = "officeLocationLabel";
            officeLocationLabel.Size = new System.Drawing.Size(82, 13);
            officeLocationLabel.TabIndex = 20;
            officeLocationLabel.Text = "Office Location:";
            // 
            // officeLocationTextBox
            // 
            this.officeLocationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "OfficeLocation", true));
            this.officeLocationTextBox.Location = new System.Drawing.Point(139, 138);
            this.officeLocationTextBox.Name = "officeLocationTextBox";
            this.officeLocationTextBox.Size = new System.Drawing.Size(250, 20);
            this.officeLocationTextBox.TabIndex = 21;
            // 
            // uvuPhoneDirectoryIdLabel
            // 
            uvuPhoneDirectoryIdLabel.AutoSize = true;
            uvuPhoneDirectoryIdLabel.Location = new System.Drawing.Point(12, 37);
            uvuPhoneDirectoryIdLabel.Name = "uvuPhoneDirectoryIdLabel";
            uvuPhoneDirectoryIdLabel.Size = new System.Drawing.Size(121, 13);
            uvuPhoneDirectoryIdLabel.TabIndex = 21;
            uvuPhoneDirectoryIdLabel.Text = "Uvu Phone Directory Id:";
            // 
            // uvuPhoneDirectoryIdLabel1
            // 
            this.uvuPhoneDirectoryIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uvuPhoneDirectoryBindingSource, "UvuPhoneDirectoryId", true));
            this.uvuPhoneDirectoryIdLabel1.Location = new System.Drawing.Point(139, 37);
            this.uvuPhoneDirectoryIdLabel1.Name = "uvuPhoneDirectoryIdLabel1";
            this.uvuPhoneDirectoryIdLabel1.Size = new System.Drawing.Size(100, 23);
            this.uvuPhoneDirectoryIdLabel1.TabIndex = 22;
            this.uvuPhoneDirectoryIdLabel1.Text = "label2";
            // 
            // UVUPhoneListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 171);
            this.Controls.Add(uvuPhoneDirectoryIdLabel);
            this.Controls.Add(this.uvuPhoneDirectoryIdLabel1);
            this.Controls.Add(departmentLabel);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(mailStopLabel);
            this.Controls.Add(this.mailStopTextBox);
            this.Controls.Add(officeLocationLabel);
            this.Controls.Add(this.officeLocationTextBox);
            this.Controls.Add(this.uvuPhoneDirectoryBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uvuPhoneDirectoryId);
            this.Name = "UVUPhoneListForm";
            this.Text = "UVUPhoneListForm";
            this.Load += new System.EventHandler(this.uvuPhoneDirectoryIdLbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvuPhoneDirectoryBindingNavigator)).EndInit();
            this.uvuPhoneDirectoryBindingNavigator.ResumeLayout(false);
            this.uvuPhoneDirectoryBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uvuPhoneDirectoryId;
        private System.Windows.Forms.Label label1;
        private UVUPhoneNumsDataSet uVUPhoneNumsDataSet;
        private System.Windows.Forms.BindingSource uvuPhoneDirectoryBindingSource;
        private UVUPhoneNumsDataSetTableAdapters.UvuPhoneDirectoryTableAdapter uvuPhoneDirectoryTableAdapter;
        private UVUPhoneNumsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uvuPhoneDirectoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uvuPhoneDirectoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox mailStopTextBox;
        private System.Windows.Forms.TextBox officeLocationTextBox;
        private System.Windows.Forms.Label uvuPhoneDirectoryIdLabel1;
    }
}