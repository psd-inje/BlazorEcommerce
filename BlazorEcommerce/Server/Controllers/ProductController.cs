using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
        private readonly IProductService  _productService;

        public ProductController(IProductService productService)
        {
             _productService = productService;
        }

		[HttpGet]
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
		{
			var response = await _productService.GetProductsAsync();
			return Ok(response);
		}

		[HttpGet("{productId}")]
		public async Task<ActionResult<ServiceResponse<Product>>> GetProduct(int productId)
		{
			var response = await _productService.GetProductsAsync(productId);
			return Ok(response);
		}

		[HttpGet("category/{categoryUrl}")]
		public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProductsByCategory(string categoryUrl)
		{
			var response = await _productService.GetProductsByCategoryAsync(categoryUrl);
			return Ok(response);
		}

    }
}
