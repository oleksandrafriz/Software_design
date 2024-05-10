using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public abstract class Subscription
    {
        public string Name { get; set; }
        public decimal MonthlyFee { get; set; }
        public int MinimumSubscriptionPeriod { get; set; }
        public List<string> Channels { get; set; }
        public List<string> Features { get; set; }

        protected Subscription(string name, decimal monthlyFee, int minimumPeriod, List<string> channels, List<string> features)
        {
            Name = name;
            MonthlyFee = monthlyFee;
            MinimumSubscriptionPeriod = minimumPeriod;
            Channels = channels;
            Features = features;
        }

        public abstract void DisplayInfo();
    }
}
