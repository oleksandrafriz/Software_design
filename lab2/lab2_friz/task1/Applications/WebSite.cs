using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class WebSite : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("\nПідписка через веб-сайт");
            return SubscriptionCreation.CreateSubscription(type);
        }
    }
}
