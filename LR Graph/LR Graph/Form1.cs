using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.WinForms;

namespace LR_Graph
{
    public partial class Form1 : Form
    {
        private CafeData cafeData;

        public Form1()
        {
            InitializeComponent();
            cafeData = new CafeData();
            LoadDrinks();
        }

        private void LoadDrinks()
        {
            listBoxDrinks.DisplayMember = "Name";
            listBoxDrinks.ValueMember = "Id";
            listBoxDrinks.DataSource = cafeData.Drinks;
        }

        private void listBoxDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDrinks.SelectedItem is Drink selectedDrink)
            {
                ShowDrinkSales(selectedDrink);
                ShowRevenueDistribution();
                UpdateTotalRevenue();
            }
        }

        private void ShowDrinkSales(Drink drink)
        {
            var sales = cafeData.GetSalesForDrink(drink.Id);

            var salesByDay = sales
                .GroupBy(s => s.Date.Date)
                .Select(g => new { Date = g.Key, TotalQuantity = g.Sum(s => s.Quantity) })
                .OrderBy(x => x.Date)
                .ToList();

            var chartValues = new ChartValues<int>();
            var labels = new List<string>();

            foreach (var daySale in salesByDay)
            {
                chartValues.Add(daySale.TotalQuantity);
                labels.Add(daySale.Date.ToString("dd.MM"));
            }

            cartesianChart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = drink.Name,
                    Values = chartValues,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                }
            };

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisX.Add(new Axis
            {
                Title = "Дата",
                Labels = labels
            });

            cartesianChart.AxisY.Clear();
            cartesianChart.AxisY.Add(new Axis
            {
                Title = "Количество продаж",
                LabelFormatter = value => value.ToString("N0")
            });

            cartesianChart.LegendLocation = LegendLocation.Top;
        }

        private void ShowRevenueDistribution()
        {
            var revenue = cafeData.GetRevenueByDrink();
            decimal totalRevenue = revenue.Sum(x => x.Value);

            var seriesCollection = new SeriesCollection();

            foreach (var item in revenue)
            {
                if (item.Value > 0)
                {
                    double percentage = (double)(item.Value / totalRevenue * 100);

                    seriesCollection.Add(new PieSeries
                    {
                        Title = $"{item.Key} ({percentage:F1}%)",
                        Values = new ChartValues<decimal> { item.Value },
                        DataLabels = true,
                        LabelPoint = chartPoint =>
                            $"{chartPoint.SeriesView.Title}: {chartPoint.Y:F0} руб."
                    });
                }
            }

            pieChart.Series = seriesCollection;
            pieChart.LegendLocation = LegendLocation.Right;
        }

        private void UpdateTotalRevenue()
        {
            var revenue = cafeData.GetRevenueByDrink();
            decimal totalRevenue = revenue.Sum(x => x.Value);

            labelRevenue.Text = $"Общая выручка: {totalRevenue:C}";
        }
    }
}


