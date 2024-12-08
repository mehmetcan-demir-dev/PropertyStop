using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertyStop.Repositories.ProductRepository;
using System.Threading.Tasks;

namespace PropertyStop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsControllers : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsControllers(IProductRepository productRepository)
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
        [HttpGet("ProductDealOfTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToTrue(id);
            return Ok("Aktifleştirildi.");
        }
        [HttpGet("ProductDealOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToFalse(id);
            return Ok("Pasifleştirildi.");
        }
        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductListingsByEmployeeByTrue")]
        public async Task<IActionResult> ProductListingsByEmployeeByTrue(int id)
        {
            var values = await _productRepository.GetProductListingByEmployeeAsyncByTrue(id);
            return Ok(values);
        }
        [HttpGet("ProductListingsByEmployeeByFalse")]
        public async Task<IActionResult> ProductListingsByEmployeeByFalse(int id)
        {
            var values = await _productRepository.GetProductListingByEmployeeAsyncByFalse(id);
            return Ok(values);
        }
    }
}
