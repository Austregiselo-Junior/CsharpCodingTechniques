using AbstraticClassXInterface.Interface;
using System;

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
        }
    }
}
