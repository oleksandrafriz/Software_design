using System.Collections.Generic;
using ClassLibrary;

namespace Inventory
{
    public class MainController
    {
        private readonly IProductRepository productRepository;
        private readonly ISupplierRepository supplierRepository;

        public MainController(IProductRepository productRepository, ISupplierRepository supplierRepository)
        {
            this.productRepository = productRepository;
            this.supplierRepository = supplierRepository;
        }

        public List<Product> GetAllProducts()
        {
            return productRepository.GetAllProducts();
        }

        public Product GetProductById(int productId)
        {
            return productRepository.GetProductById(productId);
        }

        public void AddProduct(Product product)
        {
            productRepository.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            productRepository.UpdateProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            productRepository.DeleteProduct(productId);
        }

        public List<Product> SearchProductsByName(string productName)
        {
            return productRepository.SearchProductsByName(productName);
        }

        public List<Postachalnik> GetAllSuppliers()
        {
            return supplierRepository.GetAllSuppliers();
        }
    }
}
