using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class DocumentMemento
    {
        public string Content { get; }

        public DocumentMemento(string content)
        {
            Content = content;
        }
    }
}
