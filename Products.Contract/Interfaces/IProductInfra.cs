
using Products.Contract.Models;

namespace Products.Contract.Interfaces
{
    public interface IProductInfra
    {
        Product AddProduct(Product newProduct);

        IEnumerable<Product> GetProducts();
    }
}
