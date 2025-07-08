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


            Console.WriteLine("---------- Evento com passagem de informaçâo entre publicador (Order) e assitante (Email e Sms). ----------");

            var orderWithData = new Event_with_data.Order();

            orderWithData.OnCreated -= Event_with_data.Email.SendEmail; // Dessaninatura (Bind) do email ao Order
            orderWithData.OnCreated += Event_with_data.Email.SendEmail; // Assinatura (Bind) do email ao Order

            orderWithData.OnCreated -= Event_with_data.SMS.SendSMS; // Dessaninatura (Bind) do SMS ao Order
            orderWithData.OnCreated += Event_with_data.SMS.SendSMS; // Assinatura (Bind) do SMS ao Order

            orderWithData.Create("096-874-123-87", "(83) 99890-1257"); // Cria o pedido, dispara o evento OnCreated

            Console.ReadLine();
        }
    }
}
