using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base("Навчальна підписка", 14.99m, 3, new List<string> { "Навчання", "Документальні відео" }, new List<string> { "Доступ до архіву" })
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
