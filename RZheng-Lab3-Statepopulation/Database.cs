using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RZheng_Lab3_Statepopulation
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Database_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }

     

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchTxtBox.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                tableBindingSource.RemoveFilter();
                return;
            }

            // Build filter across ALL columns in the typed DataTable
            DataTable dt = database1DataSet.Table;

            List<string> filters = new List<string>();

            foreach (DataColumn col in dt.Columns)
            {
                filters.Add($"CONVERT([{col.ColumnName}], 'System.String') LIKE '%{searchValue}%'");
            }

            tableBindingSource.Filter = string.Join(" OR ", filters);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchTxtBox.Clear();            
            tableBindingSource.RemoveFilter();
        }
    }
}
