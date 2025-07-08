using System;

namespace Events.Event_without_data
{
    internal class SMS
    {
        /// <summary>
        /// Os parâmetros do Send devem corresponder ao EventHandler OnCreated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SendSMS(object sender, EventArgs e)
        {
            Console.WriteLine($"Message send by SMS!");
        }
    }
}
