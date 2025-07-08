using System;

namespace Events.Event_with_data
{
    internal class SMS
    {
        /// <summary>
        /// Aqui você pode usar os dados do evento para enviar um SMS.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SendSMS(object sender, OrderData e)
        {
            Console.WriteLine($"Send message by SMS: {e.CPF} and {e.Phone}");
        }
    }
}
