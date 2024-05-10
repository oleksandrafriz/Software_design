using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base("Преміум підписка", 29.99m, 1, new List<string> { "Всі види відео та каналів" }, new List<string> { "4K трансляція", "Відео офлайн" })
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Вид підписки: {Name},\n" +
                 $"Тариф: {MonthlyFee}$,\n" +
                 $"Період використання: {MinimumSubscriptionPeriod} місяць(і),\n" +
                 $"Канали: {string.Join(", ", Channels)},\n" +
                 $"Переваги: {string.Join(", ", Features)}");
        }
    }
}
