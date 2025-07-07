using System;

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
        }
    }
}
