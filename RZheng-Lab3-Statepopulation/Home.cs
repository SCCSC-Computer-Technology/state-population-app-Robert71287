using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RZheng_Lab3_Statepopulation
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void ViewDetailsBtn_Click(object sender, EventArgs e)
        {
            // Use Text so it works whether they selected OR typed
            string selectedState = stateNameComboBox.Text?.Trim();

            if (string.IsNullOrWhiteSpace(selectedState))
            {
                MessageBox.Show("Please type or select a state first.",
                                "No State Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                stateNameComboBox.Focus();
                return;
            }

            DetailForm details = new DetailForm();
            details.StateName = selectedState;   // <-- THIS is the pass-over
            details.ShowDialog();
        }

        private void seeDatabaseBtn_Click(object sender, EventArgs e)
        {
            Database dbForm = new Database();
            dbForm.ShowDialog();
        }

        private void stateNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void stateNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

            stateNameComboBox.DataSource = this.database1DataSet.Table;
            stateNameComboBox.DisplayMember = "StateName";
            stateNameComboBox.ValueMember = "StateId";

            if (stateNameComboBox.Items.Count > 0)
                stateNameComboBox.SelectedIndex = 0;
        }
    }
}
