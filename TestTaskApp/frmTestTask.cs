using System;
using System.Windows.Forms;

namespace TestTaskApp
{
    public partial class frmTestTask : Form
    {
        private const string _noResult = "No result";
        
        public frmTestTask()
        {
            InitializeComponent();
            ResetData();
        }

        #region Timestamp
        private Int32 _timestamp = 0;
        private Int32 Timestamp
        {
            get
            {
                return _timestamp;
            }
            set
            {
                _timestamp = value;

                // Set Label Text
                lblTimestampValue.Text = (_timestamp > 0 ? _timestamp.ToString() : _noResult);
            }
        }
        #endregion

        #region OutputValue
        private string _outputValue = "";
        private string OutputValue
        {
            get
            {
                return _outputValue;
            }
            set
            {
                _outputValue = value;

                // Set Label Text
                lblOutputValueValue.Text = (!string.IsNullOrWhiteSpace(_outputValue) ? _outputValue : _noResult);

                // Allow manual Coluns in Grid using
                dgvSymbolResults.AutoGenerateColumns = false;
                // Generate Datasource from OutputValue and set Grod DataSource
                dgvSymbolResults.DataSource = DataSources.SymbolResults.GetSymbolResultsSource(_outputValue);
            }
        }
        #endregion

        /// <summary>
        /// Reset Data and Form results
        /// </summary>
        private void ResetData()
        {
            Timestamp = 0;
            OutputValue = string.Empty;
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            // Converting DateTime to Epoch format
            Timestamp = (Int32)(dtpDateTime.Value.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                // Call request to Beacon server
                OutputValue = await Requests.BeaconRecordRequests.GetOutputValue(Timestamp);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void dtpDateTime_ValueChanged(object sender, EventArgs e)
        {
            // Reset Data and Form results when DateTime changed
            ResetData();
        }
    }
}
