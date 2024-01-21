using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
internal class Program
{
    private static void Main(string[] args)
    {   //writes to console
        Console.WriteLine("welcome to thy calculations device");
        Console.WriteLine("pick your mode 1 for hypotenuse 2 for calculator");
        int Mode = Convert.ToInt32(Console.ReadLine());
        switch (Mode)
        {
            case 1:
            Console.WriteLine("enter side a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter side b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Double c = Math.Sqrt((a*a) + (b*b));
            Console.WriteLine("your answer is " + c);
            Console.WriteLine("bye bye");
            Console.WriteLine("press a key to exit");
            Console.ReadKey(true);
            break;
            //waits for an input before exiting doesnt display to console
            case 2:
            Console.WriteLine("pick your first number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            //double as we need decimals and we need to convert read line to double as it is a string
            Console.WriteLine("pick your second number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("your operators are -, +, /, *, ^, sqrt1, sqrt2 (these all must be written as exact)");
            Console.WriteLine("pick an operator");
            string operator1 = Console.ReadLine()!;
            //we need it as a string as we dont need to add any more vars
            if (Mode != 1 || Mode != 2)
            {
                Environment.Exit(0);
            }
            // an attempt at fixing a bug.
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
            default: 
                Console.WriteLine(operator1 + " is not a valid operator");
                Thread.Sleep(2000);
                break;
            
        }
            Console.WriteLine("bye bye");
            Console.WriteLine("press a key to exit");
            Console.ReadKey(true);
            //waits for an input before exiting doesnt display to console
            break;
        }}}