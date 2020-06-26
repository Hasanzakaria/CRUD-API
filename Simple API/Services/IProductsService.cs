﻿using Simple_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_API.Services
{
   public interface IProductsService
    {
        public List<Product> GetProducts();
        public Product AddProduct(Product productItem);
        public Product UpdateProduct(string id, Product productItem);
        public string DeleteProduct(string id);
    }
}
