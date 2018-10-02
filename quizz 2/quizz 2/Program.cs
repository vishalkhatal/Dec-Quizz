using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1 z = new Sample1();
            z.Add();
        }
    }
    class Sample
    {
        public int _index = 5;

        public Sample()
        {
            _index = 2;
        }
    }
    class Sample1:Sample
    {
       
        public void Add()
        {
            _index += 1;
            Console.WriteLine(_index);
        }
    }
}
