using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace var2_FoodProducts
{
    public partial class MainForm : Form
    {
        private Dictionary <string, List<Product>> products_ = new Dictionary<string, List<Product>>(); 
        public MainForm()
        {
            InitializeComponent();

            products_.Add("Хлебобулочные изделия", new List<Product>()
            {
                new Product("Бородинский хлеб", 45.99, "Черёмушки", new DateTime(2026, 2, 5), "Аппетитный ржаный хлеб с корочкой", "C:\\repo burenina\\LR3\\image\\хлеб.png"),
                new Product("Батон с отрубями", 37.49, "Хлебокомбинат ПЕКО", new DateTime(2026, 2, 7), "Пшеничный Нарезной батон", "C:\\repo burenina\\LR3\\image\\батон.jpg"),
                new Product("Баранки", 89.99, "Край Каравай", new DateTime(2026, 3, 24), "Баранки с ванильным ароматом", "C:\\repo burenina\\LR3\\image\\баранки.jpg")
            }
        );
            products_.Add("Мясо", new List<Product>()
            {
                new Product("Куриное филе", 399.99, "Петелинка", new DateTime(2026, 2, 20), "Нежное сочное филе цыпленка", "C:\\repo burenina\\LR3\\image\\куриное филе.jpg"),
                new Product("Говяжья вырезка ", 786.00, "Мираторг", new DateTime(2026, 2, 23), "Зачищенная вырезка из лопатки", "C:\\repo burenina\\LR3\\image\\говяжья вырезка.jpg"),
            }
        );
            products_.Add("Напитки", new List<Product>()
            {
                new Product("Квас", 74.49, "Очаково", new DateTime(2026, 5, 12), "Тёмный квас двойного брожения", "C:\\repo burenina\\LR3\\image\\квас.jpg"),
                new Product("Лимонад", 115.00, "Черноголовка", new DateTime(2026, 12, 1), "Сильногазированный напиток", "C:\\repo burenina\\LR3\\image\\лимонад.jpg"),
                new Product("Чай черный", 59.99, "Азерчай", new DateTime(2027, 1, 1), "Крупнолистовой черный чай", "C:\\repo burenina\\LR3\\image\\чай.jpg")
            }
       );
            products_.Add("Сладости", new List<Product>()
            {
                new Product("Медовик", 120.00, "Фили-бейкер", new DateTime(2026, 3, 17), "Медовик со сливочным кремом","C:\\repo burenina\\LR3\\image\\медовик.jpg"),
                new Product("Эклеры", 255.00, "Вкусняшка из дубровки", new DateTime(2026, 2, 10), "Пироженое с заварным кремом", "C:\\repo burenina\\LR3\\image\\эклеры.jpg"),
                new Product("Макаруны", 99.99, "Сладость в радость", new DateTime(2026, 9, 28), "Печенье с нежным кремом", "C:\\repo burenina\\LR3\\image\\макаруны.png")
            }
       );
            List <string> allCategories = products_.Keys.ToList();
            CategoriesListBox.DataSource = allCategories;
        }

        private void CategoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = CategoriesListBox.SelectedItem.ToString();
            List<Product> productsSelectedCategory = products_[selectedCategory];
            ProductsComboBox.DataSource = productsSelectedCategory;
            ProductsComboBox.DisplayMember = "Name";
        }

        private void ProductsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product selectedProduct = ProductsComboBox.SelectedItem as Product;
            if (selectedProduct != null)
            {
                PriceLabel.Text = selectedProduct.Price.ToString();
                ManufacturerLabel.Text = selectedProduct.Manufacturer;
                ExpiryLabel.Text = selectedProduct.Expiry;
                DescriptionLabel.Text = selectedProduct.Description;

                ProductsPictureBox.Load(selectedProduct.Path);

            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заказ успешно оформлен!", "Успешно");
        }
    }
}
