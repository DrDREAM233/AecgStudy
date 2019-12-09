#define release

using System;

namespace AecgStudy
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

#if release
            Console.ReadKey();
#endif
        }
    }
}
