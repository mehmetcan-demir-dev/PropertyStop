﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.ProductRepository;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductControllers : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductControllers(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
    }
}
