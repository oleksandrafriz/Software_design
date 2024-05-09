using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task4
{
    public class SmartTextReaderLocker : SmartTextReader
    {
        private SmartTextReader _reader;
        private Regex _regex;

        public SmartTextReaderLocker(SmartTextReader reader, string pattern)
        {
            _reader = reader;
            _regex = new Regex(pattern);
        }

        public new char[][] ReadFile(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return _reader.ReadFile(filePath);
        }
    }
}
