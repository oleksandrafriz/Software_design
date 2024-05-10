using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MobileApp : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("\nПідписка через мобільний застосунок");
            
            return SubscriptionCreation.CreateSubscription(type);
        }
    }
}
