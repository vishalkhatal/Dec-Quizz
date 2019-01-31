using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_10
{
    class Program
    {
        //Find the output
        static void Main(string[] args)
        {
            byte num = 100;
            dynamic val = num;
            Console.WriteLine(val.GetType());
            val += 100;
            Console.WriteLine(val.GetType());

        }
    }
}
