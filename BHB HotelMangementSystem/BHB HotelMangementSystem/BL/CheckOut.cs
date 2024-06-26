using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHB_HotelMangementSystem.BL
{
    class CheckOut:CheckIn
    {
        public CheckOut (string status ,int Gid, string name, string addres, string contact, string email, string gender, int adult, int children, string inDate, string outDate, int days, int roomNo, string Troom, string Sroom, int roomRate, string Sdiscount, string Tdiscount, int discountRate, double balance)
        {
            this.Status = status;
            this.Gid = Gid;
            this.Name = name;
            this.Addres = addres;
            this.Contact = contact;
            this.Email = email;
            this.Gender = gender;
            this.Adult = adult;
            this.Children = children;
            this.InDate = inDate;
            this.OutDate = outDate;
            this.Days = days;
            this.RoomNo = roomNo;
            this.Troom = Troom;
            this.Sroom = Sroom;
            this.RoomRate = roomRate;
            this.Sdiscount = Sdiscount;
            this.Tdiscount = Tdiscount;
            this.DiscountRate = discountRate;
            this.Balance = balance;
        }
    }
}
