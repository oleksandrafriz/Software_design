using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<string> FeedingSchedule { get; private set; }

        public Animal(string name, string species, DateTime dateOfBirth)
        {
            Name = name;
            Species = species;
            DateOfBirth = dateOfBirth;
            FeedingSchedule = new List<string>();
        }


        public void AddFeedingTime(string time)
        {
            FeedingSchedule.Add(time);
        }

        public void DisplayFeedingSchedule()
        {
            Console.WriteLine($"Графік годування тавринки {Name}:");
            foreach (var time in FeedingSchedule)
            {
                Console.WriteLine(time);
            }
        }
    }

}
