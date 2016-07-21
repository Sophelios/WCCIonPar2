using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onPar2
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "yes";
            do
            {
                Console.WriteLine("Give me a number.");
                double numTheFirst = double.Parse(Console.ReadLine());
                Console.WriteLine("ANOTHER!!!");
                double numTheSecond = double.Parse(Console.ReadLine());
                Console.WriteLine("What sort of... operation... should I perform?\n<+, -, *, or />");
                string operate = Console.ReadLine();
                Console.Write("Your operation resulted in ");
                if (operate == "*")
                {
                    Console.WriteLine(numTheFirst * numTheSecond + ".");
                    Console.WriteLine("Shall I perform another operation?");
                    response = Console.ReadLine();
                }
                if (operate == "+")
                {
                    Console.WriteLine(numTheFirst + numTheSecond + ".");
                    Console.WriteLine("Shall I perform another operation?");
                    response = Console.ReadLine();
                }
                if (operate == "-")
                {
                    Console.WriteLine(numTheFirst - numTheSecond + ".");
                    Console.WriteLine("Shall I perform another operation?");
                    response = Console.ReadLine();
                }
                if (operate == "/")
                {
                    Console.WriteLine(numTheFirst / numTheSecond + ".");
                    Console.WriteLine("Shall I perform another operation?");
                    response = Console.ReadLine();
                }
                Console.Clear();
            }
            while (response.ToLower() == "yes");
            if (response.ToLower() == "no")
            {
                Console.WriteLine("GOODBYE.....");
            }
        }
    }
}
