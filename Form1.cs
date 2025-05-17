using System;
using System.Windows.Forms;
using TradingEconomicsViewer.Business;
using TradingEconomicsViewer.Data;

namespace TradingEconomicsViewer
{
    public partial class Form1 : Form
    {
        private readonly EconomicsService _economicsService;
        private string ApiKey = MyApi.ApiKey;

        public Form1()
        {
            InitializeComponent();
            _economicsService = new EconomicsService(ApiKey);
        }

        private void btnCompareForm_Click(object sender, EventArgs e)
        {
            using (var comparatorForm = new TradingEconomicsViewer.Presentation.TradingEconomicsComparator())
            {
                comparatorForm.ShowDialog();
            }
        }

        private async void btnFetchData_Click_1(object sender, EventArgs e)
        {
            if (cmbCountries.SelectedItem == null)
            {
                MessageBox.Show("Please select a country");
                return;
            }
            try
            {
                var country = cmbCountries.SelectedItem.ToString();
                var data = await _economicsService.GetCountryEconomicDataAsync(country);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
