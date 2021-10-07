using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var ArrayNumeros1 = new int[] { 10, 20, 30, 40, 50 };
            var ArrayNumeros2 = new int[] { 100, 200, 300, 400, 500 };

            Console.WriteLine(ArrayNumeros1.All(menores => menores <= 10));
            Console.WriteLine(ArrayNumeros2.All(mayores => mayores >= 100));
        }
    }
}
