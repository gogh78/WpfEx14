using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfEx14.Product;

namespace WpfEx14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Сыр",
                ProductType = "Еда",
                Price = 800,
                Category = Categories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Микроволновка",
                ProductType = "Бытовая техника",
                Price = 12500,
                Category = Categories.Tehnic
            });
            products.Add(new Product()
            {
                ProductName = "Помидоры Черри",
                ProductType = "Еда",
                Price = 500,
                Category = Categories.Food
            });
            lstBox.ItemsSource = products;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product()
            {
                ProductName = "Фен",
                ProductType = "Бытовая техника",
                Price = 3200,
                Category = Categories.Tehnic
            });
            lstBox.ItemsSource = products;

        }
    }

}
