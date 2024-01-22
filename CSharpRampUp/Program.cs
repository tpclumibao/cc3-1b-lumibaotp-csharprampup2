//By Lumibao, Tom Peycee C.
//BSCS 1B - CC3
//CSharpRampUp.cs

using System;

namespace CSharpRampUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wight in Pounds (lbs): ");
            double Pounds = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Weight Converted to Kilograms (kg): " + Pounds / 2.205);
            Console.WriteLine("=========================================================");
            Console.Write("Length in Miles (mi): ");
            double Miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Length Converted to Kilometers: " + Miles * 1.609);
            Console.WriteLine("=========================================================");
            Console.Write("Temperature in Fahrenheit (f): ");
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Temperature Converted to  Celsius: " + (Fahrenheit - 32) * 5 / 9);
            Console.WriteLine("=========================================================");
            double TotalAge = 0;
        for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Age of Students " + i + ": ");
                double Age = Convert.ToDouble(Console.ReadLine());
                TotalAge += Age;
            }
            double AverageAge = TotalAge / 10;
            Console.WriteLine("The average age of the Students is: " + AverageAge);
            Console.WriteLine("=========================================================");
            String Mc = ("~Joker~");
            String Band = ("~Phantom Thieves of Hearts~");
            String Ability = ("~Steel Their Hearts~");
            String Skill = ("~Persona~");
            String Enemy = ("~Masayoshi Shido~");

            string Story = (Mc +@" and his comrades. All having lost their place to belong in a broken world, these
teenagers gradually realize that they are living in a dangerous society resembling a prison full of slavery,
and injustice. They can't live with the system and can't live without it, and simply existing means they are at risk of being condemned to a life of slavery.
In order to seek freedom, liberation and justice, they live dual lives as rebellious "+Band+@".
Using a mysterious smartphone app, they undertake fantastical adventures by using otherworldly powers to enter the
hearts of people in order to re-shape and transform them. they do it by giving a calling card to "+Ability+@".The Phantom
Thieves realize that society forces people to wear masks to protect their inner vulnerabilities, and by confronting their
inner selves and by literally ripping off their protective mask do the heroes awaken their inner power, the "+Skill+@". using
it to help those in need. Ultimately, the group of Phantom Thieves seeks "+Enemy+@" the master mind of all to change his heart 
and change their day-to-day world to match their perception, end slavery and see through the masks modern society wares.");
            Console.WriteLine(Story);
            Console.WriteLine("=========================================================");
            Console.Write("Input:");
            int Pira = Convert.ToInt32(Console.ReadLine());
            if (Pira <= 0) {
                Console.WriteLine("Invalid Input!");
                }
            else {
                for (int i = 1; i <= Pira; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j + " ");
                    }
                    Console.WriteLine();

                }
            }

            Console.WriteLine("=========================================================");
            Console.Write("Input:");
            int Add = Convert.ToInt32(Console.ReadLine());
            if (Add <= 0) {
                Console.WriteLine("Invalid Input!");
                }
            else
            {
                int sum = 0;

                Console.Write("Formula: ");
                for (int a = 1; a <= Add; a++)
                {
                    sum += a;
                    Console.Write(a);
                    if (a < Add)
                    {
                        Console.Write(" + ");
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Output: " + sum);
            }

            Console.WriteLine("=========================================================");
            Console.Write("Input:");
            int Invert = Convert.ToInt32(Console.ReadLine());
            if (Invert <= 0)
            {
                Console.WriteLine("Invalid Input!");
            }
            else
            {
                for (int b = Invert; b >= 1; b--)
                {
                    for (int g = 1; g <= b; g++)
                    {
                        Console.Write(g + " ");
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
