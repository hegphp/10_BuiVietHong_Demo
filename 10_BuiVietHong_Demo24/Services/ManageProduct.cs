using _10_BuiVietHong_Demo24.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _10_BuiVietHong_Demo24.Services
{
    internal class ManageProduct
    {
        string fileName = "ProductList.json";
        List<Product> products = new List<Product>();
        public List<Product> GetProducts() {
            GetDataFromFile();
            return products;
        }

        public void InsertProduct(Product product)
        {
            try
            {
                //check if the product is existed or not
                Product p = products.SingleOrDefault(p => p.ProductID == product.ProductID);
                if (p != null)
                {
                    throw new Exception("Product is existed");
                }
                products.Add(product);
                StoreToFile();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try {
                //Check if the product is existed or not
                Product p = products.SingleOrDefault(p => p.ProductID == product.ProductID);
                if (p == null)
                {
                    throw new Exception("Product is not existed");
                }
                //Update the product
                p.ProductName = product.ProductName;
                StoreToFile();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void GetDataFromFile()
        {
            try {
                //check if the filename is existed or not
                if(File.Exists(fileName))
                {
                    //read the content of the file
                    string json = File.ReadAllText(fileName);
                    //deserialize the json string to a list of product
                    products = JsonSerializer.Deserialize<List<Product>>(json);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteProduct(Product product) {
            try{
                //check if the product id is existed or not
                Product p = products.SingleOrDefault(p => p.ProductID == product.ProductID);
                if (p == null)
                {
                    throw new Exception("Product is not existed");
                }
                products.Remove(p);
                StoreToFile();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void StoreToFile()
        {
            try
            {
                //Serialize into a string
                string json = JsonSerializer.Serialize(products, new JsonSerializerOptions {WriteIndented = true });
                File.WriteAllText(fileName, json);
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
