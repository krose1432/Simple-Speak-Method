using System;

namespace SimpleSpeak
{
    class Program
    {
        static string animal;
        static string Speak(string sound)
        {
            
            if (animal == "dog")
            {
                sound = "ruff ruff";
               

            }
            else if (animal == "cow")
            {
                sound = "mooooo";
             
            }
            else if (animal == "pig")
            {
                sound = "oink oink";
           
            }
            else
            {
                sound = "Heeeeyoooooo";
               
            }
            return sound;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a type of animal.");
            animal = Console.ReadLine();
            Speak(animal);
            Console.WriteLine(" You entered " + animal + ". This animal makes a " + Speak(animal) + " noise." );
            
        }
    }
}
