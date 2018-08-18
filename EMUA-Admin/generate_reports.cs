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
    public partial class generate_reports : Form
    {
        public generate_reports()
        {
            InitializeComponent();
        }

        DataTable days_data = new DataTable();
        DataTable employ_data = new DataTable();

        int employ_view_index;
        
        // vars
        int monthly_sal;
        int daily_sal;
        int hourly_sal;
        float ovrt_mult;
        float side_deduction;
        float norm_working_hours;
        String notes;

        float total_down_time = 0;
        int total_down_count = 0;
        float total_extra_time = 0;
        int total_extra_count = 0;
        float avg_down_time = 0;
        float avg_extra_time = 0;
        float down_deduction = 0;
        float extra_sal = 0;
        float total_work_time = 0;

        float salary = 0;

        int employ_index;

        private String generateReport()
        {
            String result = "";
            var row = this.employ_view.SelectedRows;

            

            return result;
        }

        private void daysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.daysBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMUA_dbDataSet);

        }

        private void generate_reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Report_Templates' table. You can move, or remove it, as needed.
            this.report_TemplatesTableAdapter.Fill(this.eMUA_dbDataSet.Report_Templates);
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Settings' table. You can move, or remove it, as needed.
            this.settingsTableAdapter.Fill(this.eMUA_dbDataSet.Settings);
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Days' table. You can move, or remove it, as needed.
            this.daysTableAdapter.Fill(this.eMUA_dbDataSet.Days);
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Employs' table. You can move, or remove it, as needed.
            this.employsTableAdapter.Fill(this.eMUA_dbDataSet.Employs);


            days_data = this.daysTableAdapter.GetData();
            employ_data = this.employsTableAdapter.GetData();

            type_combo.SelectedIndex = 0;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            employsBindingSource.Filter = "[" + type_combo.SelectedItem + "] LIKE '%" + search_box.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            var employ = employ_view.CurrentRow;   // employ data
            String report = report_TemplatesTableAdapter.GetReportById(settingsTableAdapter.GetDefualtReport().Value);

            report = report_template.createReport(report,
                Convert.ToString(employ.Cells[1].Value), Convert.ToString(employ.Cells[2].Value), Convert.ToString(employ.Cells[3].Value),
                notes_box.Text,
                total_down_time, total_extra_time,
                total_down_count, total_extra_count,
                salary);

            report_data_rich_text.Text = report;
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            if (employ_view.SelectedRows != null)
            {
                // TODO: STUFF
                if (employ_view.SelectedRows.Count > 1)
                {
                    MessageBox.Show(this, "Select One Row!", "Warning", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    var a = employ_view.SelectedRows[0].Cells[5].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Select One Whole Row!", "Error");

                    //throw ;
                    return;
                }

                //MessageBox.Show("clicked EMP id:" + employ_view.SelectedRows[0].Cells[0].Value); // debug

                // Get Data
                days_data = this.eMUA_dbDataSet.Days;
                employ_data = employsTableAdapter.GetData();

                //MessageBox.Show(this, "Clicked EMP :" + this.eMUA_dbDataSet.Days.Rows[0][3]);


                employ_index = employ_view.SelectedRows[0].Index; // employ view
                var employ = employ_data.Rows[employ_index];   // employ data

                // vars
                monthly_sal = Convert.ToInt32(employ.ItemArray[9]);
                daily_sal = Convert.ToInt32(employ.ItemArray[9]) / 30;
                hourly_sal = daily_sal / Convert.ToInt32(employ.ItemArray[12]);
                ovrt_mult = float.Parse(Convert.ToString(employ.ItemArray[11]));
                side_deduction = float.Parse(side_deductionbox.Text);
                norm_working_hours = float.Parse(Convert.ToString(employ.ItemArray[12]));
                notes = notes_box.Text;

                total_down_time = 0;
                total_down_count = 0;
                total_extra_time = 0;
                total_extra_count = 0;
                avg_down_time = 0;
                avg_extra_time = 0;
                down_deduction = 0;
                extra_sal = 0;
                total_work_time = 0;

                salary = 0;

                // retrieve

                for (int i = 0; i < days_data.Rows.Count; i++)
                {
                    if (Convert.ToInt32(days_data.Rows[i].ItemArray[1]) == Convert.ToInt32(employ.ItemArray[0]))
                    {
                        TimeSpan enter_time = TimeSpan.Parse(Convert.ToString(days_data.Rows[i].ItemArray[3]));
                        TimeSpan exit_time = TimeSpan.Parse(Convert.ToString(days_data.Rows[i].ItemArray[4]));
                        int hours = (exit_time - enter_time).Hours;
                        int mins = (exit_time - enter_time).Minutes;
                        float day_worked_hours = float.Parse(Convert.ToString(hours) + "." + Convert.ToString(mins));
                        
                        if (day_worked_hours > norm_working_hours) // extra time
                        {
                            float extra_time = day_worked_hours - norm_working_hours;

                            // add extra time to extra time counter
                            total_extra_time += extra_time;
                            total_extra_count++;

                            // add time to time counter
                            total_work_time += day_worked_hours;
                        }
                        else if (day_worked_hours == norm_working_hours) // exact time
                        {
                            // add time to time counter
                            total_work_time += day_worked_hours;
                        }
                        else if (day_worked_hours < norm_working_hours) // didnt do exact time
                        {
                            float down_time = norm_working_hours - day_worked_hours;

                            // add down time to down time counter
                            total_down_time += down_time;
                            total_down_count++;

                            // sub time to time counter
                            total_work_time -= down_time;
                        }
                    }
                    
                }

                avg_down_time = total_down_time / total_down_count;
                avg_extra_time = total_extra_time / total_extra_time;

                down_deduction = total_down_time * (hourly_sal/60);
                extra_sal = total_extra_time * (hourly_sal/60);

                daily_sal_prev.Text = Convert.ToString(daily_sal);
                hourly_sal_prev.Text = Convert.ToString(hourly_sal);
                total_down_time_prev.Text = Convert.ToString(total_down_time) + " hrs";
                total_down_count_prev.Text = Convert.ToString(total_down_count);
                
                total_extra_time_prev.Text = Convert.ToString(total_extra_time) + " hrs";
                total_extra_count_prev.Text = Convert.ToString(total_extra_count);

                total_working_time.Text = Convert.ToString(total_work_time) + " hrs";

                avg_daily_extra_time.Text = Convert.ToString(avg_extra_time);
                avg_down_time_prev.Text = Convert.ToString(avg_down_time);

                overt_m_prev.Text = Convert.ToString(ovrt_mult);
                down_deduction_box.Text = Convert.ToString(down_deduction);

                salary = ((norm_working_hours * (hourly_sal)) + (total_extra_time* (hourly_sal * ovrt_mult)) - (down_deduction + side_deduction));

                total_sal.Text = Convert.ToString(salary);

                side_deductionbox.Enabled = true;
            }
        }

        private void print_btn_Click(object sender, EventArgs e)
        {

        }

        private void side_deductionbox_TextChanged(object sender, EventArgs e)
        {
            float deduction_box_val = 0;
            if (!float.TryParse(side_deductionbox.Text, out deduction_box_val))
            {
                side_deductionbox.Text += ".0";
            }

            deduction_box_val = float.Parse(side_deductionbox.Text);

            side_deduction = deduction_box_val;

            salary = ((norm_working_hours * (hourly_sal)) + (total_extra_time * (hourly_sal * ovrt_mult)) - (down_deduction + side_deduction));
            total_sal.Text = Convert.ToString(salary);
        }
    }
}
