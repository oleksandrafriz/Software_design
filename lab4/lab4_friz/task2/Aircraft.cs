using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Aircraft
    {
        public string Name { get; set; }
        public bool IsTakingOff { get; set; }

        public Aircraft(string name)
        {
            Name = name;
        }
    }
}
