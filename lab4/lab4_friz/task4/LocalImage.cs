using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    public class LocalImage : Image
    {
        public override void Load(string href)
        {
            Console.WriteLine("Завантажуємо з файлової системи: " + href);
            try
            {
                byte[] fileData = File.ReadAllBytes(href);
                Console.WriteLine("Файл завантажено успішно. Розмір файлу: " + fileData.Length + " байтів.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка при завантаженні файлу: " + ex.Message);
            }
        }
    }
}
