using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    class Program
    {
        delegate double Operation(double x, double y);
        static void Main(string[] args)
        {
            Operation Add = (x, y) => x + y;
            Operation Sub = (x, y) => x - y;
            Operation Mul = (x, y) => x * y;
            Operation Div = (x, y) => y != 0 ? x / y : 0;

            Console.WriteLine(Add(10, 20));       // 30
            Console.WriteLine(Sub(40, 20));       // 20
            Console.WriteLine(Mul(40, 20));       // 800
            Console.WriteLine(Div(40, 0));        // 0
            Console.Read();

        }
    }

}
