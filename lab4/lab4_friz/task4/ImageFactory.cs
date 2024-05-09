using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public static class ImageFactory
    {
        public static Image CreateImage(string href)
        {
            if (href.StartsWith("http") || href.StartsWith("https"))
            {
                return new NetworkImage();
            }
            else
            {
                return new LocalImage();
            }
        }
    }
}
