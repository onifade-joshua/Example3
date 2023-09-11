using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isDone = true;
            var count = 0;
            while (isDone)
            {

                if(count < 10)
                {
                    Console.WriteLine("Hey you're counting this time!");
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
                    ++count;
                }else
                {
                    isDone = false;
                }
            }
            Console.WriteLine("End of count try again!");
            Console.WriteLine("Enter any keyword to continue...");
            Console.ReadKey();
        }
    }
}
