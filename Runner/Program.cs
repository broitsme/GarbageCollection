using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarbageCollectionNameSpace;
namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
          for(int i = 0; i< 100000; i++)
            {
                int[] arr = new int[10000];
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine();
            for (int i = 0; i < 100000; i++)
            {
                int[] arr = new int[10000];
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(); for (int i = 0; i < 100000; i++)
            {
                int[] arr = new int[10000];
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine(); for (int i = 0; i < 100000; i++)
            {
                int[] arr = new int[10000];
            }
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
