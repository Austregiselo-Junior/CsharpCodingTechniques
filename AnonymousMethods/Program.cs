using System;

namespace AnonymousMethods
{
    internal class Program
    {
        delegate int Transform(int x);
        static int j = 10;

        /// <summary>
        /// Mesma assinatura do delegate Transforme
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int Square(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            // Método anônimo é um método sem nome que é atribuído a um delegado, pode ser de forma explicita setando o método.

            Console.WriteLine("---------- Forma explícita ---------");

            Transform t1 = Square;
            Console.WriteLine(t1(10));
            Console.ReadLine();

            Console.WriteLine("---------- Forma implícita ---------");

            Transform t2 = delegate (int x)
            {
                return x * j;
            }; // O método anônimo não tem nome, mas é atribuído a um delegate Transform.

            Console.WriteLine(t2(50));
            Console.ReadLine();
        }
    }
}
