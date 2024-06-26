using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHB_HotelMangementSystem.BL
{
    class CheckIn
    {
        protected string status;
        protected int gid;
        protected string name;
        protected string addres;
        protected string contact;
        protected string email;
        protected string gender;
        protected int adult;
        protected int children;
        protected string inDate;
        protected string outDate;
        protected int days;
        protected int roomNo;
        protected string troom;
        protected string sroom;
        protected int roomRate;
        protected string sdiscount;
        protected string tdiscount;
        protected int discountRate;
        protected double balance;

        public string Status { get => status; set => status = value; }
        public int Gid { get => gid; set => gid = value; }
        public string Name { get => name; set => name = value; }
        public string Addres { get => addres; set => addres = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Adult { get => adult; set => adult = value; }
        public int Children { get => children; set => children = value; }
        public string InDate { get => inDate; set => inDate = value; }
        public string OutDate { get => outDate; set => outDate = value; }
        public int Days { get => days; set => days = value; }
        public int RoomNo { get => roomNo; set => roomNo = value; }
        public string Troom { get => troom; set => troom = value; }
        public string Sroom { get => sroom; set => sroom = value; }
        public int RoomRate { get => roomRate; set => roomRate = value; }
        public string Sdiscount { get => sdiscount; set => sdiscount = value; }
        public string Tdiscount { get => tdiscount; set => tdiscount = value; }
        public int DiscountRate { get => discountRate; set => discountRate = value; }
        public double Balance { get => balance; set => balance = value; }
    }
}
