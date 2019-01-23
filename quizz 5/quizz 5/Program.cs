using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz_5
{
    class Program
    {
        // Find the result of compare operation
        static void Main(string[] args)
        {
            string a = "VISHAL";
            string b = "vishal";
            Console.Write(string.Compare(a, b, true));

        }
    }
}
