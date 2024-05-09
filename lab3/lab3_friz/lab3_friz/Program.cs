using System;
using task1;
using System.Text;
using task2;
using task3;
using task4;
using task5;
using task6;
using System.IO;
using System.Collections.Generic;

namespace lab3_friz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Logger consoleLogger = new Logger();
            Console.WriteLine("~~~~~~~~~~~");
            consoleLogger.Log("Це інформаційне повідомлення");
            consoleLogger.Error("Це повідомлення про помилку");
            consoleLogger.Warn("Це попередження");

            FileLogger fileLogger = new FileLogger("logs.txt");
            fileLogger.Log("Це інформаційне повідомлення");
            fileLogger.Error("Це повідомлення про помилку");
            fileLogger.Warn("Це попередження");
            Console.WriteLine("~~~~~~~~~~~");


            Hero warrior = new Warrior { Name = "Aragon" };
            Hero mage = new Mage { Name = "Gandalf" };
            Hero paladin = new Paladin { Name = "Uther" };


            warrior = new WeaponDecorator(warrior, "Довгий Меч");
            warrior = new ArmorDecorator(warrior, "Кольчуга");

            mage = new WeaponDecorator(mage, "Посох Мудрості");
            mage = new ArmorDecorator(mage, "Мантія Магів");

            paladin = new WeaponDecorator(paladin, "Молот Правосуддя");
            paladin = new ArmorDecorator(paladin, "Пластинчаста Броня");

            warrior.Display();
            mage.Display();
            paladin.Display();
            Console.WriteLine("~~~~~~~~~~~");



            IRenderer vectorRenderer = new VectorRenderer();
            IRenderer rasterRenderer = new RasterRenderer();

            Shape circle = new Circle(vectorRenderer);
            Shape square = new Square(rasterRenderer);
            Shape triangle = new Triangle(vectorRenderer);

            circle.Draw();
            square.Draw();
            triangle.Draw();
            Console.WriteLine("~~~~~~~~~~~");



            SmartTextReader reader = new SmartTextReader();
            SmartTextChecker checker = new SmartTextChecker(reader);
            SmartTextReaderLocker locker = new SmartTextReaderLocker(checker, @"\.txt$");

            char[][] result = locker.ReadFile("test.txt");
            Console.WriteLine("~~~~~~~~~~~");




            var ul = new LightElementNode("ul", "block", false);
            ul.AddClass("my-list");

            // Create each li element and add it to the ul
            var li1 = new LightElementNode("li", "block", false);
            li1.AddChild(new LightTextNode("Item 1"));
            ul.AddChild(li1);

            var li2 = new LightElementNode("li", "block", false);
            li2.AddChild(new LightTextNode("Item 2"));
            ul.AddChild(li2);

            // Print each item with a bullet point
            foreach (LightElementNode child in ul.Children)
            {
                Console.WriteLine($"• {((LightTextNode)child.Children[0]).ToHtml()}");
            }
            Console.WriteLine("~~~~~~~~~~~");


            string filePath = @"C:\Users\PC\Desktop\політех\Software_design\lab3\lab3_friz\pg1513.txt";
            var lines = System.IO.File.ReadAllLines(filePath);
            var rootNode = new LightElementNode("div", "block", false);

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Trim();
                LightElementNode node;

                if (i == 0)
                {
                    node = new LightElementNode("h1", "block", false);
                }
                else if (line.Length < 20)
                {
                    node = new LightElementNode("h2", "block", false);
                }
                else if (lines[i].StartsWith(" "))
                {
                    node = new LightElementNode("blockquote", "block", false);
                }
                else
                {
                    node = new LightElementNode("p", "block", false);
                }

                node.AddChild(new LightTextNode(line));
                rootNode.AddChild(node);
            }

            PrintFormattedText(rootNode);
        }

        static void PrintFormattedText(LightElementNode root)
        {
            foreach (LightElementNode node in root.Children)
            {
                string text = node.Children[0].ToHtml(); // Assuming single child that is TextNode
                switch (node.TagName)
                {
                    case "h1":
                        Console.WriteLine("\u001b[1m\u001b[37m\u001b[4m" + text + "\u001b[0m");
                        break;
                    case "h2":
                        Console.WriteLine("\u001b[4m" + text + "\u001b[0m");
                        break;
                    case "blockquote":
                        Console.WriteLine("   \u001b[36m" + text + "\u001b[0m");
                        break;
                    case "p":
                        Console.WriteLine(text);
                        break;
                }
            }
        }






        //string filePath = @"C:\Users\PC\Desktop\політех\Software_design\lab3\lab3_friz\pg1513.txt"; // Замініть на вірний шлях до файлу

        //// Перевірка на існування файлу
        //if (File.Exists(filePath))
        //{
        //    string[] bookText = File.ReadAllLines(filePath);
        //    var htmlContent = BookToHtmlConverter.ConvertTextToHtml(bookText);
        //    Console.WriteLine(htmlContent.OuterHTML);
        //}
        //else
        //{
        //    Console.WriteLine($"File not found: {filePath}");
        //}
        //string[] bookText = File.ReadAllLines("pg1513.txt");
        //var htmlContent = BookToHtmlConverter.ConvertTextToHtml(bookText);
        //Console.WriteLine(htmlContent.OuterHTML);
    }
    }


