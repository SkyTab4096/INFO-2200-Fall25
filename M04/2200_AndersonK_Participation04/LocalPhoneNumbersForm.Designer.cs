namespace _2200_AndersonK_Participation04
{
    partial class LocalPhoneNumbersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPhoneNumbersForm));
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.LastNameSortBtn = new System.Windows.Forms.Button();
            this.AverageAgeSortBtn = new System.Windows.Forms.Button();
            this.Over30SortBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.localPhoneListDbDataSet = new _2200_AndersonK_Participation04.LocalPhoneListDbDataSet();
            this.phoneListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneListTableAdapter = new _2200_AndersonK_Participation04.LocalPhoneListDbDataSetTableAdapters.PhoneListTableAdapter();
            this.tableAdapterManager = new _2200_AndersonK_Participation04.LocalPhoneListDbDataSetTableAdapters.TableAdapterManager();
            this.phoneListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.phoneListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.phoneListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingNavigator)).BeginInit();
            this.phoneListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchBox.Controls.Add(this.SearchBtn);
            this.SearchBox.Controls.Add(this.SearchTextBox);
            this.SearchBox.Controls.Add(this.SearchLabel);
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SearchBox.Location = new System.Drawing.Point(41, 261);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(380, 185);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SearchBtn.Location = new System.Drawing.Point(16, 110);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(358, 52);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(163, 53);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(211, 38);
            this.SearchTextBox.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(10, 60);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(147, 31);
            this.SearchLabel.TabIndex = 0;
            this.SearchLabel.Text = "First Name";
            // 
            // LastNameSortBtn
            // 
            this.LastNameSortBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.LastNameSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.LastNameSortBtn.Location = new System.Drawing.Point(440, 268);
            this.LastNameSortBtn.Name = "LastNameSortBtn";
            this.LastNameSortBtn.Size = new System.Drawing.Size(160, 72);
            this.LastNameSortBtn.TabIndex = 1;
            this.LastNameSortBtn.Text = "Sort by Last Name";
            this.LastNameSortBtn.UseVisualStyleBackColor = false;
            this.LastNameSortBtn.Click += new System.EventHandler(this.LastNameSortBtn_Click);
            // 
            // AverageAgeSortBtn
            // 
            this.AverageAgeSortBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AverageAgeSortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.AverageAgeSortBtn.Location = new System.Drawing.Point(440, 346);
            this.AverageAgeSortBtn.Name = "AverageAgeSortBtn";
            this.AverageAgeSortBtn.Size = new System.Drawing.Size(160, 69);
            this.AverageAgeSortBtn.TabIndex = 2;
            this.AverageAgeSortBtn.Text = "Average Age";
            this.AverageAgeSortBtn.UseVisualStyleBackColor = false;
            this.AverageAgeSortBtn.Click += new System.EventHandler(this.AverageAgeSortBtn_Click);
            // 
            // Over30SortBtn
            // 
            this.Over30SortBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Over30SortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.Over30SortBtn.Location = new System.Drawing.Point(610, 268);
            this.Over30SortBtn.Name = "Over30SortBtn";
            this.Over30SortBtn.Size = new System.Drawing.Size(161, 76);
            this.Over30SortBtn.TabIndex = 3;
            this.Over30SortBtn.Text = "Age > 30";
            this.Over30SortBtn.UseVisualStyleBackColor = false;
            this.Over30SortBtn.Click += new System.EventHandler(this.Over30SortBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ClearBtn.Location = new System.Drawing.Point(610, 350);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(161, 65);
            this.ClearBtn.TabIndex = 4;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // localPhoneListDbDataSet
            // 
            this.localPhoneListDbDataSet.DataSetName = "LocalPhoneListDbDataSet";
            this.localPhoneListDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneListBindingSource
            // 
            this.phoneListBindingSource.DataMember = "PhoneList";
            this.phoneListBindingSource.DataSource = this.localPhoneListDbDataSet;
            // 
            // phoneListTableAdapter
            // 
            this.phoneListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PhoneListTableAdapter = this.phoneListTableAdapter;
            this.tableAdapterManager.UpdateOrder = _2200_AndersonK_Participation04.LocalPhoneListDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // phoneListBindingNavigator
            // 
            this.phoneListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.phoneListBindingNavigator.BindingSource = this.phoneListBindingSource;
            this.phoneListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.phoneListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.phoneListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.phoneListBindingNavigatorSaveItem});
            this.phoneListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.phoneListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.phoneListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.phoneListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.phoneListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.phoneListBindingNavigator.Name = "phoneListBindingNavigator";
            this.phoneListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.phoneListBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.phoneListBindingNavigator.TabIndex = 5;
            this.phoneListBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // phoneListBindingNavigatorSaveItem
            // 
            this.phoneListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.phoneListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneListBindingNavigatorSaveItem.Image")));
            this.phoneListBindingNavigatorSaveItem.Name = "phoneListBindingNavigatorSaveItem";
            this.phoneListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.phoneListBindingNavigatorSaveItem.Text = "Save Data";
            this.phoneListBindingNavigatorSaveItem.Click += new System.EventHandler(this.phoneListBindingNavigatorSaveItem_Click);
            // 
            // phoneListDataGridView
            // 
            this.phoneListDataGridView.AllowUserToOrderColumns = true;
            this.phoneListDataGridView.AutoGenerateColumns = false;
            this.phoneListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.phoneListDataGridView.DataSource = this.phoneListBindingSource;
            this.phoneListDataGridView.Location = new System.Drawing.Point(41, 28);
            this.phoneListDataGridView.Name = "phoneListDataGridView";
            this.phoneListDataGridView.Size = new System.Drawing.Size(730, 220);
            this.phoneListDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
            this.dataGridViewTextBoxColumn1.HeaderText = "PersonId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn5.HeaderText = "Age";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 37;
            // 
            // LocalPhoneNumbersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.phoneListDataGridView);
            this.Controls.Add(this.phoneListBindingNavigator);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.Over30SortBtn);
            this.Controls.Add(this.AverageAgeSortBtn);
            this.Controls.Add(this.LastNameSortBtn);
            this.Controls.Add(this.SearchBox);
            this.Name = "LocalPhoneNumbersForm";
            this.Text = "LocalPhoneNumbersForm";
            this.Load += new System.EventHandler(this.LocalPhoneNumbersForm_Load);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localPhoneListDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListBindingNavigator)).EndInit();
            this.phoneListBindingNavigator.ResumeLayout(false);
            this.phoneListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button LastNameSortBtn;
        private System.Windows.Forms.Button AverageAgeSortBtn;
        private System.Windows.Forms.Button Over30SortBtn;
        private System.Windows.Forms.Button ClearBtn;
        private LocalPhoneListDbDataSet localPhoneListDbDataSet;
        private System.Windows.Forms.BindingSource phoneListBindingSource;
        private LocalPhoneListDbDataSetTableAdapters.PhoneListTableAdapter phoneListTableAdapter;
        private LocalPhoneListDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phoneListBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton phoneListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phoneListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}