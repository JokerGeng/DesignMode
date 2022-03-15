using System;

namespace ProxyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing the code with a real subject:");
            RealSubject realSubject = new RealSubject();
            realSubject.Request();

            Console.WriteLine();

            Console.WriteLine("Executing the same code with a proxy:");
            SubjectProxy proxy = new SubjectProxy(realSubject);
            proxy.Request();
            Console.Read();
        }
    }
}
