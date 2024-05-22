using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Commands
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
}
