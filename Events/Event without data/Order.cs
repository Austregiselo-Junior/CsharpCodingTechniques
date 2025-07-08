using System;

namespace Events.Event_without_data
{
    internal class Order
    {
        /// <summary>
        /// Evento/Delegado
        /// </summary>
        public event EventHandler OnCreated;

        /// <summary>
        /// This contêm a referência do próprio objeto e EventArgs.Empty, fornece um valor a ser usado com um evento que não possui dados de evento.
        /// </summary>
        public void Create()
        {
            Console.WriteLine("Order created!");

            if (OnCreated != null)
            {
                OnCreated(this, EventArgs.Empty);
            }
        }
    }
}
