using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyWorks cls = null;
            //bool test = null== null; //DateTime.Today > cls?.DateTimeProp;
            ////DateTime dt = cls?.DateTimeProp;

            //Console.WriteLine("C "+cls?.BoolProp);
            //Console.WriteLine(cls?.IntPro);
            //Console.WriteLine(cls?.DateTimeProp);
            Console.WriteLine("Hello World!!");

            Console.ReadLine();
        }
    }

    class AdventureWorks
    {
        public int AdvInt { get; set; }

        public string AdvStr { get; set; }

        public AdvTest ListStr { get; set; }
    }

    class AdvTest
    {
        public string MyTest { get; set; }
    }

    class MyWorks
    {
        public int IntPro { get; set; }
        public bool BoolProp { get; set; }
        public DateTime DateTimeProp { get; set; }
    }
}
