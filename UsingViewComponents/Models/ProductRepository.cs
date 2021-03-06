﻿using System.Collections.Generic;


namespace UsingViewComponents.Models
{

    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product newProduct);    
    }

    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>
        {
            new Product{Name = "Koyak", Price = 275M},
            new Product{Name = "LiveJaket", Price = 48.95M},
            new Product{Name = "Soccer Ball", Price = 19.50M}
        };

        public IEnumerable<Product> Products => products;

        public void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

    }
}
