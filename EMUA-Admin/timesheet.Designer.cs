namespace EMUA_Admin
{
    partial class timesheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timesheet));
            this.daysBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.daysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMUA_dbDataSet = new EMUA_Admin.EMUA_dbDataSet();
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
            this.daysBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.daysDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTodayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enterTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enter_time = new System.Windows.Forms.DateTimePicker();
            this.exit_time = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delete_d_btn = new System.Windows.Forms.Button();
            this.daysTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.DaysTableAdapter();
            this.tableAdapterManager = new EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager();
            this.employsTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.EmploysTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingNavigator)).BeginInit();
            this.daysBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // daysBindingNavigator
            // 
            this.daysBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.daysBindingNavigator.BindingSource = this.daysBindingSource;
            this.daysBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.daysBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.daysBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.daysBindingNavigatorSaveItem});
            this.daysBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.daysBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.daysBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.daysBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.daysBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.daysBindingNavigator.Name = "daysBindingNavigator";
            this.daysBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.daysBindingNavigator.Size = new System.Drawing.Size(777, 25);
            this.daysBindingNavigator.TabIndex = 0;
            this.daysBindingNavigator.Text = "bindingNavigator1";
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
            // daysBindingSource
            // 
            this.daysBindingSource.DataMember = "Days";
            this.daysBindingSource.DataSource = this.eMUA_dbDataSet;
            // 
            // eMUA_dbDataSet
            // 
            this.eMUA_dbDataSet.DataSetName = "EMUA_dbDataSet";
            this.eMUA_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // daysBindingNavigatorSaveItem
            // 
            this.daysBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.daysBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("daysBindingNavigatorSaveItem.Image")));
            this.daysBindingNavigatorSaveItem.Name = "daysBindingNavigatorSaveItem";
            this.daysBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.daysBindingNavigatorSaveItem.Text = "Save Data";
            this.daysBindingNavigatorSaveItem.Click += new System.EventHandler(this.daysBindingNavigatorSaveItem_Click);
            // 
            // daysDataGrid
            // 
            this.daysDataGrid.AutoGenerateColumns = false;
            this.daysDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daysDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.employIDDataGridViewTextBoxColumn,
            this.dayTodayDataGridViewTextBoxColumn,
            this.enterTimeDataGridViewTextBoxColumn,
            this.exitTimeDataGridViewTextBoxColumn});
            this.daysDataGrid.DataSource = this.daysBindingSource;
            this.daysDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.daysDataGrid.Location = new System.Drawing.Point(12, 28);
            this.daysDataGrid.Name = "daysDataGrid";
            this.daysDataGrid.ReadOnly = true;
            this.daysDataGrid.Size = new System.Drawing.Size(753, 328);
            this.daysDataGrid.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employIDDataGridViewTextBoxColumn
            // 
            this.employIDDataGridViewTextBoxColumn.DataPropertyName = "Employ ID";
            this.employIDDataGridViewTextBoxColumn.HeaderText = "Employ ID";
            this.employIDDataGridViewTextBoxColumn.Name = "employIDDataGridViewTextBoxColumn";
            this.employIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayTodayDataGridViewTextBoxColumn
            // 
            this.dayTodayDataGridViewTextBoxColumn.DataPropertyName = "Day Today";
            this.dayTodayDataGridViewTextBoxColumn.HeaderText = "Day Today";
            this.dayTodayDataGridViewTextBoxColumn.Name = "dayTodayDataGridViewTextBoxColumn";
            this.dayTodayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enterTimeDataGridViewTextBoxColumn
            // 
            this.enterTimeDataGridViewTextBoxColumn.DataPropertyName = "Enter Time";
            this.enterTimeDataGridViewTextBoxColumn.HeaderText = "Enter Time";
            this.enterTimeDataGridViewTextBoxColumn.Name = "enterTimeDataGridViewTextBoxColumn";
            this.enterTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exitTimeDataGridViewTextBoxColumn
            // 
            this.exitTimeDataGridViewTextBoxColumn.DataPropertyName = "Exit Time";
            this.exitTimeDataGridViewTextBoxColumn.HeaderText = "Exit Time";
            this.exitTimeDataGridViewTextBoxColumn.Name = "exitTimeDataGridViewTextBoxColumn";
            this.exitTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employsDataGridView
            // 
            this.employsDataGridView.AutoGenerateColumns = false;
            this.employsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10});
            this.employsDataGridView.DataSource = this.employsBindingSource;
            this.employsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employsDataGridView.Location = new System.Drawing.Point(12, 362);
            this.employsDataGridView.Name = "employsDataGridView";
            this.employsDataGridView.ReadOnly = true;
            this.employsDataGridView.Size = new System.Drawing.Size(753, 186);
            this.employsDataGridView.TabIndex = 2;
            this.employsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employsDataGridView_CellClick);
            this.employsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employsDataGridView_CellContentClick);
            this.employsDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.employsDataGridView_RowEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Middle Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Middle Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Third Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Third Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Mobile";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mobile";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn10.HeaderText = "Description";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // employsBindingSource
            // 
            this.employsBindingSource.DataMember = "Employs";
            this.employsBindingSource.DataSource = this.eMUA_dbDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Day:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 601);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Day";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Time:";
            // 
            // enter_time
            // 
            this.enter_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.enter_time.Location = new System.Drawing.Point(91, 576);
            this.enter_time.Name = "enter_time";
            this.enter_time.Size = new System.Drawing.Size(105, 20);
            this.enter_time.TabIndex = 7;
            // 
            // exit_time
            // 
            this.exit_time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.exit_time.Location = new System.Drawing.Point(91, 602);
            this.exit_time.Name = "exit_time";
            this.exit_time.Size = new System.Drawing.Size(105, 20);
            this.exit_time.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Exit Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(343, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "*All Dates will be ignored, Only Time Will Be Considered";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(202, 573);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(88, 23);
            this.clear_btn.TabIndex = 11;
            this.clear_btn.Text = "Clear Filter";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delete_d_btn
            // 
            this.delete_d_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.delete_d_btn.Location = new System.Drawing.Point(296, 601);
            this.delete_d_btn.Name = "delete_d_btn";
            this.delete_d_btn.Size = new System.Drawing.Size(88, 23);
            this.delete_d_btn.TabIndex = 12;
            this.delete_d_btn.Text = "Delete Day";
            this.delete_d_btn.UseVisualStyleBackColor = true;
            this.delete_d_btn.Click += new System.EventHandler(this.delete_d_btn_Click);
            // 
            // daysTableAdapter
            // 
            this.daysTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DaysTableAdapter = this.daysTableAdapter;
            this.tableAdapterManager.EmploysTableAdapter = null;
            this.tableAdapterManager.Report_TemplatesTableAdapter = null;
            this.tableAdapterManager.SettingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employsTableAdapter
            // 
            this.employsTableAdapter.ClearBeforeFill = true;
            // 
            // timesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 631);
            this.Controls.Add(this.delete_d_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enter_time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employsDataGridView);
            this.Controls.Add(this.daysDataGrid);
            this.Controls.Add(this.daysBindingNavigator);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "timesheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E.M.U.A - Time Sheet";
            this.Load += new System.EventHandler(this.timesheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingNavigator)).EndInit();
            this.daysBindingNavigator.ResumeLayout(false);
            this.daysBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EMUA_dbDataSet eMUA_dbDataSet;
        private System.Windows.Forms.BindingSource daysBindingSource;
        private EMUA_dbDataSetTableAdapters.DaysTableAdapter daysTableAdapter;
        private EMUA_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator daysBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton daysBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView daysDataGrid;
        private System.Windows.Forms.BindingSource employsBindingSource;
        private EMUA_dbDataSetTableAdapters.EmploysTableAdapter employsTableAdapter;
        private System.Windows.Forms.DataGridView employsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayTodayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enterTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker enter_time;
        private System.Windows.Forms.DateTimePicker exit_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delete_d_btn;
    }
}