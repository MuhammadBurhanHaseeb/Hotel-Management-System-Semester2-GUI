using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHB_HotelMangementSystem.BL
{
    class discount
    {

        private int Did;
        private string Tdiscount;
        private string Sdiscount;
        private string discountRate;
        public discount(int Did, string Tdiscount, string Sdiscount, string discountRate)
        {
            this.Did = Did;
            this.Tdiscount = Tdiscount;
            this.Sdiscount = Sdiscount;
            this.discountRate = discountRate;
        }
        public int Did1 { get => Did; set => Did = value; }
        public string Tdiscount1 { get => Tdiscount; set => Tdiscount = value; }
        public string Sdiscount1 { get => Sdiscount; set => Sdiscount = value; }
        public string DiscountRate { get => discountRate; set => discountRate = value; }


    }
}
