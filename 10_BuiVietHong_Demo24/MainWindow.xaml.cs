using _10_BuiVietHong_Demo24.Models;
using _10_BuiVietHong_Demo24.Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _10_BuiVietHong_Demo24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        ManageProduct productManager = new ManageProduct();
        private void Window_Loaded(object sender, RoutedEventArgs e) => LoadProducts();

        private void LoadProducts()
        {
            //Load product from file
            productManager.GetDataFromFile();
            //Display product to listbox
            ProductListView.ItemsSource = productManager.GetProducts();
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Product = new Product
                {
                    ProductID = int.Parse(ProductIdTextBox.Text),
                    ProductName = ProductNameTextBox.Text
                };
                productManager.InsertProduct(Product);
                LoadProducts();
            }catch(Exception ex)
            {
                   MessageBox.Show(ex.Message, "Insert product");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Product = new Product
                {
                    ProductID = int.Parse(ProductIdTextBox.Text),
                    ProductName = ProductNameTextBox.Text
                };
                productManager.UpdateProduct(Product);
                LoadProducts();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Update product");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try {
                var Product = new Product {
                    ProductID = int.Parse(ProductIdTextBox.Text)
                };
                productManager.DeleteProduct(Product);
                LoadProducts();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete product");
            }
        }
    }
}