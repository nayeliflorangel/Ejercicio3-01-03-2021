using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            Console.WriteLine("Escriba un mes (ejemplo => enero = 1): ");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1: Console.WriteLine($"Número de días: {numbers[month-1]}.");
                    break;
                case 2: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 3: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 4: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 5: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 6: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 7: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 8: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 9: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 10: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 11: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                case 12: Console.WriteLine($"Número de días: {numbers[month - 1]}.");
                    break;
                default: Console.WriteLine($"Ha digitado un número incorrecto.");
                    break;
            }
        }
    }
}
