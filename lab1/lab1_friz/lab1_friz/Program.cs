using System;

using ClassLibrary;
using System.Text;

namespace lab1_friz
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Inventory zooInventory = new Inventory();

            zooInventory.Animals.Add(new Lion("Симба", new DateTime(2015, 5, 15)));
            zooInventory.Animals.Add(new Elephant("Джамбо", new DateTime(2010, 12, 1)));
            zooInventory.Animals.Add(new Bear("Батон", new DateTime(2011, 10, 1)));
            zooInventory.Animals.Add(new Penguin("Басік", new DateTime(2018, 4, 2)));
            zooInventory.Animals.Add(new Giraffe("Жужик", new DateTime(2005, 8, 9)));

            zooInventory.Workers.Add(new ZooKeeper("Іван Бойко", "Зоопарковий працівник"));
            zooInventory.Workers.Add(new ZooKeeper("Оксана Кравченко", "Прибиральниця"));
            zooInventory.Workers.Add(new ZooKeeper("Марина Костюк", "Ветеринар"));
            zooInventory.Workers.Add(new ZooKeeper("Павло Шевченко", "Охоронець"));

            zooInventory.Feeds.Add(new Food("М'ясо", 500));
            zooInventory.Feeds.Add(new Food("Риба", 600));
            zooInventory.Feeds.Add(new Food("Корм сухий", 1500));
            zooInventory.Feeds.Add(new Food("Овочі", 5000));


            zooInventory.Enclosures.Add(new Enclosure("Саванна", 1500));
            zooInventory.Enclosures.Add(new Enclosure("Клітка", 500));

            

            zooInventory.Animals[0].AddFeedingTime("09:00 - М'ясо");
            zooInventory.Animals[0].DisplayFeedingSchedule();

            zooInventory.Animals[1].AddFeedingTime("10:35 - Овочі");
            zooInventory.Animals[1].DisplayFeedingSchedule();

            zooInventory.Enclosures[0].AddMaintenanceRecord("Прибирання та дезинфекція 2024-05-06");
            zooInventory.Enclosures[0].DisplayMaintenanceRecords();

            zooInventory.CheckFeedStock("М'ясо");
            Console.WriteLine($"Всього працівників: {zooInventory.CountWorkers()}");

            zooInventory.DisplayInventory();
        }
    }

}
