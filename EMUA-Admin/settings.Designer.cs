namespace EMUA_Admin
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            System.Windows.Forms.Label ownerLabel;
            System.Windows.Forms.Label db_nameLabel;
            System.Windows.Forms.Label admin_passwordLabel;
            this.eMUA_dbDataSet = new EMUA_Admin.EMUA_dbDataSet();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.settingsTableAdapter = new EMUA_Admin.EMUA_dbDataSetTableAdapters.SettingsTableAdapter();
            this.tableAdapterManager = new EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager();
            this.settingsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.settingsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ownerTextBox = new System.Windows.Forms.TextBox();
            this.db_nameTextBox = new System.Windows.Forms.TextBox();
            this.admin_passwordTextBox = new System.Windows.Forms.TextBox();
            ownerLabel = new System.Windows.Forms.Label();
            db_nameLabel = new System.Windows.Forms.Label();
            admin_passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingNavigator)).BeginInit();
            this.settingsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // eMUA_dbDataSet
            // 
            this.eMUA_dbDataSet.DataSetName = "EMUA_dbDataSet";
            this.eMUA_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DaysTableAdapter = null;
            this.tableAdapterManager.EmploysTableAdapter = null;
            this.tableAdapterManager.Report_TemplatesTableAdapter = null;
            this.tableAdapterManager.SettingsTableAdapter = this.settingsTableAdapter;
            this.tableAdapterManager.UpdateOrder = EMUA_Admin.EMUA_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // settingsBindingNavigator
            // 
            this.settingsBindingNavigator.AddNewItem = null;
            this.settingsBindingNavigator.BindingSource = this.settingsBindingSource;
            this.settingsBindingNavigator.CountItem = null;
            this.settingsBindingNavigator.DeleteItem = null;
            this.settingsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsBindingNavigatorSaveItem});
            this.settingsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.settingsBindingNavigator.MoveFirstItem = null;
            this.settingsBindingNavigator.MoveLastItem = null;
            this.settingsBindingNavigator.MoveNextItem = null;
            this.settingsBindingNavigator.MovePreviousItem = null;
            this.settingsBindingNavigator.Name = "settingsBindingNavigator";
            this.settingsBindingNavigator.PositionItem = null;
            this.settingsBindingNavigator.Size = new System.Drawing.Size(262, 25);
            this.settingsBindingNavigator.TabIndex = 0;
            this.settingsBindingNavigator.Text = "bindingNavigator1";
            // 
            // settingsBindingNavigatorSaveItem
            // 
            this.settingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsBindingNavigatorSaveItem.Image")));
            this.settingsBindingNavigatorSaveItem.Name = "settingsBindingNavigatorSaveItem";
            this.settingsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.settingsBindingNavigatorSaveItem.Text = "Save Data";
            this.settingsBindingNavigatorSaveItem.Click += new System.EventHandler(this.settingsBindingNavigatorSaveItem_Click);
            // 
            // ownerLabel
            // 
            ownerLabel.AutoSize = true;
            ownerLabel.Location = new System.Drawing.Point(44, 31);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new System.Drawing.Size(41, 13);
            ownerLabel.TabIndex = 1;
            ownerLabel.Text = "Owner:";
            // 
            // ownerTextBox
            // 
            this.ownerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Owner", true));
            this.ownerTextBox.Location = new System.Drawing.Point(136, 28);
            this.ownerTextBox.Name = "ownerTextBox";
            this.ownerTextBox.Size = new System.Drawing.Size(100, 20);
            this.ownerTextBox.TabIndex = 2;
            // 
            // db_nameLabel
            // 
            db_nameLabel.AutoSize = true;
            db_nameLabel.Location = new System.Drawing.Point(44, 57);
            db_nameLabel.Name = "db_nameLabel";
            db_nameLabel.Size = new System.Drawing.Size(51, 13);
            db_nameLabel.TabIndex = 3;
            db_nameLabel.Text = "db name:";
            // 
            // db_nameTextBox
            // 
            this.db_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "db_name", true));
            this.db_nameTextBox.Location = new System.Drawing.Point(136, 54);
            this.db_nameTextBox.Name = "db_nameTextBox";
            this.db_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.db_nameTextBox.TabIndex = 4;
            // 
            // admin_passwordLabel
            // 
            admin_passwordLabel.AutoSize = true;
            admin_passwordLabel.Location = new System.Drawing.Point(44, 83);
            admin_passwordLabel.Name = "admin_passwordLabel";
            admin_passwordLabel.Size = new System.Drawing.Size(86, 13);
            admin_passwordLabel.TabIndex = 5;
            admin_passwordLabel.Text = "admin password:";
            // 
            // admin_passwordTextBox
            // 
            this.admin_passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "admin_password", true));
            this.admin_passwordTextBox.Location = new System.Drawing.Point(136, 80);
            this.admin_passwordTextBox.Name = "admin_passwordTextBox";
            this.admin_passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.admin_passwordTextBox.TabIndex = 6;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 115);
            this.Controls.Add(ownerLabel);
            this.Controls.Add(this.ownerTextBox);
            this.Controls.Add(db_nameLabel);
            this.Controls.Add(this.db_nameTextBox);
            this.Controls.Add(admin_passwordLabel);
            this.Controls.Add(this.admin_passwordTextBox);
            this.Controls.Add(this.settingsBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "E.M.U.A - Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eMUA_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingNavigator)).EndInit();
            this.settingsBindingNavigator.ResumeLayout(false);
            this.settingsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EMUA_dbDataSet eMUA_dbDataSet;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private EMUA_dbDataSetTableAdapters.SettingsTableAdapter settingsTableAdapter;
        private EMUA_dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator settingsBindingNavigator;
        private System.Windows.Forms.ToolStripButton settingsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ownerTextBox;
        private System.Windows.Forms.TextBox db_nameTextBox;
        private System.Windows.Forms.TextBox admin_passwordTextBox;
    }
}