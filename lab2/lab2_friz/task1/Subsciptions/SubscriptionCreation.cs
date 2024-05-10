using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class SubscriptionCreation
    {
        public static Subscription CreateSubscription(string type)
        {
            switch (type.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription();
                case "educational":
                    return new EducationalSubscription();
                case "premium":
                    return new PremiumSubscription();
                default:
                    throw new ArgumentException("Invalid subscription type");
            }
        }
    }

    public interface ISubscriptionCreator
    {
        Subscription CreateSubscription(string type);
    }
}
