using System;

namespace Events.Event_with_data
{
    internal class Email
    {
        /// <summary>
        /// Aqui você pode usar os dados do evento para enviar um email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SendEmail(object sender, OrderData e)
        {
            Console.WriteLine($"Send message by email: {e.CPF} and {e.Phone}");
        }
    }
}
