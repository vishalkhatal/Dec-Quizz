using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz_9
{
    class Program
    {
        static string name;
        private static string _subject;
        public static string subject
        {
            get { return _subject; }
            set { _subject = value; }

        }
        static Program()
        {
            Console.WriteLine("Static con");
            name = "static member";
        }
        public static void display()
        {
            Console.WriteLine("Static method" + name);
        }

        static void Main(string[] args)
        {
            Program.subject = "Csharp";
            Console.WriteLine("subject" + Program.subject);
            Program.display();
        }
    }
}
