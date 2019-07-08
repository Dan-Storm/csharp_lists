using System;
using System.Collections.Generic;


namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> planetList = new List<string>() { "Mercury", "Mars" };
            // planetList.Add("Jupiter");
            // planetList.Add("Saturn");
            // List<string> lastPlanets = new List<string>() { "Neptune", "Uranus", "Pluto" };
            // planetList.AddRange(lastPlanets);
            // planetList.Insert(1, "Venus");
            // planetList.Insert(3, "Earth");
            // planetList.ForEach(taco => Console.WriteLine(taco));
            // List<string> rockyPlanets = planetList.GetRange(2, 2);
            // rockyPlanets.ForEach(taco => Console.WriteLine($"rocky planets {taco}"));
            // planetList.Remove("Pluto");
            // planetList.ForEach(taco => Console.WriteLine(taco));

            Random random = new Random();
            List<int> numbers = new List<int> {
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            random.Next(6),
            };
            for (int i=0; i<numbers.Count; i++) {
   // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
            if(numbers.Contains(i)){
                Console.WriteLine($"numbers list contains {i}");
            }
            else{
                Console.WriteLine($"numbers list does not contain {i}");

            }
}
        }
    }
}
