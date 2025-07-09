using System;
using System.Collections.Generic;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// ---------------- Criando dicionarios --------------------//");

            var state = new Dictionary<string, string>();
            state.Add("PB", "Paraiba");
            state.Add("CA", "California");
            state.Add("NY", "New York");


            Dictionary<int, string> order = new Dictionary<int, string>()
            {
                {1, "Amburger com batata"  },
                {2, "Amburger duplo"  },
                {3, "Batata e cerveja"  },
                {4, "Batata e chips"  }
            };

            Console.WriteLine("// ---------------- Recuperando um elemento por sua key --------------------//");

            Console.WriteLine($"Pedido 1: {order[1]}");
            Console.WriteLine($"Pedido 4: {order[4]}");

            Console.ReadLine();

            Console.WriteLine("// ---------------- Para saber se a chave existe podemos usar o ContainKeys() ou TryGetValue() --------------------//");

            if (state.ContainsKey("PB"))
            {
                Console.WriteLine($"Estado PB: {state["PB"]}");
            }
            else
            {
                Console.WriteLine("Estado PB não encontrado");
            }


            if (order.TryGetValue(3, out string _order))
            {
                Console.WriteLine($"Pedido 3: {_order}");
            }
            else Console.WriteLine("Order not exist");

            Console.ReadLine();

            Console.WriteLine("// ---------------- Iterando um dicionário --------------------//");

            foreach (var item in state)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine("// ---------------- Iterando as chaves de um dicionário --------------------//");

            foreach (var item in state.Keys)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine("// ---------------- Iterando os valores de um dicionário --------------------//");

            foreach (var item in order.Values)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine("// ---------------- Usando um dicionário ao em vez de um encadeamento de ifs  --------------------//");

            GetDayofWeek(5);
            Console.ReadLine();
        }

        private static void GetDayofWeek(int d)
        {
            var days = new Dictionary<int, string>()
            {
                {1, "Domingo"},
                {2, "Segunda-feira"},
                {3, "Terça-feira"},
                {4, "Quarta-feira"},
                {5, "Quinta-feira"},
                {6, "Sexta-feira"},
                {7, "Sábado" }
            };

            if (days.TryGetValue(d, out string day))
            {
                Console.WriteLine($"Valid day: {day}.");
            }
            else Console.WriteLine("Day not valid.");
        }
    }
}
