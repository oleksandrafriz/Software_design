using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Inventory
    {

        public List<Animal> Animals { get; set; } = new List<Animal>();
        public List<ZooKeeper> Workers { get; set; } = new List<ZooKeeper>();
        public List<Food> Feeds { get; set; } = new List<Food>();
        public List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();

        public void CheckFeedStock(string feedType)
        {
            var feed = Feeds.FirstOrDefault(f => f.Type == feedType);
            if (feed != null)
            {
                Console.WriteLine($"Вид їжі: {feed.Type}, Кількість: {feed.Quantity}kg");
            }
            else
            {
                Console.WriteLine("Такої їжі не знайдено");
            }
        }

        public int CountWorkers()
        {
            return Workers.Count;
        }

        public void DisplayInventory()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("Облік зоопарку:");

            Console.WriteLine("Тварини:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"Кличка: {animal.Name}, Вид: {animal.Species}, Дата народження: {animal.DateOfBirth.ToShortDateString()}");
            }

            Console.WriteLine("\nПрацівники:");
            foreach (var worker in Workers)
            {
                Console.WriteLine($"Ім'я: {worker.Name}, Посада: {worker.JobTitle}");
            }

            Console.WriteLine("\nКорм:");
            foreach (var feed in Feeds)
            {
                Console.WriteLine($"Тип: {feed.Type}, Кількість: {feed.Quantity}kg");
            }

            Console.WriteLine("\nВольєри: ");
            foreach (var enclosure in Enclosures)
            {
                Console.WriteLine($"Type: {enclosure.Type}, Розмір: {enclosure.Size} кв.м");
            }
        }
    }

}
