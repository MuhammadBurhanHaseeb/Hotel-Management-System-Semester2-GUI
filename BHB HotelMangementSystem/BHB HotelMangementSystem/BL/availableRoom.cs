using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHB_HotelMangementSystem.BL
{
    class availableRoom : room
    {
        public availableRoom (string status , int id  , int roomNo  , string Type , string Sroom , int roomRate)
        {
           Status = status;
            Rid = id;
             RoomNO  = roomNo;
            Troom = Type;
            this.Sroom = Sroom;
            RoomRate = roomRate;
        }
    }
}
