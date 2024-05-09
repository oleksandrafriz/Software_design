using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class SalesHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public void HandleRequest(string request)
        {
            if (request.ToLower().Contains("sales") || request.ToLower().Contains("purchase"))
            {
                Console.WriteLine("Обробник продажів: Ваш запит було оброблено.");
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
