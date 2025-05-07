using LiveCharts;

using LiveCharts.Wpf;
using shisharp.bms.backend.database.repository;
using shisharp.bms.backend.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace shisharp.bms.backend.utils {
    public class ChartGenerator {

        private ChartRepository chartRepo = new ChartRepository();
        public ChartGenerator() { }


        //This is for pie chart 
        public async Task GeneratePieChartForGenderDistribution(LiveCharts.WinForms.PieChart pieChart) {
            List<ChartsModel> data = await chartRepo.GetTotalMaleAndFemale();
            try {
                SeriesCollection series = new SeriesCollection();


                if (data != null) {
                    foreach (ChartsModel item in data) {
                        series.Add(
                            new PieSeries()
                            {
                                Title = item.LabelName,
                                Values = new ChartValues<double> { item.Value },
                                DataLabels = true
                            }
                            );
                    }
                }
                //set the series
                pieChart.LegendLocation = LegendLocation.Bottom;
                pieChart.Series = series;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        } // end

        // this is for cartesian plain chart
        public async Task GenerateCartesianPlainChartForTotalHouseHold(LiveCharts.WinForms.CartesianChart cartesianChart) {
            try {
                SeriesCollection series = new SeriesCollection();
                List<ChartsModel> data = await chartRepo.GetTotalHouseHold();
                if (data != null) {
                    foreach (ChartsModel item in data) {
                        series.Add(
                            new ColumnSeries()
                            {
                                Title = item.LabelName,
                                Values = new ChartValues<double> { item.Value },
                            }
                            );
                    }

                }
                cartesianChart.LegendLocation = LegendLocation.Bottom;
                cartesianChart.Series = series;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        } // end

        public async Task GenerateGaugeChartForTotalVoters(LiveCharts.WinForms.SolidGauge gaugeChart) {
            try {
                List<int> data = await chartRepo.GetTotalVoters();
                int totalEligible = data[0];
                int totalVoters = data[1];
                double percentageVal = (double)totalVoters / totalEligible * 100;
                if (data != null) {
                    gaugeChart.Name = "Total Voters";
                    gaugeChart.LabelFormatter = val => $"{val:N0}%";
                    gaugeChart.Value = percentageVal;

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
