using AbstraticClassXInterface.AbstraticClass;
using AbstraticClassXInterface.Interface;
using System;
using System.Collections.Generic;

namespace AbstraticClassXInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// ------------------- Interface ------------------------//");

            //Neste exemplo, definimos a ILogger como interface que possui um único método Log. O Log método recebe uma string que representa a mensagem a ser registrada.
            //As classes ConsoleLoggere FileLogger implementam a interface e fornecem suas próprias implementações do Logmétodo.
            //Se o argumento for "file", criamos um FileLoggerobjeto.Caso contrário, criamos um ConsoleLoggerobjeto.
            //Independentemente se FileLoggerou ConsoleLogger instância foi criada, chamamos o Logmétodo para registrar algumas mensagens
            //Como as classes FileLoggere ConsoleLoggerimplementam a mesma interface, podemos alternar facilmente entre elas em tempo de execução.

            ILogger logger;
            string message = Console.ReadLine();


            if (message == "file")
            {
                logger = new FileLogger("log.txt");
                logger.Log("Logging to file.");
            }
            else
            {
                logger = new ConsoleLogger();
                logger.Log("Logging to console.");
            }
            Console.ReadLine();


            Console.WriteLine("// ------------------- Classe Abstrata ------------------------//");

            //Neste exemplo, a Shape classe é uma classe abstrata que define dois métodos abstratos GetAreae GetPerimeter. Qualquer
            //classe herdada da classe Shape precisa implementar esses métodos.
            //A Shape classe também possui um método concreto Display() que exibe a área e o perímetro de uma forma.
            //Todas as subclasses da Shapeclasse compartilharão o mesmo Displaymétodo.
            //As classes Rectangle e Circle estendem a classe Shape.Ambas as classes compartilham a mesma implementação de Displaymétodo,
            //mas cada uma fornece sua própria implementação de métodos GetAreae GetPerimeter.

            List<Shape> shapes = new List<Shape>
            {
                new Rectangle(5, 10),
                new Circle(7)
            };

            foreach (var item in shapes)
            {
                item.Display();
            }
            Console.ReadLine();
        }
    }
}
