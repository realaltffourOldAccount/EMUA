namespace EMUA_Admin
{
    partial class generate_reports
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
            this.report_data_rich_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.generate_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search_box = new System.Windows.Forms.TextBox();
            this.type_combo = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.employ_view = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingDateEnabledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.endingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlySalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workingHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overTimeMultiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMUA_dbDataSet = new EMUA_Admin.EMUA_dbDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.daily_sal_prev = new System.Windows.Forms.TextBox();
            this.hourly_sal_prev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.total_down_time_prev = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.avg_down_time_prev = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.down_deduction_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.side_deductionbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.overt_m_prev = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.prev_btn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.notes_box = new System.Windows.Forms.RichTextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.total_down_count_prev = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.total_working_time = new System.Windows.Forms.TextBox();
            this.avg_daily_extra_time = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.total_sal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.total_extra_count_prev = new System.Windows.Forms.TextBox();
            this.total_extra_time_prev = new System.Windows.Forms.TextBox();
            this.daysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employsTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.EmploysTableAdapter();
            this.daysTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.DaysTableAdapter();
            this.tableAdapterManager = new EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingsTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.SettingsTableAdapter();
            this.report_TemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_TemplatesTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.Report_TemplatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employ_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // report_data_rich_text
            // 
            this.report_data_rich_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.report_data_rich_text.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_data_rich_text.Location = new System.Drawing.Point(553, 21);
            this.report_data_rich_text.Name = "report_data_rich_text";
            this.report_data_rich_text.Size = new System.Drawing.Size(402, 407);
            this.report_data_rich_text.TabIndex = 1;
            this.report_data_rich_text.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Employs:";
            // 
            // generate_btn
            // 
            this.generate_btn.Location = new System.Drawing.Point(765, 445);
            this.generate_btn.Name = "generate_btn";
            this.generate_btn.Size = new System.Drawing.Size(109, 23);
            this.generate_btn.TabIndex = 4;
            this.generate_btn.Text = "Generate";
            this.generate_btn.UseVisualStyleBackColor = true;
            this.generate_btn.Click += new System.EventHandler(this.generate_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(765, 474);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(109, 23);
            this.print_btn.TabIndex = 5;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // search_box
            // 
            this.search_box.Location = new System.Drawing.Point(553, 447);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(106, 20);
            this.search_box.TabIndex = 7;
            // 
            // type_combo
            // 
            this.type_combo.FormattingEnabled = true;
            this.type_combo.Items.AddRange(new object[] {
            "First Name",
            "Middle Name",
            "Third Name",
            "Mobile",
            "Address",
            "Description"});
            this.type_combo.Location = new System.Drawing.Point(665, 447);
            this.type_combo.Name = "type_combo";
            this.type_combo.Size = new System.Drawing.Size(94, 21);
            this.type_combo.TabIndex = 8;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(556, 474);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(206, 23);
            this.search_btn.TabIndex = 9;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // employ_view
            // 
            this.employ_view.AutoGenerateColumns = false;
            this.employ_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employ_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.firstNameDataGridViewTextBoxColumn1,
            this.middleNameDataGridViewTextBoxColumn1,
            this.thirdNameDataGridViewTextBoxColumn1,
            this.mobileDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.startingDateDataGridViewTextBoxColumn,
            this.endingDateEnabledDataGridViewCheckBoxColumn,
            this.endingDateDataGridViewTextBoxColumn,
            this.monthlySalaryDataGridViewTextBoxColumn,
            this.workingHoursDataGridViewTextBoxColumn,
            this.overTimeMultiplierDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.employ_view.DataSource = this.employsBindingSource;
            this.employ_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.employ_view.EnableHeadersVisualStyles = false;
            this.employ_view.Location = new System.Drawing.Point(12, 25);
            this.employ_view.Name = "employ_view";
            this.employ_view.ReadOnly = true;
            this.employ_view.Size = new System.Drawing.Size(535, 472);
            this.employ_view.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn1
            // 
            this.firstNameDataGridViewTextBoxColumn1.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn1.Name = "firstNameDataGridViewTextBoxColumn1";
            this.firstNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn1
            // 
            this.middleNameDataGridViewTextBoxColumn1.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn1.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn1.Name = "middleNameDataGridViewTextBoxColumn1";
            this.middleNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // thirdNameDataGridViewTextBoxColumn1
            // 
            this.thirdNameDataGridViewTextBoxColumn1.DataPropertyName = "Third Name";
            this.thirdNameDataGridViewTextBoxColumn1.HeaderText = "Third Name";
            this.thirdNameDataGridViewTextBoxColumn1.Name = "thirdNameDataGridViewTextBoxColumn1";
            this.thirdNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startingDateDataGridViewTextBoxColumn
            // 
            this.startingDateDataGridViewTextBoxColumn.DataPropertyName = "Starting Date";
            this.startingDateDataGridViewTextBoxColumn.HeaderText = "Starting Date";
            this.startingDateDataGridViewTextBoxColumn.Name = "startingDateDataGridViewTextBoxColumn";
            this.startingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endingDateEnabledDataGridViewCheckBoxColumn
            // 
            this.endingDateEnabledDataGridViewCheckBoxColumn.DataPropertyName = "Ending Date Enabled";
            this.endingDateEnabledDataGridViewCheckBoxColumn.HeaderText = "Ending Date Enabled";
            this.endingDateEnabledDataGridViewCheckBoxColumn.Name = "endingDateEnabledDataGridViewCheckBoxColumn";
            this.endingDateEnabledDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // endingDateDataGridViewTextBoxColumn
            // 
            this.endingDateDataGridViewTextBoxColumn.DataPropertyName = "Ending Date";
            this.endingDateDataGridViewTextBoxColumn.HeaderText = "Ending Date";
            this.endingDateDataGridViewTextBoxColumn.Name = "endingDateDataGridViewTextBoxColumn";
            this.endingDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monthlySalaryDataGridViewTextBoxColumn
            // 
            this.monthlySalaryDataGridViewTextBoxColumn.DataPropertyName = "Monthly Salary";
            this.monthlySalaryDataGridViewTextBoxColumn.HeaderText = "Monthly Salary";
            this.monthlySalaryDataGridViewTextBoxColumn.Name = "monthlySalaryDataGridViewTextBoxColumn";
            this.monthlySalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workingHoursDataGridViewTextBoxColumn
            // 
            this.workingHoursDataGridViewTextBoxColumn.DataPropertyName = "Working Hours";
            this.workingHoursDataGridViewTextBoxColumn.HeaderText = "Working Hours";
            this.workingHoursDataGridViewTextBoxColumn.Name = "workingHoursDataGridViewTextBoxColumn";
            this.workingHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // overTimeMultiplierDataGridViewTextBoxColumn
            // 
            this.overTimeMultiplierDataGridViewTextBoxColumn.DataPropertyName = "OverTime Multiplier";
            this.overTimeMultiplierDataGridViewTextBoxColumn.HeaderText = "OverTime Multiplier";
            this.overTimeMultiplierDataGridViewTextBoxColumn.Name = "overTimeMultiplierDataGridViewTextBoxColumn";
            this.overTimeMultiplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employsBindingSource
            // 
            this.employsBindingSource.DataMember = "Employs";
            this.employsBindingSource.DataSource = this.eMUA_dbDataSet;
            // 
            // eMUA_dbDataSet
            // 
            this.eMUA_dbDataSet.DataSetName = "EMUA_dbDataSet";
            this.eMUA_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(550, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Report:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1134, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(961, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Detailed View:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1012, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Daily Salary:";
            // 
            // daily_sal_prev
            // 
            this.daily_sal_prev.Location = new System.Drawing.Point(1101, 38);
            this.daily_sal_prev.Name = "daily_sal_prev";
            this.daily_sal_prev.ReadOnly = true;
            this.daily_sal_prev.Size = new System.Drawing.Size(133, 20);
            this.daily_sal_prev.TabIndex = 15;
            // 
            // hourly_sal_prev
            // 
            this.hourly_sal_prev.Location = new System.Drawing.Point(1101, 64);
            this.hourly_sal_prev.Name = "hourly_sal_prev";
            this.hourly_sal_prev.ReadOnly = true;
            this.hourly_sal_prev.Size = new System.Drawing.Size(133, 20);
            this.hourly_sal_prev.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1009, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hourly Salary:";
            // 
            // total_down_time_prev
            // 
            this.total_down_time_prev.Location = new System.Drawing.Point(1101, 90);
            this.total_down_time_prev.Name = "total_down_time_prev";
            this.total_down_time_prev.ReadOnly = true;
            this.total_down_time_prev.Size = new System.Drawing.Size(71, 20);
            this.total_down_time_prev.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(997, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Down Time:";
            // 
            // avg_down_time_prev
            // 
            this.avg_down_time_prev.Location = new System.Drawing.Point(1101, 186);
            this.avg_down_time_prev.Name = "avg_down_time_prev";
            this.avg_down_time_prev.ReadOnly = true;
            this.avg_down_time_prev.Size = new System.Drawing.Size(133, 20);
            this.avg_down_time_prev.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(961, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Avg. Daily Down Time:";
            // 
            // down_deduction_box
            // 
            this.down_deduction_box.Location = new System.Drawing.Point(1101, 264);
            this.down_deduction_box.Name = "down_deduction_box";
            this.down_deduction_box.ReadOnly = true;
            this.down_deduction_box.Size = new System.Drawing.Size(133, 20);
            this.down_deduction_box.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(997, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Down Deduction:";
            // 
            // side_deductionbox
            // 
            this.side_deductionbox.Enabled = false;
            this.side_deductionbox.Location = new System.Drawing.Point(1101, 290);
            this.side_deductionbox.Name = "side_deductionbox";
            this.side_deductionbox.Size = new System.Drawing.Size(133, 20);
            this.side_deductionbox.TabIndex = 25;
            this.side_deductionbox.Text = "0.0";
            this.side_deductionbox.TextChanged += new System.EventHandler(this.side_deductionbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(997, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Side Deduction:";
            // 
            // overt_m_prev
            // 
            this.overt_m_prev.Location = new System.Drawing.Point(1101, 238);
            this.overt_m_prev.Name = "overt_m_prev";
            this.overt_m_prev.ReadOnly = true;
            this.overt_m_prev.Size = new System.Drawing.Size(133, 20);
            this.overt_m_prev.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(997, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "OverTime Mult.:";
            // 
            // prev_btn
            // 
            this.prev_btn.Location = new System.Drawing.Point(880, 445);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(75, 52);
            this.prev_btn.TabIndex = 28;
            this.prev_btn.Text = "Preview";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(971, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Notes:";
            // 
            // notes_box
            // 
            this.notes_box.Location = new System.Drawing.Point(974, 385);
            this.notes_box.Name = "notes_box";
            this.notes_box.Size = new System.Drawing.Size(260, 79);
            this.notes_box.TabIndex = 30;
            this.notes_box.Text = "";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // thirdNameDataGridViewTextBoxColumn
            // 
            this.thirdNameDataGridViewTextBoxColumn.DataPropertyName = "Third Name";
            this.thirdNameDataGridViewTextBoxColumn.HeaderText = "Third Name";
            this.thirdNameDataGridViewTextBoxColumn.Name = "thirdNameDataGridViewTextBoxColumn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(991, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Total Extra Time:";
            // 
            // total_down_count_prev
            // 
            this.total_down_count_prev.Location = new System.Drawing.Point(1178, 90);
            this.total_down_count_prev.Name = "total_down_count_prev";
            this.total_down_count_prev.ReadOnly = true;
            this.total_down_count_prev.Size = new System.Drawing.Size(56, 20);
            this.total_down_count_prev.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(979, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Total Working Time:";
            // 
            // total_working_time
            // 
            this.total_working_time.Location = new System.Drawing.Point(1101, 145);
            this.total_working_time.Name = "total_working_time";
            this.total_working_time.ReadOnly = true;
            this.total_working_time.Size = new System.Drawing.Size(133, 20);
            this.total_working_time.TabIndex = 36;
            // 
            // avg_daily_extra_time
            // 
            this.avg_daily_extra_time.Location = new System.Drawing.Point(1101, 212);
            this.avg_daily_extra_time.Name = "avg_daily_extra_time";
            this.avg_daily_extra_time.ReadOnly = true;
            this.avg_daily_extra_time.Size = new System.Drawing.Size(133, 20);
            this.avg_daily_extra_time.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(955, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(139, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Avg. Daily Extra Time:";
            // 
            // total_sal
            // 
            this.total_sal.Location = new System.Drawing.Point(1101, 344);
            this.total_sal.Name = "total_sal";
            this.total_sal.ReadOnly = true;
            this.total_sal.Size = new System.Drawing.Size(133, 20);
            this.total_sal.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1009, 347);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Total Salary:";
            // 
            // total_extra_count_prev
            // 
            this.total_extra_count_prev.Location = new System.Drawing.Point(1178, 116);
            this.total_extra_count_prev.Name = "total_extra_count_prev";
            this.total_extra_count_prev.ReadOnly = true;
            this.total_extra_count_prev.Size = new System.Drawing.Size(56, 20);
            this.total_extra_count_prev.TabIndex = 41;
            // 
            // total_extra_time_prev
            // 
            this.total_extra_time_prev.Location = new System.Drawing.Point(1101, 116);
            this.total_extra_time_prev.Name = "total_extra_time_prev";
            this.total_extra_time_prev.ReadOnly = true;
            this.total_extra_time_prev.Size = new System.Drawing.Size(71, 20);
            this.total_extra_time_prev.TabIndex = 42;
            // 
            // daysBindingSource
            // 
            this.daysBindingSource.DataMember = "Employs_Days";
            this.daysBindingSource.DataSource = this.employsBindingSource;
            // 
            // employsTableAdapter
            // 
            this.employsTableAdapter.ClearBeforeFill = true;
            // 
            // daysTableAdapter
            // 
            this.daysTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DaysTableAdapter = this.daysTableAdapter;
            this.tableAdapterManager.EmploysTableAdapter = this.employsTableAdapter;
            this.tableAdapterManager.Report_TemplatesTableAdapter = null;
            this.tableAdapterManager.SettingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // report_TemplatesBindingSource
            // 
            this.report_TemplatesBindingSource.DataMember = "Report_Templates";
            this.report_TemplatesBindingSource.DataSource = this.eMUA_dbDataSet;
            // 
            // report_TemplatesTableAdapter
            // 
            this.report_TemplatesTableAdapter.ClearBeforeFill = true;
            // 
            // generate_reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 521);
            this.Controls.Add(this.total_extra_time_prev);
            this.Controls.Add(this.total_extra_count_prev);
            this.Controls.Add(this.total_sal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.avg_daily_extra_time);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.total_working_time);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.total_down_count_prev);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.notes_box);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.overt_m_prev);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.side_deductionbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.down_deduction_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.avg_down_time_prev);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total_down_time_prev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hourly_sal_prev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.daily_sal_prev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.employ_view);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.type_combo);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.generate_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.report_data_rich_text);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "generate_reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E.M.U.A - Generate Reports";
            this.Load += new System.EventHandler(this.generate_reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employ_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_TemplatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EMUA_dbDataSet eMUA_dbDataSet;
        private System.Windows.Forms.RichTextBox report_data_rich_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button generate_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.ComboBox type_combo;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DataGridView employ_view;
        private System.Windows.Forms.Label label3;
        private EMUA_dbDataSetTableAdapters.EmploysTableAdapter employsTableAdapter;
        private System.Windows.Forms.BindingSource employsBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox daily_sal_prev;
        private System.Windows.Forms.TextBox hourly_sal_prev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox total_down_time_prev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox avg_down_time_prev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox down_deduction_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox side_deductionbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox overt_m_prev;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox notes_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn endingDateEnabledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthlySalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workingHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn overTimeMultiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox total_down_count_prev;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox total_working_time;
        private System.Windows.Forms.TextBox avg_daily_extra_time;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox total_sal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox total_extra_count_prev;
        private System.Windows.Forms.TextBox total_extra_time_prev;
        private System.Windows.Forms.BindingSource daysBindingSource;
        private EMUA_dbDataSetTableAdapters.DaysTableAdapter daysTableAdapter;
        private EMUA_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private EMUA_dbDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter;
        private System.Windows.Forms.BindingSource report_TemplatesBindingSource;
        private EMUA_dbDataSetTableAdapters.Report_TemplatesTableAdapter report_TemplatesTableAdapter;
    }
}