using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            lst.Add(7);
            lst.Add(8);
            lst.Add(9);
            lst.Add(10);

            var res = from c in lst where c > 4 & c < 8 select c;

            ThreadStart thrd = new ThreadStart(func1);
            Thread thr = new Thread(thrd);
            thr.Start();

            Console.ReadLine();
        }

        public static void func1()
        {
            Console.WriteLine("Thread start");
        }
    }
}
