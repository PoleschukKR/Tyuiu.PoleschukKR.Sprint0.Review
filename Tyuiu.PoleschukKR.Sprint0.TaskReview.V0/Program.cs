using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.PoleschukKR.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            int z = 1;

            int result = DataService.Calc(x, y, z);

            Console.WriteLine("Выражение:" + "(" + x + "+" + y + "+" + z + ")" + "=" + result );
            Console.ReadKey();

        }
    }
}
