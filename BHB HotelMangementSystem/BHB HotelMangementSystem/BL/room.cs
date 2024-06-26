using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHB_HotelMangementSystem.BL
{
    class room
    {
        protected string status;
        protected int rid;
        protected int roomNO;
        protected string troom;
        protected string sroom;
        protected int roomRate;

        public string Status { get => status; set => status = value; }
        public int Rid { get => rid; set => rid = value; }
        public int RoomNO { get => roomNO; set => roomNO = value; }
        public string Troom { get => troom; set => troom = value; }
        public string Sroom { get => sroom; set => sroom = value; }
        public int RoomRate { get => roomRate; set => roomRate = value; }

      
    }
}
