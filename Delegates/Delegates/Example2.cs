using System.Collections.Generic;

namespace Delegates
{
    public delegate bool Callback(int number);
    internal class Example2
    {
        public static IEnumerable<int> Filter(List<int> numbers, Callback callback) // Se o retorno for true, o número será incluído na lista filtrada
        {
            foreach (var item in numbers)
            {
                if (callback(item))
                {
                    yield return item;
                }
            }
        }

        public static bool IsOdd(int number) => number % 2 != 0 ? true : false; // retorna true se um número for ímpar, (Tem que ter o mesmo parâmetro que o delegado Callback).
        public static bool IsEvent(int number) => number % 2 == 0; // retorna true se um número for par, (Tem que ter o mesmo parâmetro que o delegado Callback)

    }
}
