using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzz_16
{
   //To prove we cant have virtual method in sealed class
    sealed class Demo
    {
        public virtual void Foo()
        {
            Console.WriteLine("In Demo");
        }
    }
}
