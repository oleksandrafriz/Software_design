using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Enclosure
    {
        public string Type { get; set; }
        public double Size { get; set; }
        public List<string> MaintenanceRecords { get; private set; }

        public Enclosure(string type, double size)
        {
            Type = type;
            Size = size;
            MaintenanceRecords = new List<string>();
        }

        public void AddMaintenanceRecord(string record)
        {
            MaintenanceRecords.Add(record);
        }

        public void DisplayMaintenanceRecords()
        {
            Console.WriteLine($"Записи про технічне обслуговування корпусу {Type}:");
            foreach (var record in MaintenanceRecords)
            {
                Console.WriteLine(record);
            }
        }
    }

}
