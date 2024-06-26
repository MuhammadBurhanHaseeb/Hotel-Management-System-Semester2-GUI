using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BHB_HotelMangementSystem.BL;
namespace BHB_HotelMangementSystem.DL
{
    class MuserDL
    {
        private static List<Muser> userList = new List<Muser>();

        internal static List<Muser> UserList { get => userList; set => userList = value; }

        public static void addIntoList( Muser user)
        {
            UserList.Add(user);
        }
        public static bool isExist(Muser usr)
        {
            int count = 0; 
            foreach(Muser u in UserList)
            {
                if(usr.UserName == u.UserName)
                {
                    return true;
                }
                else
                {
                    count++;
                }
            }
            if(count == UserList.Count)
            {
                return false;
            }
            return false;
        }
        public static void addIntoFile(Muser a, string path)
        {

            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(a.UserName + "," + a.UserPassword + "," + a.UserRole);
            f.Flush();
            f.Close();
        }
        public static bool loadUser(string path)
        {
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    string[] rec = record.Split(',');
                    string name = rec[0];
                    string password = rec[1];
                    string role = rec[2];
                    Muser r = new Muser(name, password, role);
                   addIntoList(r);
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool search(string name)
        {
            int count = 0;
            foreach(Muser s in UserList)
            {
                if(s.UserName == name)
                {
                    return true;
                }
                else
                {
                    count++;
                }
            }
            if (count == UserList.Count)
            {
                return false;
            }
            return false;
        }
        public static void addDataIntoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (Muser user in MuserDL.UserList)
            {
                f.WriteLine(user.UserName + "," + user.UserPassword + "," + user.UserRole);

            }
            f.Flush();
            f.Close();


        }
        public static void dellUser(Muser user)
        {
            for (int index = 0; index < UserList.Count; index++)
            {
                if (user.UserName == UserList[index].UserName && user.UserPassword == UserList[index].UserPassword)
                {
                    UserList.RemoveAt(index);
                }
            }
        }
        public static void editUserFromList(Muser previous, Muser update)
        {
            foreach (Muser s in UserList)
            {
                if (previous.UserName == s.UserName && previous.UserPassword == s.UserPassword && previous.UserRole == s.UserRole)
                {
                    s.UserName = update.UserName;
                    s.UserPassword = update.UserPassword;
                    s.UserRole = update.UserRole;
                }
            }
        }
    }
}
