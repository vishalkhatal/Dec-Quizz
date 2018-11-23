using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world !";
            Console.WriteLine(string.Compare(str, "Hello wrold?").GetType());
            Console.ReadKey();
        }
    }
}
