using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz1
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            Sample.first();
            obj.Second(10);
        }
    }
    class Sample
    {
        public static void first()
        {
            Console.WriteLine("the first method");

        }
        public void Second()
        {
            first();
            Console.WriteLine("the second method");

        }
        public void Second(int i)
        {
            Console.WriteLine(i);
            Second();

        }
    }
}
