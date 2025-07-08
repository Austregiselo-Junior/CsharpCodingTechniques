using Events.Event_without_data;
using System;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------- Evento sem passagem de informaçâo entre publicador (Order) e assitante (Email e Sms). ----------");

            Order orderWithoutData = new Order();

            orderWithoutData.OnCreated -= Email.SendEmail; // Dessaninatura (Bind) do email ao Order
            orderWithoutData.OnCreated += Email.SendEmail; // Assinatura (Bind) do email ao Order

            orderWithoutData.OnCreated -= SMS.SendSMS; // Dessaninatura (Bind) do SMS ao Order
            orderWithoutData.OnCreated += SMS.SendSMS; // Assinatura (Bind) do SMS ao Order

            orderWithoutData.Create(); // Cria o pedido, dispara o evento OnCreated

            Console.ReadLine();
        }
    }
}
