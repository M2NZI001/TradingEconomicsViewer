using System;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Wpf;


namespace TradingEconomicsViewer.Presentation
{
    public static class ChartHelper
    {
        public static void PlotComparisonChart(
            LiveCharts.WinForms.CartesianChart chart,
            double? data1,
            double? data2,
            string country1,
            string country2,
            string indicator)
        {
            chart.Series.Clear();
            chart.AxisX.Clear();
            chart.AxisY.Clear();

            var values = new ChartValues<double>();
            var labels = new List<string>();

            if (data1.HasValue && data2.HasValue)
            {
                values.Add(data1.Value);
                values.Add(data2.Value);

                labels.Add(country1);
                labels.Add(country2);

                chart.Series.Add(new ColumnSeries
                {
                    Title = indicator, // Show indicator as the legend title
                    Values = values,
                    MaxColumnWidth = 40,
                    DataLabels = true,
                    LabelPoint = point => point.Y.ToString("N2") 
                });

                chart.AxisX.Add(new Axis
                {
                    Title = "Country",
                    Labels = labels,
                    LabelsRotation = 0,
                    Separator = new Separator { Step = 1 }
                });

                chart.AxisY.Add(new Axis
                {
                    Title = indicator,
                    LabelFormatter = value => value.ToString("N2")
                });

                chart.LegendLocation = LegendLocation.Top;
                chart.Zoom = ZoomingOptions.None;
            }
         
        }

    }
}



