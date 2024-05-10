using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ManagerCall : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("\nПідписка чeрез дзівнок");
            return SubscriptionCreation.CreateSubscription(type);
        }
    }
}
