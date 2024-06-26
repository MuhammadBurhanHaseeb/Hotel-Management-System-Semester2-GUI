using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHB_HotelMangementSystem.BL
{
     class Message
    {
        private string message;
        private int index;

        public string Messag { get => message; set => message = value; }
        public int Index { get => index; set => index = value; }

        public Message(string msg , int index)
        {
            message = msg;
            this.index = index;
        }
    }
}
