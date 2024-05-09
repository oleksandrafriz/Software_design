using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class SmartTextChecker : SmartTextReader
    {
        private SmartTextReader _reader;

        public SmartTextChecker(SmartTextReader reader)
        {
            _reader = reader;
        }

        public new char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"Opening file {filePath}");
            char[][] result = _reader.ReadFile(filePath);
            Console.WriteLine($"Successfully read file {filePath}");
            Console.WriteLine($"Total lines: {result.Length}");
            Console.WriteLine($"Total characters: {GetTotalCharacters(result)}");
            Console.WriteLine($"Closing file {filePath}");
            return result;
        }

        private int GetTotalCharacters(char[][] lines)
        {
            int total = 0;
            foreach (var line in lines)
            {
                total += line.Length;
            }
            return total;
        }
    }
}
