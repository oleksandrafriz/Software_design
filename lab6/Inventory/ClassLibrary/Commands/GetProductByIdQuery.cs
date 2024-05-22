using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
{
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
