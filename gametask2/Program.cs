using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace gametask2
{
    internal class Program
    {
        //--------------------------------------------------------------------
        //Task1

        //static void Main(string[] args)
        //{
        //    Console.Write("Please enter first integer: ");
        //    int.TryParse(Console.ReadLine(), out int number1);
        //    Console.Write("Please enter second integer: ");
        //    int.TryParse(Console.ReadLine(), out int number2);
        //    Console.WriteLine(Sum(number1, number2));
        //}
        //static int Sum(int number1, int number2)
        //{
        //    return number1 + number2;
        //}

        //--------------------------------------------------------------------
        //Task2

        //static void Main(string[] args)
        //{
        //    Console.Write("Please enter the array size: ");
        //    int size = Convert.ToInt32(Console.ReadLine());
        //    int[] numbers = new int[0];
        //    for (int i = 0; i < size; i++)
        //    {
        //        Array.Resize(ref numbers, numbers.Length + 1);
        //        Console.Write("Please enter the array element: ");
        //        numbers[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine(Sum(numbers)/size);
        //}
        //static int Sum(int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}

        //--------------------------------------------------------------------
        //Task3

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the float number: ");
        //    float.TryParse(Console.ReadLine(), out float number);
        //    Console.WriteLine(convert(number));
        //}
        //static int convert(float number)
        //{
        //    if(number%1>=0.5)
        //    {
        //        return (int)number + 1;
        //    }
        //    else
        //    {
        //        return (int)number;
        //    }
        //}

        //--------------------------------------------------------------------
        //Task4

        //static void Main(string[] args)
        //{
        //    Console.Write("Please enter the number: ");
        //    int.TryParse(Console.ReadLine(), out int number);
        //    Console.WriteLine($"Is number Odd? Answer:{OddOrEven(number)}");
        //}
        //static bool OddOrEven(int number)
        //{
        //    if(number%2==1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //--------------------------------------------------------------------
        //Task5

        //static void Main(string[] args)
        //{
        //    Console.Write("Enter true or false: ");
        //    bool.TryParse(Console.ReadLine(), out bool test);
        //    Console.WriteLine(BoolToString(test));
        //}
        //static string BoolToString(bool test)
        //{
        //    if(test == true)
        //    {
        //        return "Bəli";
        //    }
        //    else
        //    {
        //        return "Xeyr";
        //    }
        //}






        //--------------------------------------------------------------------
        //Task6

        //static void Main(string[] args)
        //{
        //    Console.Write("Please enter your first name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Please enter your last name: ");
        //    string surname = Console.ReadLine();
        //    Console.WriteLine(Fullname(name, surname));
        //}
        //static string Fullname(string name, string surname)
        //{
        //    return $"{name} {surname}";
        //}

        //--------------------------------------------------------------------
        //Task7

        //static void Main(string[] args) 
        //{
        //    Console.Write("Please enter the number: ");
        //    decimal.TryParse(Console.ReadLine(), out decimal number);
        //    Console.WriteLine(Power(number));

        //}

        //static decimal Power(decimal number)
        //{
        //    return number * number;
        //}

        //--------------------------------------------------------------------
        //Task8

        //static void Main(string[] args)
        //{
        //    Console.Write("Please enter the number: ");
        //    int.TryParse(Console.ReadLine(), out int number);
        //    if (Prime(number) == true)
        //    {
        //        Console.WriteLine("Number is prime number");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Number is composite number");
        //    }
        //}

        //static bool Prime (int number)
        //{
        //    bool test = true;
        //    for(int i = 2; i*i < number; i++)
        //    {
        //        if(number%i==0)
        //        {
        //            test = false;
        //            return test;
        //        }
        //    }
        //    return test;
        //}

        //--------------------------------------------------------------------
        //Task9

        //static void Main(string[] args)
        //{
        //    Console.Write("Please enter the number: ");
        //    int.TryParse(Console.ReadLine(), out int number);
        //    Console.Write("Please enter the power: ");
        //    int.TryParse(Console.ReadLine(), out int power);
        //    Console.WriteLine(Power(number, power));
        //}

        //static int Power(int number, int power)
        //{
        //    int result = 1;
        //    for (int i = 0; i < power; i++)
        //    {
        //        result *= number;
        //    }
        //    return result;
        //}

        //--------------------------------------------------------------------

    }
}
