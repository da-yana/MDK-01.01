namespace LR_Graph
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pieChart = new LiveCharts.WinForms.PieChart();
            this.listBoxDrinks = new System.Windows.Forms.ListBox();
            this.labelRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartesianChart
            // 
            this.cartesianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartesianChart.Location = new System.Drawing.Point(201, 12);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(587, 393);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.Text = "cartesianChart1";
            // 
            // pieChart
            // 
            this.pieChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pieChart.Location = new System.Drawing.Point(0, 162);
            this.pieChart.Name = "pieChart";
            this.pieChart.Size = new System.Drawing.Size(207, 276);
            this.pieChart.TabIndex = 1;
            this.pieChart.Text = "pieChart1";
            // 
            // listBoxDrinks
            // 
            this.listBoxDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDrinks.FormattingEnabled = true;
            this.listBoxDrinks.ItemHeight = 20;
            this.listBoxDrinks.Location = new System.Drawing.Point(12, 12);
            this.listBoxDrinks.Name = "listBoxDrinks";
            this.listBoxDrinks.Size = new System.Drawing.Size(172, 144);
            this.listBoxDrinks.TabIndex = 2;
            this.listBoxDrinks.SelectedIndexChanged += new System.EventHandler(this.listBoxDrinks_SelectedIndexChanged);
            // 
            // labelRevenue
            // 
            this.labelRevenue.AutoSize = true;
            this.labelRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRevenue.Location = new System.Drawing.Point(406, 418);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(51, 20);
            this.labelRevenue.TabIndex = 3;
            this.labelRevenue.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRevenue);
            this.Controls.Add(this.listBoxDrinks);
            this.Controls.Add(this.pieChart);
            this.Controls.Add(this.cartesianChart);
            this.Name = "Form1";
            this.Text = "Cafe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private LiveCharts.WinForms.PieChart pieChart;
        private System.Windows.Forms.ListBox listBoxDrinks;
        private System.Windows.Forms.Label labelRevenue;


    }
}

