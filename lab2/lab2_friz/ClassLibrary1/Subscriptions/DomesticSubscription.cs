using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base("Домашня підписка", 9.99m, 1, new List<string> { "Новини", "Спорт" }, new List<string> { "HD трансляція" })
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
