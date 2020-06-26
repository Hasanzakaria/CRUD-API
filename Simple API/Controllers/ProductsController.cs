using Microsoft.AspNetCore.Mvc;
using Simple_API.Models;
using Simple_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_API.Controllers
{
    public class ProductsController:ControllerBase
    {
        private IProductsService _service;


        public ProductsController( IProductsService service)
        {
            _service = service;

        }

        [HttpGet("/api/products")]
        public ActionResult<List<Product>> GetProducts()
        {
            return _service.GetProducts();
        }

        [HttpPost("/api/products")]
        public ActionResult<Product> AddProduct(Product product)
        {
           return _service.AddProduct(product);
        }

        [HttpPut("/api/products/{id}")]
        public ActionResult<Product> UpdateProduct(string id, Product product)
        {
            return _service.UpdateProduct(id, product);
        }

        [HttpDelete("/api/products/{id}")]
        public ActionResult<string> DeleteProduct(string id)
        {
            return _service.DeleteProduct(id);
            //_logger.LogInformation("products", _products);
        }
    }
}

