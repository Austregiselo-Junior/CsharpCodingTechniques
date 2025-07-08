using System;

namespace AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------  Criando um tipo anônimo -----------------------");

            // O exemplo a baixo mostra a criação de um tipo anônimo atravé do "new".
            var product = new
            {
                Name = "Notebook",
                Price = 2500.00,
                Quantity = 10
            }; // Observe que não há o tipo especificado como seria numa classe.

            Console.WriteLine($"Name: {product.Name}, Price: {product.Price} and Quantity: {product.Quantity}.");

            Console.WriteLine("-------------------------  Criando tipos anônimos com tipos explicito -----------------------");

            ExplicitTypes();

            Console.ReadLine();
        }

        /// <summary>
        /// Esse tipo é explícito, ou seja, é definido através de uma classe "Attributes".
        /// </summary>
        private static void ExplicitTypes()
        {
            var product = new
            {
                Name = "Galaxy f5",
                Price = 6500.00,
                Quantity = 10,
                Atribute = new Attributes
                {
                    Color = "Black",
                    Weight = 200
                }
            };

            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}, Color: {product.Atribute.Color} and " +
                $"Weight: {product.Atribute.Weight}.");
        }
    }
}
