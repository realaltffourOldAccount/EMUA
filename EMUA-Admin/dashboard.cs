using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMUA_Admin
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void employsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMUA_dbDataSet);

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Employs' table. You can move, or remove it, as needed.
            this.employsTableAdapter.Fill(this.eMUA_dbDataSet.Employs);
            combobox_Search.SelectedIndex = 0;
            //combobox_Search.Select(0, 1);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            employsBindingSource.Filter = "[" + combobox_Search.SelectedItem + "] LIKE '%" + toolStripTextBox1.Text + "%'";
        }

        private void settingsbtn_Click(object sender, EventArgs e)
        {
            using (settings set = new settings())
            {
                set.ShowDialog(this);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (generate_reports reps = new generate_reports())
            {
                reps.ShowDialog(this);
            }
        }

        private void timesheet_btn_Click(object sender, EventArgs e)
        {
            using (timesheet sheet = new timesheet())
            {
                sheet.ShowDialog(this);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (report_template_generator report_temp = new report_template_generator())
            {
                report_temp.ShowDialog(this);
            }
        }
    }
}
