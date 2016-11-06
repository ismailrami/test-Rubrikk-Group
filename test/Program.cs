using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> items = new List<double>();
            double number = 0;
            Console.WriteLine("insert number");
            while (double.TryParse(Console.ReadLine(), out number))
            {
                
                items.Add(number);
            }
            RandomNumber rand = new RandomNumber();
            rand.GetRandomNumber(items);
            Console.Write(rand.GetRandomNumber(items));
            Console.ReadKey();
        }
    }
}
