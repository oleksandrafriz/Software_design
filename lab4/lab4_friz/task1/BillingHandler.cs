using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class BillingHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void HandleRequest(string request)
        {
            if (request.ToLower().Contains("billing") || request.ToLower().Contains("payment"))
            {
                Console.WriteLine("Обробник платежів: Ваш запит було оброблено.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Вибачте, ми не змогли знайти відповідний рівень підтримки для вашого запиту.");
            }
        }
    }
}
