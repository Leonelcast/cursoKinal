using System;
using Util;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstancia();            
            Singleton s2 = Singleton.getInstancia();
            Singleton s3 = Singleton.getInstancia();
            
            Console.WriteLine("Hello World!");
        }
    }
}
