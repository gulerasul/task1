using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string months = Console.ReadLine();

            switch (months)
            {
                case "yanvar":
                case "mart":
                case "may":
                case "iyul":
                case "avqust":
                case "oktyabr":
                case "dekabr":
                    Console.WriteLine(31);
                    break;
                case "aprel":
                case "iyun":
                case "sentyabr":
                case "noyabr":
                    Console.WriteLine(30);
                    break;
                case "fevral":
                    Console.WriteLine(28);
                    break;
               
                default:
                    Console.WriteLine( "bele gun yoxdur ");
                    break;
            }


        }
    }
}