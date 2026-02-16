using System;
using System.Data;
using System.Windows.Forms;

namespace RZheng_Lab3_Statepopulation
{
    public partial class DetailForm : Form
    {
        public string StateName { get; set; }

        public DetailForm()
        {
            InitializeComponent();
            this.Load += DetailForm_Load;
        }

        private void DetailForm_Load(object sender, EventArgs e)
        {
            // Validate the incoming value
            StateName = (StateName ?? "").Trim();

            selectedStateLabel.Text = "Your Selected State: " + StateName;

            if (string.IsNullOrWhiteSpace(StateName))
            {
                MessageBox.Show("No state was selected.");
                Close();
                return;
            }

            // Get state record
            var adapter = new Database1DataSetTableAdapters.TableTableAdapter();

            var table = new Database1DataSet.TableDataTable();
            adapter.GetSelectedStateByName(table, StateName);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("State not found: " + StateName);
                Close();
                return;
            }

            // Fill controls from first row
            DisplayState(table.Rows[0]);

            // Optional: make fields display-only
            SetReadOnly(true);
        }

        private void DisplayState(DataRow row)
        {
            populationTxtBox.Text = row["Population"].ToString();
            capitolTxtBox.Text = row["Capitol"].ToString();
            largestCityTxtbox.Text = row["LargestCity"].ToString();
            stateFlowerTextBox.Text = row["StateFlower"].ToString();
            stateBirdtxt.Text = row["StateBird"].ToString();
            stateColortxt.Text = row["Colors"].ToString();
            medianIncometxt.Text = row["MedianIncome"].ToString();
            compJobTxt.Text = row["ComputerJobsPercent"].ToString();
            flagdescriptiontxtbox.Text = row["FlagDescription"].ToString();
        }

        private void SetReadOnly(bool readOnly)
        {
            populationTxtBox.ReadOnly = readOnly;
            capitolTxtBox.ReadOnly = readOnly;
            largestCityTxtbox.ReadOnly = readOnly;
            stateFlowerTextBox.ReadOnly = readOnly;
            stateBirdtxt.ReadOnly = readOnly;
            stateColortxt.ReadOnly = readOnly;
            medianIncometxt.ReadOnly = readOnly;
            compJobTxt.ReadOnly = readOnly;

            // RichTextBox uses ReadOnly too
            flagdescriptiontxtbox.ReadOnly = readOnly;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
