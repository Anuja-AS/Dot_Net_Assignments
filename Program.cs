using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int a = 10;
            //    int b = 0;
            //    int x = a / b;
            //    Console.WriteLine("Rest of the code");
            try
            {
                Class1 obj = new Class1();
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = x/0;
                Console.WriteLine(obj.P1);

            }
            catch
            {
                Console.WriteLine("Exception occurred");
            }
            Console.ReadLine();
        }
        public class Class1
        {
            private int p1;
            public int P1
            {
                get { return p1; }
                set
                {
                    p1 = value;
                }
            }
        }
    }
 }
