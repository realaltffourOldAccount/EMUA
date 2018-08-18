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
    public partial class timesheet : Form
    {
        public timesheet()
        {
            InitializeComponent();
        }

        private void timesheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Employs' table. You can move, or remove it, as needed.
            this.employsTableAdapter.Fill(this.eMUA_dbDataSet.Employs);
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Days' table. You can move, or remove it, as needed.
            this.daysTableAdapter.Fill(this.eMUA_dbDataSet.Days);

            

        }

        private void daysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.daysBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMUA_dbDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (employsDataGridView.SelectedRows != null)
            {
                // TODO: STUFF
                if (employsDataGridView.SelectedRows.Count > 1)
                {
                    MessageBox.Show(this, "Select One Row!", "Warning", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    var a = employsDataGridView.SelectedRows[0].Cells[5].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Select One Whole Row!", "Error");

                    //throw ;
                    return;
                }

               // MessageBox.Show("clicked EMP id:"+employsDataGridView.SelectedRows[0].Cells[1].Value);


                DateTime today = DateTime.Now;

                daysTableAdapter.Insert(Convert.ToInt32(employsDataGridView.SelectedRows[0].Cells[0].Value)
                                        , today, enter_time.Value.TimeOfDay, exit_time.Value.TimeOfDay);

                this.daysTableAdapter.Fill(this.eMUA_dbDataSet.Days);
            }
        }

        private void employsDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //daysBindingSource.Filter = "[Id] LIKE " + employsDataGridView[0, e.RowIndex].Value + "";
            //int index = daysBindingSource.Find("Employ Id", employsDataGridView[0, e.RowIndex].Value);
            //daysBindingSource.Position = index;
            if (employsDataGridView[0, e.RowIndex].Value == null)
            {
                MessageBox.Show(this, "Editing Not Allowed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //daysBindingSource.Position = 0;
                daysBindingSource.MoveFirst();
            }
            else
                daysBindingSource.Filter = "CONVERT([Employ Id], 'System.String') LIKE CONVERT(" + employsDataGridView[0, e.RowIndex].Value + ", 'System.String')";

        }

        private void employsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            daysBindingSource.RemoveFilter();
        }

        private void delete_d_btn_Click(object sender, EventArgs e)
        {
            if (daysDataGrid.SelectedRows != null)
            {
                // TODO: STUFF
                if (daysDataGrid.SelectedRows.Count > 1)
                {
                    MessageBox.Show(this, "Select One Row!", "Warning", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    var a = daysDataGrid.SelectedRows[0].Cells[4].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Select One Whole Row!", "Error");

                    //throw ;
                    return;
                }

                MessageBox.Show("clicked EMP id:" + daysDataGrid.SelectedRows[0].Cells[1].Value);


                daysTableAdapter.Delete1(Convert.ToInt32(daysDataGrid.SelectedRows[0].Cells[0].Value));
                this.daysTableAdapter.Fill(this.eMUA_dbDataSet.Days);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
