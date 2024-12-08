using Microsoft.VisualBasic;
using System;

namespace PropertyStop.Dtos.MessagesDtos
{
    public class ResultInboxMessageDto
    {
        public int MessageID { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public string Subject { get; set; }
        public string Detail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
