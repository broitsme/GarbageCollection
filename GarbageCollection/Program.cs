using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace GarbageCollectionNameSpace
{
    public class GarbageCollection
    {
        public class Destructor
        {
            StreamReader stream = File.OpenText(@"C:\Users\Rahul_Bhatia\Downloads\desktop.ini");
            ~Destructor() { Console.WriteLine("Destructor is Exicuted and streamReader is Disposed"); }
        }
        public class UsingExample
        {
             public void Method()
            {
                using (StreamReader stream = File.OpenText(@"C:\Users\Rahul_Bhatia\Downloads\desktop.ini"))
                {
                    Console.WriteLine("using block is exicuted and streamReader is Disposed");
                }
            }
        }

        public class ForDispose : IDisposable
        {
            bool disposed = false;
            StreamReader stream = File.OpenText(@"C:\Users\Rahul_Bhatia\Downloads\desktop.ini"); //unmanaged code
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            protected virtual void Dispose(bool disposing)
            {
                if (disposed)
                    return;

                if (disposing)
                {
                    stream.Dispose();
                    Console.WriteLine("Disposable is exicuted and stream is Disposed!");
                }

                disposed = true;
            }
        }
        public static void Main(String[] args)
        {
            ForDispose fd = new ForDispose();
            fd.Dispose();
            Destructor des = new Destructor();
            UsingExample ue = new UsingExample();
            ue.Method();
            Console.ReadLine();
        }
    }
}
