using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TradingEconomicsViewer.Business;
using TradingEconomicsViewer.Data;

namespace TradingEconomicsViewer.Presentation
{
    public partial class TradingEconomicsComparator : Form
    {
        private readonly EconomicsService _service;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private string ApiKey = MyApi.ApiKey;
        private SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

        public TradingEconomicsComparator()
        {
            InitializeComponent();

            // Initialize API service and comparison logic
            _service = new EconomicsService(ApiKey);

            InitializeChart();
            LoadIndicatorsAsync();

            // Initialize the status label
            lblLoading.Text = "Ready";
        }

        private void InitializeChart()
        {
            panel1.Controls.Clear();

            // Initialize the chart with proper docking
            cartesianChart = new LiveCharts.WinForms.CartesianChart
            {
                Dock = DockStyle.Fill
            };

            panel1.Controls.Add(cartesianChart);
        }

        private async void LoadIndicatorsAsync()
        {
            try
            {
                cmbIndicator.Enabled = false;
                cmbIndicator.Text = "Loading...";

                var indicators = await _service.GetAllIndicatorsAsync();
                cmbIndicator.DataSource = indicators.OrderBy(x => x).ToList();

                cmbIndicator.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load indicators: " + ex.Message);
                cmbIndicator.Text = "Error loading";
            }
        }

        private async void btnCompare_Click(object sender, EventArgs e)
        {
            string country1 = txtCountry1.Text.Trim();
            string country2 = txtCountry2.Text.Trim();
            string indicator = cmbIndicator.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(country1) || string.IsNullOrEmpty(country2) || string.IsNullOrEmpty(indicator))
            {
                MessageBox.Show("Please enter both countries and select an indicator.");
                return;
            }

            // Prevent concurrent requests
            if (!await _semaphore.WaitAsync(0))
            {
                MessageBox.Show("Another request is already in progress. Please wait.");
                return;
            }

            try
            {
                btnCompare.Enabled = false;
                Cursor = Cursors.WaitCursor;
                lblLoading.Text = "Fetching comparison data...";

                var data1 = await _service.GetIndicatorValueForCountryAsync(country1, indicator);
                var data2 = await _service.GetIndicatorValueForCountryAsync(country2, indicator);

                if (data1 == null || data2 == null || data1 == 0 || data2 == 0)
                {
                    MessageBox.Show("No data available for one or both countries.");
                    return;
                }

                ChartHelper.PlotComparisonChart(cartesianChart, data1, data2, country1, country2, indicator);
                lblLoading.Text = "Comparison plotted.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching or displaying comparison: " + ex.Message);
                lblLoading.Text = "Error occurred.";
            }
            finally
            {
                btnCompare.Enabled = true;
                Cursor = Cursors.Default;
                _semaphore.Release();
            }
        }

        private async void btnFetchData_Click(object sender, EventArgs e)
        {
            string country = cmbCountries.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(country))
            {
                MessageBox.Show("Please select a country.");
                return;
            }

            if (!await _semaphore.WaitAsync(0))
            {
                MessageBox.Show("Another request is already in progress. Please wait.");
                return;
            }

            var indicatorsOfInterest = new List<string>
            {
                "GDP",
                "Interest Rate",
                "Unemployment Rate",
                "Inflation Rate"
            };

            listBoxResults.Items.Clear();
            listBoxResults.Items.Add($"--- Economic Data for {country.ToUpper()} ---");

            try
            {
                btnFetchData.Enabled = false;
                Cursor = Cursors.WaitCursor;
                lblLoading1.Text = "Fetching economic data...";

                bool foundAnyData = false;

                foreach (var indicator in indicatorsOfInterest)
                {
                    double? value = await _service.GetIndicatorValueForCountryAsync(country, indicator);

                    if (value != null)
                    {
                        listBoxResults.Items.Add($"\n{indicator}: {value}");
                        foundAnyData = true;
                    }
                    else
                    {
                        listBoxResults.Items.Add($"{indicator}: No data found.");
                    }
                }

                if (!foundAnyData)
                {
                    listBoxResults.Items.Add("No economic data found for this country.");
                }

                lblLoading1.Text = "Data fetch complete";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching data: " + ex.Message);
                lblLoading1.Text = "Error fetching data";
            }
            finally
            {
                btnFetchData.Enabled = true;
                Cursor = Cursors.Default;
                _semaphore.Release();
            }
        }

    }
}






