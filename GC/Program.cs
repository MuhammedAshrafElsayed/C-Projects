using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC1

{
    class BigOject
    {
         List<object> obj;
       // object obj;
        public BigOject()
        {
            obj = new List<object>();

            for (int i = 0; i < 1000; i++)
            {
                object o = new object();
                obj.Add(o);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i= 0;i<100000;i++)
            //{

            //}
            object oo = new object();
            
            

            Console.ReadLine();
        }
    }
}
