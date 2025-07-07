using System;

namespace Delegates
{
    internal class Example3
    {
        public delegate void Greeting(string message);
        public static void SayHi(string name) => Console.WriteLine($"Hi {name}"); // Esse método deve ter a mesma assinatura do Greeting
        public static void SayBye(string name) => Console.WriteLine($"Bye {name}"); // Esse método deve ter a mesma assinatura do Greeting
        public static void Say(string name) => Console.WriteLine($"Say {name}"); // Esse método deve ter a mesma assinatura do Greeting
    }
}
