using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
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
}
