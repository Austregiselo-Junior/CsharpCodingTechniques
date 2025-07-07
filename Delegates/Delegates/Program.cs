using System;
using System.Collections.Generic;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// ----------------------- Exemplo 1 ------------------------//");

            //Para chamar o SayHi() por meio do Greeting você cria uma instância do Greeting com o SayHi()
            //como argumento e chama o Invoke() da instância do delegado assim:

            Example1.Greeting greeting = new Example1.Greeting(Example1.SayHi);
            greeting.Invoke("John"); // Com o Invoke() você chama o método SayHi passando o argumento "John"

            Example1.Greeting greetinhWithoutInvoke = Example1.SayHi; // Você também pode atribuir o método diretamente ao delegado
            greetinhWithoutInvoke("John"); // E chamar o método diretamente, sem o Invoke()


            Console.WriteLine("// ----------------------- Exemplo 2 ------------------------//");

            var numbers = new List<int> { 1, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = Example2.Filter(numbers, Example2.IsEvent); // Filtra os números pares

            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            var oddNumbers = Example2.Filter(numbers, Example2.IsOdd); // Filtra os números ímpares
            Console.WriteLine("Odd numbers:");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
            // OBS: Observe que o Filter pode receber o IsEvent() e o Is Odd() porque recebe um delegado como parâmetro onde esses métodos têm a mesma assinatura que o delegado.
            Console.ReadLine();
        }
    }
}
