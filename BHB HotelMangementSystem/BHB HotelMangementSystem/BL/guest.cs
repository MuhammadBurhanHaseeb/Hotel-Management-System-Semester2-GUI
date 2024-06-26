using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHB_HotelMangementSystem.BL
{
    class guest
    {
        private int Gid;
        private string name;
        private string addres;
        private string contact;
        private string email;
        private string gender;
       

        public int Gid1 { get => Gid; set => Gid = value; }
        public string Name { get => name; set => name = value; }
        public string Addres { get => addres; set => addres = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }

        public guest(int Gid, string name, string addres, string contact, string email, string gender)
        {
            this.Gid = Gid;
            this.name = name;
            this.addres = addres;
            this.contact = contact;
            this.email = email;
            this.gender = gender;
        }
    }
}
