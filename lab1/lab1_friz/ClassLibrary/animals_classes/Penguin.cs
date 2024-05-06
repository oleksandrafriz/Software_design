using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Penguin : Animal
    {
        public Penguin(string name, DateTime dateOfBirth) : base(name, "Penguin", dateOfBirth) { }
    }
}
