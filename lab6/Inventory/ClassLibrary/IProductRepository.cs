using System.Collections.Generic;

namespace ClassLibrary
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        Product GetProductById(int productId);
        List<Product> GetAllProducts();
        List<Product> SearchProductsByName(string name);
    }
}
