﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    public class FileWriter
    {
        private string filePath;

        public FileWriter(string path)
        {
            filePath = path;
        }

        public void Write(string text)
        {
            File.AppendAllText(filePath, text);
        }

        public void WriteLine(string text)
        {
            Write(text + Environment.NewLine);
        }
    }
}
