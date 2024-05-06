using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bear : Animal
    {
        public Bear(string name, DateTime dateOfBirth) : base(name, "Bear", dateOfBirth) { }
    }
}
