﻿using Microsoft.AspNetCore.Mvc;
using Simple_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Simple_API.Services
{
    public class ProductsService:IProductsService
    {
        private List<Product> _productItems;
        public ProductsService()
        {
            _productItems = new List<Product>();
        }

        public Product AddProduct(Product productItem)
        {
            _productItems.Add(productItem);
            return productItem;
        }

        public string DeleteProduct(string id)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].Id== id)
                {
                    _productItems.RemoveAt(index);
                }
            }

            return id;
        }

        public List<Product> GetProducts()
        {
            return _productItems;
        }

        public Product UpdateProduct(string id, Product productItem)
        {
            for (var index = _productItems.Count - 1; index >= 0; index--)
            {
                if (_productItems[index].Id == id)
                {
                    _productItems[index] = productItem;
                }
            }
            return productItem;
        }
    }
}