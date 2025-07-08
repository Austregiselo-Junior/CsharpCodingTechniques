using System;

namespace Events.Event_with_data
{
    internal class OrderData : EventArgs
    {
        public string CPF { get; set; }
        public string Phone { get; set; }
    }
}
