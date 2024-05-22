using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
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
}