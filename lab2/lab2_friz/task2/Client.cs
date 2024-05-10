using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Client
    {
        private DeviceFactory _factory;

        public Client(DeviceFactory factory)
        {
            _factory = factory;
        }

        public void Run()
        {
            Laptop laptop = _factory.CreateLaptop();
            Netbook netbook = _factory.CreateNetbook();
            EBook eBook = _factory.CreateEBook();
            Smartphone smartphone = _factory.CreateSmartphone();

            Console.WriteLine(laptop.GetDetails());
            Console.WriteLine(netbook.GetDetails());
            Console.WriteLine(eBook.GetDetails());
            Console.WriteLine(smartphone.GetDetails());
        }
    }
}
