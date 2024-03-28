using System;
using System.Collections.Generic;

namespace Lab6
{
    public class ProductManager
    {
        private List<IProduct> products = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public bool RemoveProduct(IProduct product)
        {
            return products.Remove(product);
        }

        public void EditProduct(int index, IProduct newProduct)
        {
            if (index >= 0 && index < products.Count)
            {
                products[index] = newProduct;
            }
            else
            {
                Console.WriteLine("Неверный индекс");
            }
        }

        public void DisplayProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
