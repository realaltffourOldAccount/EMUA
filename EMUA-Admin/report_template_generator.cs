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
    public partial class report_template_generator : Form
    {
        public report_template_generator()
        {
            InitializeComponent();
        }

        private void report_TemplatesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.report_TemplatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMUA_dbDataSet);

        }

        private void report_template_generator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Settings' table. You can move, or remove it, as needed.
            this.settingsTableAdapter.Fill(this.eMUA_dbDataSet.Settings);
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Report_Templates' table. You can move, or remove it, as needed.
            this.report_TemplatesTableAdapter.Fill(this.eMUA_dbDataSet.Report_Templates);
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Report_Templates' table. You can move, or remove it, as needed.
            this.report_TemplatesTableAdapter.Fill(this.eMUA_dbDataSet.Report_Templates);

        }

        private void listbox_templates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listbox_templates_SelectedValueChanged(object sender, EventArgs e)
        {
            int selected_index = listbox_templates.SelectedIndex;

            switch (selected_index)
            {
                case 0:
                    report_text.Text += report_template.ID_APP_NAME;
                    break;
                case 1:
                    report_text.Text += report_template.ID_EMPLOY_FULL_NAME;
                    break;
                case 2:
                    report_text.Text += report_template.ID_EMPLOY_FRIST_NAME;
                    break;
                case 3:
                    report_text.Text += report_template.ID_EMPLOY_SECOND_NAME;
                    break;
                case 4:
                    report_text.Text += report_template.ID_EMPLOY_THIRD_NAME;
                    break;
                case 5:
                    report_text.Text += report_template.ID_EMPLOY_TIME_DOWN;
                    break;
                case 6:
                    report_text.Text += report_template.ID_EMPLOY_TIME_EXTRA;
                    break;
                case 7:
                    report_text.Text += report_template.ID_EMPLOY_TIME_DOWN_COUNT;
                    break;
                case 8:
                    report_text.Text += report_template.ID_EMPLOY_TIME_EXTRA_COUNT;
                    break;
                case 9:
                        report_text.Text += report_template.ID_EMPLOY_NOTES;
                    break;
                case 10:
                    report_text.Text += report_template.ID_EMPLOY_TOTAL_SAL;
                    break;
                default:
                    break;
            }

        }

        private void report_TemplatesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_text_TextChanged(object sender, EventArgs e)
        {
            var selected_rows = report_TemplatesDataGridView.CurrentRow;

            if (selected_rows != null)
            {
                // TODO: STUFF
                selected_rows.Cells[1].Value = report_text.Text;
            }
        }

        private void report_TemplatesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

            this.Validate();
            this.report_TemplatesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMUA_dbDataSet);
        }

        private void report_TemplatesDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //int rowindex = report_TemplatesDataGridView.CurrentCell.RowIndex;
            //int columnindex = report_TemplatesDataGridView.CurrentCell.ColumnIndex;

            //dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
            //report_text.Text = Convert.ToString(report_TemplatesDataGridView.SelectedRows[0].Cells["Report"]);

        }

        private void report_TemplatesDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void report_TemplatesDataGridView_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            var current_row = report_TemplatesDataGridView.CurrentRow;

            if (current_row != null)
            {
                report_text.Text = Convert.ToString(current_row.Cells[1].Value);
                report_text.Enabled = true;
                listbox_templates.Enabled = true;
                set_defualt_btn.Enabled = true;
            }

        }

        private void report_TemplatesDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            var current_row = report_TemplatesDataGridView.CurrentRow;

            if (current_row != null)
            {
                report_text.Text = Convert.ToString(current_row.Cells[1].Value);
                report_text.Enabled = true;
                listbox_templates.Enabled = true;
                set_defualt_btn.Enabled = true;
            }

        }

        private void set_defualt_btn_Click(object sender, EventArgs e)
        {
            var current_row = report_TemplatesDataGridView.CurrentRow;
            
            if (current_row != null)
                settingsTableAdapter.SetDefualtReport(Convert.ToInt32(current_row.Cells[0].Value), 1);



        }
    }
}