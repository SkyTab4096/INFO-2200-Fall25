namespace _2200_AndersonK_Assignment04
{
    partial class MoviesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
            this.movieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.movieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.alphaSortBtn = new System.Windows.Forms.Button();
            this.rAlphaSortBtn = new System.Windows.Forms.Button();
            this.first20Btn = new System.Windows.Forms.Button();
            this.categoriesBtn = new System.Windows.Forms.Button();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iNFO2200_CrandallSayDataSet = new _2200_AndersonK_Assignment04.INFO2200_CrandallSayDataSet();
            this.movieTableAdapter = new _2200_AndersonK_Assignment04.INFO2200_CrandallSayDataSetTableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new _2200_AndersonK_Assignment04.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).BeginInit();
            this.movieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // movieBindingNavigator
            // 
            this.movieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movieBindingNavigator.BindingSource = this.movieBindingSource;
            this.movieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.movieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.movieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.movieBindingNavigatorSaveItem});
            this.movieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.movieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.movieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.movieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.movieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.movieBindingNavigator.Name = "movieBindingNavigator";
            this.movieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.movieBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.movieBindingNavigator.TabIndex = 0;
            this.movieBindingNavigator.Text = "bindingNavigator1";
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
            // movieBindingNavigatorSaveItem
            // 
            this.movieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorSaveItem.Image")));
            this.movieBindingNavigatorSaveItem.Name = "movieBindingNavigatorSaveItem";
            this.movieBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.movieBindingNavigatorSaveItem.Text = "Save Data";
            this.movieBindingNavigatorSaveItem.Click += new System.EventHandler(this.movieBindingNavigatorSaveItem_Click);
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.movieDataGridView.DataSource = this.movieBindingSource;
            this.movieDataGridView.Location = new System.Drawing.Point(12, 28);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.Size = new System.Drawing.Size(776, 410);
            this.movieDataGridView.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.searchTxtBox);
            this.searchBox.Controls.Add(this.searchLbl);
            this.searchBox.Location = new System.Drawing.Point(96, 444);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(594, 58);
            this.searchBox.TabIndex = 2;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search";
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.Location = new System.Drawing.Point(76, 20);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(59, 13);
            this.searchLbl.TabIndex = 0;
            this.searchLbl.Text = "Movie Title";
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(141, 17);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(366, 20);
            this.searchTxtBox.TabIndex = 1;
            // 
            // alphaSortBtn
            // 
            this.alphaSortBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.alphaSortBtn.Location = new System.Drawing.Point(96, 509);
            this.alphaSortBtn.Name = "alphaSortBtn";
            this.alphaSortBtn.Size = new System.Drawing.Size(121, 55);
            this.alphaSortBtn.TabIndex = 3;
            this.alphaSortBtn.Text = "Sort A-Z by ID";
            this.alphaSortBtn.UseVisualStyleBackColor = false;
            this.alphaSortBtn.Click += new System.EventHandler(this.alphaSortBtn_Click);
            // 
            // rAlphaSortBtn
            // 
            this.rAlphaSortBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rAlphaSortBtn.Location = new System.Drawing.Point(252, 508);
            this.rAlphaSortBtn.Name = "rAlphaSortBtn";
            this.rAlphaSortBtn.Size = new System.Drawing.Size(121, 55);
            this.rAlphaSortBtn.TabIndex = 4;
            this.rAlphaSortBtn.Text = "Sort Z-A by ID";
            this.rAlphaSortBtn.UseVisualStyleBackColor = false;
            this.rAlphaSortBtn.Click += new System.EventHandler(this.rAlphaSortBtn_Click);
            // 
            // first20Btn
            // 
            this.first20Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.first20Btn.Location = new System.Drawing.Point(408, 509);
            this.first20Btn.Name = "first20Btn";
            this.first20Btn.Size = new System.Drawing.Size(121, 55);
            this.first20Btn.TabIndex = 5;
            this.first20Btn.Text = "Search First 20 (by ID)";
            this.first20Btn.UseVisualStyleBackColor = false;
            this.first20Btn.Click += new System.EventHandler(this.first20Btn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.categoriesBtn.Location = new System.Drawing.Point(569, 508);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(121, 55);
            this.categoriesBtn.TabIndex = 6;
            this.categoriesBtn.Text = "Display Count of Movie Categories";
            this.categoriesBtn.UseVisualStyleBackColor = false;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.iNFO2200_CrandallSayDataSet;
            // 
            // iNFO2200_CrandallSayDataSet
            // 
            this.iNFO2200_CrandallSayDataSet.DataSetName = "INFO2200_CrandallSayDataSet";
            this.iNFO2200_CrandallSayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = _2200_AndersonK_Assignment04.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "movieID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Movie ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "movieTitle";
            this.dataGridViewTextBoxColumn2.HeaderText = "Movie Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 373;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn3.HeaderText = "Category";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.categoriesBtn);
            this.Controls.Add(this.first20Btn);
            this.Controls.Add(this.rAlphaSortBtn);
            this.Controls.Add(this.alphaSortBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.movieBindingNavigator);
            this.Name = "MoviesForm";
            this.Text = "Movies Form";
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).EndInit();
            this.movieBindingNavigator.ResumeLayout(false);
            this.movieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private INFO2200_CrandallSayDataSet iNFO2200_CrandallSayDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private INFO2200_CrandallSayDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator movieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton movieBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Button alphaSortBtn;
        private System.Windows.Forms.Button rAlphaSortBtn;
        private System.Windows.Forms.Button first20Btn;
        private System.Windows.Forms.Button categoriesBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

