using System;
using System.Collections.Generic;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------  Definindo uma expressão lambda que retorna o quadrado de um número inteiro ---------------------");
            GetSquare();

            GetSquarebyLambdaInstruction();
            Console.ReadLine();

            Console.WriteLine("---------------  Convertendo uma expressão lambda em uma instância de delegate ---------------------");
            ConvertsLambdaExpressionIntoDelegatedInstance();
            Console.ReadLine();

            Console.WriteLine("---------------  Capturando variáveis externas ---------------------");

            Console.ReadLine();
        }

        /// <summary>
        /// Expressão lambda que retorna o quadrado de um número inteiro.
        /// </summary>
        private static void GetSquare()
        {
            var square = (int i) => i * i;
            Console.WriteLine(square(10));
        }

        /// <summary>
        /// Instrução lambda que especifica o tipo de retorno da expressão OBS: Precisa ter um return.
        /// </summary>
        private static void GetSquarebyLambdaInstruction()
        {
            var square = int (int x) => { return x * x; };
            Console.WriteLine(square(20));
        }

        /// <summary>
        /// "Func<int, int> square" -> delegate genérico que representa um método que recebe e retorna int, ou seja square é um delegate que aponta para a função.
        /// "x => x * x" -> lambda expression
        /// </summary>
        private static void ConvertsLambdaExpressionIntoDelegatedInstance()
        {
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(50)); // chama o delegate.
        }

        /// <summary>
        /// "var funcList = new List<Func<int, int>>()" -> criando uma lista de funções
        /// "funcList.Add((int x) => x * factor);" -> Adicionando a uma expressão lambda a lista de funções onde o vada iteração o fator é alterado.
        /// "item(10)" -> para cara ítem da lista de função é recebido o parâmetro 10, com o factor já campurado (Captura de variável externa)
        /// </summary>
        private static void CapturingExternalVariables()
        {
            var funcList = new List<Func<int, int>>();

            for (int i = 1; i <= 3; i++)
            {
                int factor = i;
                funcList.Add((int x) => x * factor);
            }

            foreach (var item in funcList)
            {
                Console.WriteLine(item(10));
            }
            // Captura de variável externa: As variáveis referenciadas por uma expressão lambda são conhecidas como variáveis capturadas. Quando uma expressão lambda possui variáveis capturadas, ela é chamada de fechamento 
        }
    }
}
