using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace task4
{
    public class NetworkImage : Image
    {
        public override void Load(string href)
        {
            Console.WriteLine("Завантажуємо з мережі: " + href);
            using (WebClient client = new WebClient())
            {
                try
                {
                    byte[] imageBytes = client.DownloadData(href);
                    Console.WriteLine("Зображення завантажено успішно. Розмір файлу: " + imageBytes.Length + " байтів.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка при завантаженні зображення: " + ex.Message);
                }
            }
        }
    }
}
