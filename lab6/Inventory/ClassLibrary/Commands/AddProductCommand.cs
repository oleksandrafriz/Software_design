using ClassLibrary.Commands;
using System;

namespace ClassLibrary
{
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
}
