//Autor:        Monika Malolepsza
//Klasse:       IA119
//Datei:        Run.cs
//Datum:        28.09.2020
//Beschreibung:
//Aenderungen:  28.09.2020 Setup

using System;
namespace FractionCalcOOP
{
    partial class main
    {
        static void Run()
        {
            Splashinfo();


            // objects initialized and nullified
            

            Fraction result = null;
            Fraction fraction1 = null;
            Fraction fraction2 = null;

            bool isActive = true;
            char operation;
            do
            {

                // objects instantated
                
                result = new Fraction();
                fraction1 = new Fraction();
                fraction2 = new Fraction();

                Console.Clear();
                Console.WriteLine("Please provide values for for:");
                Console.WriteLine();
                Console.WriteLine("the numerator 1:");

                try
                {
                    fraction1.Numerator = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("the denominator 1:");
                    fraction1.Denominator = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("the numerator 2:");
                    fraction2.Numerator = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("the denominator 2:");
                    fraction2.Denominator = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Operation");
                    Console.WriteLine();
                    Console.WriteLine("Possible operations:");
                    Console.WriteLine("Addition '+' ");
                    Console.WriteLine("Subtraction '-' ");
                    Console.WriteLine("Multiplication '*' ");
                    Console.WriteLine("Division '/' ");
                    Console.WriteLine();
                    Console.WriteLine();
                    operation = Convert.ToChar(Console.ReadLine());

                    switch (operation)
                    {
                        case '+':
                            result.Assign(fraction1.Addition(fraction2));
                            break;
                        case '-':
                            result.Assign(fraction1.Substraction(fraction2));
                            break;
                        case '*':
                            result.Assign(fraction1.Multiplication(fraction2));
                            break;
                        case '/':
                            result.Assign(fraction1.Division(fraction2));
                            break;
                        default:
                            throw new ArgumentException("Invalid operator!");
                    }


                    result.Reduce();

                    Console.WriteLine($@"Result: {result.Numerator} / {result.Denominator}");

                }

                // basic exception handling

                catch (Exception e)
                {
                    if (e is ArgumentException || e is DivideByZeroException || e is FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine(e.Message);

                    }
                    else
                    {
                        throw e;
                    }
                }
 
                Console.ReadKey(true);

                bool exitMenu = true;
                do
                {
                    Console.WriteLine("Would you like to perform another operation? (y/n)");
                    Console.WriteLine();
                    ConsoleKeyInfo exit = Console.ReadKey();

                    if (exit.KeyChar == 'n')
                    {
                        isActive = false;
                        exitMenu = false;
                    }
                    else if (exit.KeyChar == 'y')
                    {
                        isActive = true;
                        exitMenu = false;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Write 'y' to continue, 'n' to close exit");
                        exitMenu = true;

                    }
                } while (exitMenu);


            } while (isActive);


        }
    }
}
