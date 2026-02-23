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
            var data = new StateData();
            StateInfo state = data.GetStateByName(StateName);

            if (state == null)
            {
                MessageBox.Show("State not found: " + StateName);
                Close();
                return;
            }

            // Fill controls from first row
            DisplayState(state);

            SetReadOnly(true);
        }

        //display base off  class
        private void DisplayState(StateInfo state)
        {
            populationTxtBox.Text = state.Population;
            capitolTxtBox.Text = state.Capitol;
            largestCityTxtbox.Text = state.LargestCity;
            stateFlowerTextBox.Text = state.StateFlower;
            stateBirdtxt.Text = state.StateBird;
            stateColortxt.Text = state.Colors;
            medianIncometxt.Text = state.MedianIncome;
            compJobTxt.Text = state.ComputerJobsPercent;
            flagdescriptiontxtbox.Text = state.FlagDescription;
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
