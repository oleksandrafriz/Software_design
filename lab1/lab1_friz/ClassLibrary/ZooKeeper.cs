using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ZooKeeper
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public ZooKeeper(string name, string jobTitle)
        {
            Name = name;
            JobTitle = jobTitle;
        }
    }

}
