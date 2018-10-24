using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz11
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            int val = 66;
            int[] a = new int[5];
            try
            {
                Console.WriteLine("Enter number");
                index = Convert.ToInt32(Console.ReadLine());
                a[index] = val;
            }
            catch
            {
                Console.WriteLine("Exception occured");
            }

        }
    }
}
