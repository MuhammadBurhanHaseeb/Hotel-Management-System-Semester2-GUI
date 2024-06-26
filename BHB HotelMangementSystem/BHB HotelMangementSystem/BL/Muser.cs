using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BHB_HotelMangementSystem.DL;
namespace BHB_HotelMangementSystem.BL
{
    public class Muser
    {
        private string userName;
        private string userPassword;
        private string userRole;

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string UserRole { get => userRole; set => userRole = value; }

        public Muser(string userName, string userPassword, string userRole)
        {
           this.UserName = userName;
           this.userPassword = userPassword;
           this.userRole = userRole;
        }
        public Muser(string userName, string userPassword)
        {
            this.UserName = userName;
            this.userPassword = userPassword;
        }

        public static bool isValid(Muser user)
        {
            int count = 0;
            foreach(Muser s in MuserDL.UserList)
            {
                if (s.UserName == user.UserName && user.UserPassword == s.UserPassword)
                {
                    return true;
                }
                else
                {
                    count++;
                }
            }
            if (count == MuserDL.UserList.Count)
            {
                return false;
            }
            return false;
        }
        public static Muser isAdmin(Muser user)
        {
            foreach (Muser s in MuserDL.UserList)
            {
                if (s.UserName == user.UserName && user.UserPassword == s.UserPassword)
                {
                    return s;
                }
               
            }
            return null;
           
        }
    }
}
