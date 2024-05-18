using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class AddProductCommand : ICommand
    {
        private readonly IProductRepository _repository;
        private readonly Product _product;

        public AddProductCommand(IProductRepository repository, Product product)
        {
            _repository = repository;
            _product = product;
        }

        public void Execute()
        {
            _repository.AddProduct(_product);
        }
    }

    public class UpdateProductCommand : ICommand
    {
        private readonly IProductRepository _repository;
        private readonly Product _product;

        public UpdateProductCommand(IProductRepository repository, Product product)
        {
            _repository = repository;
            _product = product;
        }

        public void Execute()
        {
            _repository.UpdateProduct(_product);
        }
    }

    public class DeleteProductCommand : ICommand
    {
        private readonly IProductRepository _repository;
        private readonly int _productId;

        public DeleteProductCommand(IProductRepository repository, int productId)
        {
            _repository = repository;
            _productId = productId;
        }

        public void Execute()
        {
            _repository.DeleteProduct(_productId);
        }
    }

    public class GetProductByIdCommand : ICommand
    {
        private readonly IProductRepository _repository;
        private readonly int _productId;
        public Product Product { get; private set; }

        public GetProductByIdCommand(IProductRepository repository, int productId)
        {
            _repository = repository;
            _productId = productId;
        }

        public void Execute()
        {
            Product = _repository.GetProductById(_productId);
        }
    }

}
