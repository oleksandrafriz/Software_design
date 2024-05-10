using System;
using System.Collections.Generic;
using ClassLibrary1;
using ClassLibrary3;
using System.Text;
using task2;
using task4;
using task5;

namespace lab2_friz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ISubscriptionCreator website = new WebSite();
            ISubscriptionCreator mobileApp = new MobileApp();
            ISubscriptionCreator managerCall = new ManagerCall();

            var subscription1 = website.CreateSubscription("domestic");
            subscription1.DisplayInfo();

            var subscription2 = mobileApp.CreateSubscription("educational");
            subscription2.DisplayInfo();

            var subscription3 = managerCall.CreateSubscription("premium");
            subscription3.DisplayInfo();


            Client iProneClient = new Client(new IProneFactory());
            Client kiaomiClient = new Client(new KiaomiFactory());
            Client balaxyClient = new Client(new BalaxyFactory());

            Console.WriteLine("-------------");
            Console.WriteLine("IProne девайси:");
            iProneClient.Run();
            Console.WriteLine();

            Console.WriteLine("Kiaomi девайси:");
            kiaomiClient.Run();
            Console.WriteLine();

            Console.WriteLine("Balaxy девайси:");
            balaxyClient.Run();
            Console.WriteLine();


            Console.WriteLine("-------------");
            Authenticator authenticator1 = Authenticator.Instance;
            Authenticator authenticator2 = Authenticator.Instance;
            Console.WriteLine(authenticator1 == authenticator2); 
            authenticator1.Authenticate();
            authenticator2.Authenticate();

            Console.WriteLine("-------------");
            Virus virus1 = new Virus(0.5, 10, "Virus1", "Type1");
            Virus virus2 = new Virus(0.7, 15, "Virus2", "Type2");
            Virus virus3 = new Virus(0.6, 5, "Virus3", "Type1");
            virus1.Children.Add(virus3);
            Virus virus4 = new Virus(0.8, 7, "Virus4", "Type2");
            virus2.Children.Add(virus4);
            Virus virus5 = new Virus(0.4, 2, "Virus5", "Type1");
            virus3.Children.Add(virus5);
            Virus virus6 = new Virus(0.9, 3, "Virus6", "Type2");
            virus4.Children.Add(virus6);

            Virus clonedVirus1 = virus1.Clone();
            Virus clonedVirus2 = virus2.Clone();

            Console.WriteLine("Оригінальні віруси:");
            PrintVirus(virus1);
            PrintVirus(virus2);

            Console.WriteLine("\nКлоновані віруси:");
            PrintVirus(clonedVirus1);
            PrintVirus(clonedVirus2);

            Console.WriteLine("-------------");
            Director director = new Director();
            HeroBuilder heroBuilder = new HeroBuilder();
            EnemyBuilder enemyBuilder = new EnemyBuilder();

            Character hero = director.BuildHero(heroBuilder);
            Character enemy = director.BuildEnemy(enemyBuilder);

            Console.WriteLine("Герой:");
            Console.WriteLine($"зріст: {hero.Height} cm");
            Console.WriteLine($"Будова тіла: {hero.Build}");
            Console.WriteLine($"Колір волосся: {hero.HairColor}");
            Console.WriteLine($"Колір очей: {hero.EyeColor}");
            Console.WriteLine($"Одяг: {hero.Clothes}");
            Console.WriteLine("Інвертар: " + string.Join(", ", hero.Inventory));

            Console.WriteLine("\nВорог:");
            Console.WriteLine($"зріст: {enemy.Height} cm");
            Console.WriteLine($"Будова тіла: {enemy.Build}");
            Console.WriteLine($"Колір волосся: {enemy.HairColor}");
            Console.WriteLine($"Колір очей: {enemy.EyeColor}");
            Console.WriteLine($"Одяг: {enemy.Clothes}");
            Console.WriteLine("Інвертар: " + string.Join(", ", enemy.Inventory));
        }

        static void PrintVirus(Virus virus)
        {
            Console.WriteLine($"Вірус: {virus.Name}, Вага: {virus.Weight}, Вік: {virus.Age}, Тип: {virus.Type}");
            Console.WriteLine("Діти:");
            foreach (Virus child in virus.Children)
            {
                Console.WriteLine($"  {child.Name}");
            }
            Console.WriteLine();
        }
    }
}
