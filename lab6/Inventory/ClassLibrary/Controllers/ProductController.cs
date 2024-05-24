using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Controllers
{
    public class ProductController
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        public List<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public Product GetProductById(int productId)
        {
            return _productRepository.GetProductById(productId);
        }

        public void AddProduct(Product product)
        {
            new AddProductCommand(_productRepository, product).Execute();
        }

        public void UpdateProduct(Product product)
        {
            new UpdateProductCommand(_productRepository, product).Execute();
        }

        public void DeleteProduct(int productId)
        {
            new DeleteProductCommand(_productRepository, productId).Execute();
        }

        public List<Product> SearchProductsByName(string productName)
        {
            return _productRepository.SearchProductsByName(productName);
        }
    }
}
