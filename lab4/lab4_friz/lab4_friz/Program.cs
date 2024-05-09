using System;
using task1;
using t2;
using task3;
using task4;
using task5;
using System.Text;

namespace lab4_friz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //*******1********
            IHandler technicalSupportHandler = new TechnicalSupportHandler();
            IHandler billingHandler = new BillingHandler();
            IHandler salesHandler = new SalesHandler();
            IHandler generalInquiriesHandler = new GeneralInquiriesHandler();

            technicalSupportHandler.SetNext(billingHandler)
                                    .SetNext(salesHandler)
                                    .SetNext(generalInquiriesHandler);

            bool continueMenu = true;

            while (continueMenu)
            {
                Console.WriteLine("\nЛаскаво просимо до Системи Підтримки Клієнтів.");
                Console.WriteLine("Будь ласка, опишіть вашу проблему або запит\n(billing, payment, general, inquiry, sales, purchase, technical, software):");

                string request = Console.ReadLine();

                technicalSupportHandler.HandleRequest(request);

                Console.WriteLine("\nЧи хочете ви зробити ще один запит? (y/n)");
                string choice = Console.ReadLine();

                if (choice.ToLower() != "y")
                {
                    continueMenu = false;
                }
            }

            Console.WriteLine("\nДякуємо за використання Системи Підтримки Клієнтів");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");



            //*******2********
            Runway[] runways = { new Runway(), new Runway() };
            Aircraft[] aircrafts = { new Aircraft("Boeing 828"), new Aircraft("Airbus A320") };
            CommandCentre commandCentre = new CommandCentre(runways, aircrafts);
            commandCentre.LandAircraft(aircrafts[0], runways[0]);
            commandCentre.TakeOffAircraft(aircrafts[0], runways[0]);
            commandCentre.TakeOffAircraft(aircrafts[1], runways[1]);




            //*******3********
            var div = new LightElementNode("div", "block", false);
            div.AddClass("container");
            div.AddEventListener("click", () => Console.WriteLine("Div clicked!"));
            var text = new LightTextNode("Click me!");
            div.AddChild(text);
            Console.WriteLine(div.InnerHTML()); 
            div.TriggerEvent("click");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");





            //*******4********
            string localPath = "C:/Users/PC/Desktop/політех/Software_design/lab4/picture.jpg";
            string networkPath = "https://t4.ftcdn.net/jpg/02/56/10/07/360_F_256100731_qNLp6MQ3FjYtA3Freu9epjhsAj2cwU9c.jpg";

            Image localImage = ImageFactory.CreateImage(localPath);
            localImage.Load(localPath);

            Image networkImage = ImageFactory.CreateImage(networkPath);
            networkImage.Load(networkPath);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");



            //*******5********
            TextDocument doc = new TextDocument("Початковий текст");
            TextEditor editor = new TextEditor(doc);

            editor.Edit("Друга зміна");
            editor.Edit("Перша зміна");
            Console.WriteLine("Поточний текст: " + editor.GetText()); 

            editor.Undo();
            Console.WriteLine("Після відміни: " + editor.GetText()); 

            editor.Undo();
            Console.WriteLine("Після другої відміни: " + editor.GetText());

        }
    }

}

