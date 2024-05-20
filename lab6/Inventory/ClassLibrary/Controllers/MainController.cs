using System;
using System.Collections.Generic;
using ClassLibrary;
using ClassLibrary.Commands;

namespace Inventory
{
    public class MainController
    {
        private readonly IProductRepository _productRepository;
        private readonly ISupplierRepository _supplierRepository;

        public MainController(IProductRepository productRepository, ISupplierRepository supplierRepository)
        {
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _supplierRepository = supplierRepository ?? throw new ArgumentNullException(nameof(supplierRepository));
        }

        public List<Product> GetAllProducts() => _productRepository.GetAllProducts();

        public Product GetProductById(int productId) => _productRepository.GetProductById(productId);

        public void AddProduct(Product product)
        {
            var command = new AddProductCommand(_productRepository, product);
            command.Execute();
        }

        public void UpdateProduct(Product product)
        {
            var command = new UpdateProductCommand(_productRepository, product);
            command.Execute();
        }

        public void DeleteProduct(int productId)
        {
            var command = new DeleteProductCommand(_productRepository, productId);
            command.Execute();
        }

        public List<Product> SearchProductsByName(string productName) => _productRepository.SearchProductsByName(productName);

        public List<Postachalnik> GetAllSuppliers() => _supplierRepository.GetAllSuppliers();
    }
}
