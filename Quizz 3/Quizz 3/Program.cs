using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList aa = new ArrayList();
            aa.Add(1);
            aa.Add('1');
            aa.Add("1");
            foreach(int a in aa)
            {
                Console.WriteLine(a);
            }
        }
    }
}
