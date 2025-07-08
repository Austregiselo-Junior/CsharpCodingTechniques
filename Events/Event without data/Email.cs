using System;

namespace Events.Event_without_data
{
    internal class Email
    {
        /// <summary>
        /// Os parâmetros do Send devem corresponder ao EventHandler OnCreated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void SendEmail(object sender, EventArgs e)
        {
            Console.WriteLine($"Message send by email!");
        }
    }
}
