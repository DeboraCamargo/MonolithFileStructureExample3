using Microsoft.AspNetCore.Mvc;
using Products.Contract.Interfaces;
using Products.Contract.Models;

namespace SpikeMono.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductController : ControllerBase
	{
		private readonly ILogger<ProductController> _logger;
		private readonly IProductBusiness _productBusiness;

		public ProductController(ILogger<ProductController> logger, IProductBusiness productBusiness)
		{
			_logger = logger;
			_productBusiness = productBusiness;
		}

		[HttpGet(Name = "GetProduct")]
		public IEnumerable<Product> Get()
		{
			return _productBusiness.GetProducts();
		}

		[HttpPost(Name = "AddProduct")]
		public string Post([FromBody] Product newProduct)
		{
			var product = _productBusiness.AddProduct(newProduct);
			return product.Id;
		}
	}
}
