using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class FileLogger : Logger
    {
        private FileWriter writer;

        public FileLogger(string path)
        {
            writer = new FileWriter(path);
        }

        public new void Log(string message)
        {
            writer.WriteLine("Log: " + message);
        }

        public new void Error(string message)
        {
            writer.WriteLine("ERROR: " + message);
        }

        public new void Warn(string message)
        {
            writer.WriteLine("WARNING: " + message);
        }
    }
}
