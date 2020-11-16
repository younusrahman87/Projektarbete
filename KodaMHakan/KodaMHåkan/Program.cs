using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;
using System.Linq;
using System.ComponentModel.Design;

namespace KodaMHåkan
{
    class Program
    {
        static void Main(string[] args)
        {
            



            bool skapaBilar = true;
            string answer;
            int index = 0;

            Car[] cars = new Car[100]; 

            while (skapaBilar) 
            {
               
                cars[index] = AddCar(); 
                do
                {
                    Console.WriteLine("Är du färdig med att skapa upp bilar? J/N?");
                    answer = Console.ReadLine();
                    if (answer.ToLower() == "j")
                    {
                        skapaBilar = false;
                    }
                    else if (answer.ToLower() == "n")
                    {
                        break;
                    }
                    else
                        Console.WriteLine();
                }
                while (answer.ToLower() != "j");
                
                index++;
            }

            for (int i = 0; i < index; i++)
            {
                if (cars[i].Color == "GUL")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (cars[i].Color == "GRÖN")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (cars[i].Color == "BLÅ")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (cars[i].Color == "RÖD")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine($"RegistreringsNummer: {cars[i].LicenseNumber}");
                Console.WriteLine($"Bilens Färg: {cars[i].Color}\n------------------------------------------------");
            }
        }
   
        public static Car AddCar() 
        {
            Car car = new Car();
            Console.WriteLine("Var vänlig lägg till en bil! Skriv regnummer!");
            string regNummer = Console.ReadLine();
            car.LicenseNumber = regNummer;
            Console.WriteLine("Och var vänlig ange färg!");
            string bilFarg = Console.ReadLine(); 
            car.Color = bilFarg;
            
            return car;
        }
    
    }
}
