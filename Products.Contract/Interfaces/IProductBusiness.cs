
using Products.Contract.Models;

namespace Products.Contract.Interfaces
{
	public interface IProductBusiness
	{
		Product AddProduct(Product newProduct);

		IEnumerable<Product> GetProducts();
	}
}
