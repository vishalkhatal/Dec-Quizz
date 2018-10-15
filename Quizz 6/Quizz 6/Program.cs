using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_6
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i = 3;
            int j = 2;

            func1(ref i);
            func2(out j);
            Console.WriteLine(i + " and " + j);
        }
        static void func1(ref int num)
        {
            num = num + num;
        }
        static void func2(out int num)
        {
            num = num * num;
        }
    }
}
