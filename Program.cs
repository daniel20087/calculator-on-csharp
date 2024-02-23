﻿using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {   //writes to console
        Console.WriteLine("pick your mode 1 for hypotenuse 2 for calculator");
        int Mode = Convert.ToInt32(Console.ReadLine());
        switch (Mode)
        {
            
            case 1:
            double sideA, sideB;
            while (true)
                {
                    Console.WriteLine("enter side A ");
                    if (double.TryParse(Console.ReadLine(), out sideA))
                    {
                        break; // Exit the loop if valid input is provided
                    }
                    else
                    {
                        Console.WriteLine("not a valid side");
                    }
                }
            while (true)
                {
                    Console.Write("enter side B ");
                    if (double.TryParse(Console.ReadLine(), out sideB))
                    {
                        break; // Exit the loop if valid input is provided
                    }
                    else
                    {
                        Console.WriteLine("not a valid side.");
                    }
                }

            double sideC = Math.Sqrt((sideA * sideA) + (sideB * sideB));
            Console.WriteLine("your answer is " + sideC);
            Console.WriteLine("bye bye");
            Console.WriteLine("press a key to exit");
            Console.ReadKey(true);
            break;
            //waits for an input before exiting doesnt display to console
            case 2:
            double num1, num2;
            while (true)
                {
                    Console.Write("Enter the first number: ");
                    if (double.TryParse(Console.ReadLine(), out num1))
                    {
                        break; // Exit the loop if valid input is provided
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            while (true)
                {
                    Console.Write("Enter the second number: ");
                    if (double.TryParse(Console.ReadLine(), out num2))
                    {
                        break; // Exit the loop if valid input is provided
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
                Console.WriteLine("your operators are -, +, /, *, ^, sqrt1, sqrt2, random");
            Console.WriteLine("pick an operator");
            string operator1 = Console.ReadLine()!;
            //we need it as a string as we dont need to add any more doubles/ints
            switch (operator1)
            {
            case "+":
            //had to convert to double for some unknown reason or else it just added 2 strings together, c# wizards can figure it out
            Console.WriteLine("your value is " + Convert.ToDouble(num1 + num2));
            break;
            case "-":
            Console.WriteLine("your value is " + (num1 - num2));
            break;
            case "*":
            Console.WriteLine("your value is " + num1 * num2);
            break;
            case "/":
            Console.WriteLine("your value is " + num1 / num2);
            break;
            case "^":
            Console.WriteLine("your value is " + Math.Pow(num1, num2));
            break;
            case "sqrt1":
            Console.WriteLine("your value is " + Math.Sqrt(num1));
            break;
            case "sqrt2":
            Console.WriteLine("your value is " + Math.Sqrt(num2));
            break;
            //yeah i dont know what im doing anymore with these 2 sqrt :sob:
            case "random":
            Random randomint = new Random();
            int Convertednum1 = Convert.ToInt32(Math.Round(num1));
            int Convertednum2 = Convert.ToInt32(Math.Round(num2));
            //had to learn typecasting out of nowwhere to do this :\ but it works so happy
            int randomnum = randomint.Next(Convertednum1, Convertednum2 + 1);
            Console.WriteLine("your value is " + randomnum);
            break;
            default: 
                Console.WriteLine(operator1 + " is not a valid operator");
                Thread.Sleep(2000);
                break;
            }
            Console.WriteLine("bye bye");
            Thread.Sleep(2000);
            Console.WriteLine("press a key to exit");
            Console.ReadKey(true);
            //waits for an input before exiting doesnt display to console
            break;
        }}}