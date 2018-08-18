namespace EMUA_Admin
{
    partial class report_template_generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report_template_generator));
            this.report_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listbox_templates = new System.Windows.Forms.ListBox();
            this.report_TemplatesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.report_TemplatesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.report_TemplatesDataGridView = new System.Windows.Forms.DataGridView();
            this.report_TemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMUA_dbDataSet = new EMUA_Admin.EMUA_dbDataSet();
            this.report_TemplatesTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.Report_TemplatesTableAdapter();
            this.tableAdapterManager = new EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager();
            this.set_defualt_btn = new System.Windows.Forms.Button();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingsTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.SettingsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesBindingNavigator)).BeginInit();
            this.report_TemplatesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report_text
            // 
            this.report_text.Enabled = false;
            this.report_text.Location = new System.Drawing.Point(12, 328);
            this.report_text.Name = "report_text";
            this.report_text.Size = new System.Drawing.Size(376, 224);
            this.report_text.TabIndex = 2;
            this.report_text.Text = "";
            this.report_text.TextChanged += new System.EventHandler(this.report_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Report:";
            // 
            // listbox_templates
            // 
            this.listbox_templates.Enabled = false;
            this.listbox_templates.FormattingEnabled = true;
            this.listbox_templates.Items.AddRange(new object[] {
            "App Name",
            "Employ Full Name",
            "Employ First Name",
            "Employ Second Name",
            "Employ Third Name",
            "Employ Time Down",
            "Employ Time Extra",
            "Employ Time Down Count",
            "Employ Time Extra Count",
            "Employ Notes",
            "Employ Total Salary"});
            this.listbox_templates.Location = new System.Drawing.Point(394, 328);
            this.listbox_templates.Name = "listbox_templates";
            this.listbox_templates.Size = new System.Drawing.Size(325, 199);
            this.listbox_templates.TabIndex = 4;
            this.listbox_templates.SelectedIndexChanged += new System.EventHandler(this.listbox_templates_SelectedIndexChanged);
            this.listbox_templates.SelectedValueChanged += new System.EventHandler(this.listbox_templates_SelectedValueChanged);
            // 
            // report_TemplatesBindingNavigator
            // 
            this.report_TemplatesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.report_TemplatesBindingNavigator.BindingSource = this.report_TemplatesBindingSource;
            this.report_TemplatesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.report_TemplatesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.report_TemplatesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.report_TemplatesBindingNavigatorSaveItem});
            this.report_TemplatesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.report_TemplatesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.report_TemplatesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.report_TemplatesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.report_TemplatesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.report_TemplatesBindingNavigator.Name = "report_TemplatesBindingNavigator";
            this.report_TemplatesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.report_TemplatesBindingNavigator.Size = new System.Drawing.Size(731, 25);
            this.report_TemplatesBindingNavigator.TabIndex = 5;
            this.report_TemplatesBindingNavigator.Text = "bindingNavigator1";
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
            // report_TemplatesBindingNavigatorSaveItem
            // 
            this.report_TemplatesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.report_TemplatesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("report_TemplatesBindingNavigatorSaveItem.Image")));
            this.report_TemplatesBindingNavigatorSaveItem.Name = "report_TemplatesBindingNavigatorSaveItem";
            this.report_TemplatesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.report_TemplatesBindingNavigatorSaveItem.Text = "Save Data";
            this.report_TemplatesBindingNavigatorSaveItem.Click += new System.EventHandler(this.report_TemplatesBindingNavigatorSaveItem_Click_1);
            // 
            // report_TemplatesDataGridView
            // 
            this.report_TemplatesDataGridView.AutoGenerateColumns = false;
            this.report_TemplatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.report_TemplatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.reportDataGridViewTextBoxColumn});
            this.report_TemplatesDataGridView.DataSource = this.report_TemplatesBindingSource;
            this.report_TemplatesDataGridView.Location = new System.Drawing.Point(15, 28);
            this.report_TemplatesDataGridView.Name = "report_TemplatesDataGridView";
            this.report_TemplatesDataGridView.Size = new System.Drawing.Size(704, 281);
            this.report_TemplatesDataGridView.TabIndex = 6;
            this.report_TemplatesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.report_TemplatesDataGridView.CurrentCellChanged += new System.EventHandler(this.report_TemplatesDataGridView_CurrentCellChanged);
            this.report_TemplatesDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.report_TemplatesDataGridView_RowEnter_1);
            // 
            // report_TemplatesBindingSource
            // 
            this.report_TemplatesBindingSource.DataMember = "Report_Templates";
            this.report_TemplatesBindingSource.DataSource = this.eMUA_dbDataSet;
            // 
            // eMUA_dbDataSet
            // 
            this.eMUA_dbDataSet.DataSetName = "EMUA_dbDataSet";
            this.eMUA_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // report_TemplatesTableAdapter
            // 
            this.report_TemplatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DaysTableAdapter = null;
            this.tableAdapterManager.EmploysTableAdapter = null;
            this.tableAdapterManager.Report_TemplatesTableAdapter = this.report_TemplatesTableAdapter;
            this.tableAdapterManager.SettingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // set_defualt_btn
            // 
            this.set_defualt_btn.Enabled = false;
            this.set_defualt_btn.Location = new System.Drawing.Point(394, 529);
            this.set_defualt_btn.Name = "set_defualt_btn";
            this.set_defualt_btn.Size = new System.Drawing.Size(325, 23);
            this.set_defualt_btn.TabIndex = 7;
            this.set_defualt_btn.Text = "Set Defualt";
            this.set_defualt_btn.UseVisualStyleBackColor = true;
            this.set_defualt_btn.Click += new System.EventHandler(this.set_defualt_btn_Click);
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataMember = "Settings";
            this.settingsBindingSource.DataSource = this.eMUA_dbDataSet;
            // 
            // settingsTableAdapter
            // 
            this.settingsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // reportDataGridViewTextBoxColumn
            // 
            this.reportDataGridViewTextBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewTextBoxColumn.HeaderText = "Report";
            this.reportDataGridViewTextBoxColumn.Name = "reportDataGridViewTextBoxColumn";
            this.reportDataGridViewTextBoxColumn.Width = 600;
            // 
            // report_template_generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 566);
            this.Controls.Add(this.set_defualt_btn);
            this.Controls.Add(this.report_TemplatesDataGridView);
            this.Controls.Add(this.report_TemplatesBindingNavigator);
            this.Controls.Add(this.listbox_templates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.report_text);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "report_template_generator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E.M.U.A. - Report Templates";
            this.Load += new System.EventHandler(this.report_template_generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesBindingNavigator)).EndInit();
            this.report_TemplatesBindingNavigator.ResumeLayout(false);
            this.report_TemplatesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox report_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listbox_templates;
        private EMUA_dbDataSet eMUA_dbDataSet;
        private System.Windows.Forms.BindingSource report_TemplatesBindingSource;
        private EMUA_dbDataSetTableAdapters.Report_TemplatesTableAdapter report_TemplatesTableAdapter;
        private EMUA_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator report_TemplatesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton report_TemplatesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView report_TemplatesDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn defualtDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button set_defualt_btn;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private EMUA_dbDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDataGridViewTextBoxColumn;
    }
}