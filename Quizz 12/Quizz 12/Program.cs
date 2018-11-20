using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_12
{
    class Program
    {
        static int Main(string[] args)
        {
            int y = 3;
            write(out y);
            return 0;
        }
        private static void write(out int y)
        {
            Console.WriteLine(y);
            y = 1;
        }
    }

}
