using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    class Program
    {
        delegate int Average(int x, int y, int z);
        static void Main(string[] args)
        {
            Average average = delegate (int x, int y, int z)
            {
                return (x + y + z) / 3;
            };

            Console.WriteLine(average(1,33,44));   //26

        }
    }

}
