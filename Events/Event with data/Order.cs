using System;

namespace Events.Event_with_data
{
    internal class Order
    {
        public event EventHandler<OrderData> OnCreated;

        /// <summary>
        /// Observe que "new OrderData { CPF = cpf, Phone = phone }" é a forma de passar dados para o evento.
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="phone"></param>
        public void Create(string cpf, string phone)
        {
            Console.WriteLine("Order created");

            OnCreated?.Invoke(this, new OrderData { CPF = cpf, Phone = phone });
        }
    }
}
