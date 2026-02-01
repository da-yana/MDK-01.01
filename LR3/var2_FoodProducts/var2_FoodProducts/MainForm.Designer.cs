namespace var2_FoodProducts
{
    partial class MainForm
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
            this.CategoriesListBox = new System.Windows.Forms.ListBox();
            this.ProductsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ProductsPictureBox = new System.Windows.Forms.PictureBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ExpiryLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesListBox
            // 
            this.CategoriesListBox.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesListBox.FormattingEnabled = true;
            this.CategoriesListBox.ItemHeight = 27;
            this.CategoriesListBox.Location = new System.Drawing.Point(12, 62);
            this.CategoriesListBox.Name = "CategoriesListBox";
            this.CategoriesListBox.Size = new System.Drawing.Size(254, 139);
            this.CategoriesListBox.TabIndex = 0;
            this.CategoriesListBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesListBox_SelectedIndexChanged);
            // 
            // ProductsComboBox
            // 
            this.ProductsComboBox.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsComboBox.FormattingEnabled = true;
            this.ProductsComboBox.Location = new System.Drawing.Point(12, 261);
            this.ProductsComboBox.Name = "ProductsComboBox";
            this.ProductsComboBox.Size = new System.Drawing.Size(315, 35);
            this.ProductsComboBox.TabIndex = 1;
            this.ProductsComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Товары в выбранной категории:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Все категории товаров:";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(244, 329);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(99, 34);
            this.QuantityNumericUpDown.TabIndex = 4;
            this.QuantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество товаров:";
            // 
            // OrderButton
            // 
            this.OrderButton.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderButton.Location = new System.Drawing.Point(17, 396);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(310, 42);
            this.OrderButton.TabIndex = 6;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // ProductsPictureBox
            // 
            this.ProductsPictureBox.Location = new System.Drawing.Point(376, 12);
            this.ProductsPictureBox.Name = "ProductsPictureBox";
            this.ProductsPictureBox.Size = new System.Drawing.Size(505, 189);
            this.ProductsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductsPictureBox.TabIndex = 7;
            this.ProductsPictureBox.TabStop = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(443, 217);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 27);
            this.PriceLabel.TabIndex = 8;
            this.PriceLabel.Text = "label4";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(552, 261);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(67, 27);
            this.ManufacturerLabel.TabIndex = 9;
            this.ManufacturerLabel.Text = "label4";
            // 
            // ExpiryLabel
            // 
            this.ExpiryLabel.AutoSize = true;
            this.ExpiryLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExpiryLabel.Location = new System.Drawing.Point(477, 299);
            this.ExpiryLabel.Name = "ExpiryLabel";
            this.ExpiryLabel.Size = new System.Drawing.Size(67, 27);
            this.ExpiryLabel.TabIndex = 10;
            this.ExpiryLabel.Text = "label4";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLabel.Location = new System.Drawing.Point(498, 336);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(67, 27);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(371, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Годен до:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(371, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Цена:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(371, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Производитель:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(371, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 27);
            this.label7.TabIndex = 15;
            this.label7.Text = "Описание:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.ExpiryLabel);
            this.Controls.Add(this.ManufacturerLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductsPictureBox);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QuantityNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductsComboBox);
            this.Controls.Add(this.CategoriesListBox);
            this.Name = "MainForm";
            this.Text = "Торговая Лавка";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CategoriesListBox;
        private System.Windows.Forms.ComboBox ProductsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.PictureBox ProductsPictureBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ExpiryLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

