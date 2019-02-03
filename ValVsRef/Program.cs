using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValVsRef
{
    class Program
    {

        class MethodDemo
        {

            public void PassByValue(int a)
            {
                a = 100;
                Console.WriteLine(" a inside method = {0}", a);
            }

            public void PassByReference(int[] b)
            {
                b[0] = 500;
                Console.WriteLine("b[0] inside method = {0}", b[0]);
            }
        }
        static void Main(string[] args)
        {
            int a = 50;
            int[] b = { 100, 200, 300 };
            MethodDemo obj = new MethodDemo();

            Console.WriteLine("a before = {0}", a);
            obj.PassByValue(a);
            Console.WriteLine("a after = {0}", a);

            Console.WriteLine("\n\n");
            Console.WriteLine("b[0] before = {0}", b[0]);
            obj.PassByReference(b);
            Console.WriteLine("b[0] after = {0}", b[0]);

            Console.ReadLine();
        }
    }
}
