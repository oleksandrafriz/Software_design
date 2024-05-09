﻿using System;
using System.IO;

namespace task4
{
    public class SmartTextReader
    {
        public char[][] ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            char[][] result = new char[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].ToCharArray();
            }
            return result;
        }
    }
}
