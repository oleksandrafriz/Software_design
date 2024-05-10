using System;
using System.Collections.Generic;

namespace task5
{
    public class Character
    {
        public float Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
    }
}
