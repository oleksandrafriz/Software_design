using System;

namespace ClassLibrary
{
    public abstract class ProductCommandBase : ICommand
    {
        protected readonly IProductRepository _repository;

        protected ProductCommandBase(IProductRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public abstract void Execute();
    }

    public class AddProductCommand : ProductCommandBase
    {
        private readonly Product _product;

        public AddProductCommand(IProductRepository repository, Product product)
            : base(repository)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public override void Execute()
        {
            _repository.AddProduct(_product);
        }
    }

    public class UpdateProductCommand : ProductCommandBase
    {
        private readonly Product _product;

        public UpdateProductCommand(IProductRepository repository, Product product)
            : base(repository)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public override void Execute()
        {
            _repository.UpdateProduct(_product);
        }
    }

    public class DeleteProductCommand : ProductCommandBase
    {
        private readonly int _productId;

        public DeleteProductCommand(IProductRepository repository, int productId)
            : base(repository)
        {
            _productId = productId;
        }

        public override void Execute()
        {
            _repository.DeleteProduct(_productId);
        }
    }

    public class GetProductByIdQuery : ICommand
    {
        private readonly IProductRepository _repository;
        private readonly int _productId;
        public Product Product { get; private set; }

        public GetProductByIdQuery(IProductRepository repository, int productId)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _productId = productId;
        }

        public void Execute()
        {
            Product = _repository.GetProductById(_productId);
        }
    }
}
