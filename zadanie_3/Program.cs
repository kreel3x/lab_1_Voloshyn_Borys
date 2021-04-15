using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    class Program
    {
        delegate int RandomIntValue();
        delegate int AvarageIntValue(RandomIntValue[] a);
        static void Main(string[] args)
        {
            Random random = new Random();
            RandomIntValue[] array = new RandomIntValue[2];
            RandomIntValue[] array1 = new RandomIntValue[0];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = delegate
                {
                    return random.Next(100);
                };
            }           
            

            AvarageIntValue averageIntValue = delegate (RandomIntValue[] a)
            {
                if (a.Length > 0)
                {
                    int res = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (a[i] == null)
                        {
                            return 0;
                        }
                        res += a[i]();
                    }
                    return res / (a.Length);
                }
                else return 0;                            
            };

            Console.WriteLine(averageIntValue(array)); 


        }
    }

}
