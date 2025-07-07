using System;

namespace Delegates
{
    internal class Example1
    {
        public delegate void Greeting(string message);

        public static void SayHi(string name) // Esse método deve ter a mesma assinatura do Greeting
        {
            Console.WriteLine($"Hi {name}");
        }
    }
}
