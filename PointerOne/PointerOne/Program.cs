using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerOne
{
    class Program
    {
        static void Main(string[] args)
        {
            testClass tc = new testClass();
            tc.someMethod();

            Console.ReadLine();
        }
    }

    //basic pointers 
    /* --put it into a method
     * -- struct
     */

    class testClass
    {
        //method --> pointer
        public unsafe void someMethod()
        {
            int a = 5;
            int b = 8;

            //create a pointer that points to a and b
            int* pointerA = &a;
            int* pointerB = &b;

            Console.WriteLine(*pointerA);
            Console.WriteLine((int)pointerA);
            Console.WriteLine(*pointerB);
            Console.WriteLine((int)pointerB);
        }
    }
}
