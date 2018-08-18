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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.settingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMUA_dbDataSet);

        }

        private void settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMUA_dbDataSet.Settings' table. You can move, or remove it, as needed.
            this.settingsTableAdapter.Fill(this.eMUA_dbDataSet.Settings);

        }
    }
}
