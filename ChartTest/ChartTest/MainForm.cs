using LiveCharts;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Presenters;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {
        private SalesPresenter presenter_;
        void FillCartesianChart()
        {
            ItemsList.DataSource = presenter_.GetAllItems();
            ItemsList.DisplayMember = "Name";
            if (ItemsList.Items.Count > 0)
            {
                presenter_.ShowSalesByItem(((Item)ItemsList.Items[0]).Name);
            }
        }

        void FillAngular()
        {
            angular.FromValue = 0;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.Gray;
            angular.NeedleFill = Brushes.DarkBlue;
        }

        void FillSolid()
        {
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
        }
        void PieChart()
        {
            
        }
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new SalesPresenter(new List<ISalesView> { cartesian });

            FillCartesianChart();

            FillAngular();

            FillSolid();
        }

        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item selectedItem = ((Item)(ItemsList.SelectedItem));
            if(selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByItem(selectedItem.Name);
            double percent = Math.Round(
                presenter_.GetProfitPercentByItem(selectedItem), 2);

            angular.Value = percent;
            solid.Value = percent;
        }
    }
}
