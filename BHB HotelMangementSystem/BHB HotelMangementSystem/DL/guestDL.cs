using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BHB_HotelMangementSystem.BL;
namespace BHB_HotelMangementSystem.DL
{
    class guestDL
    {
        private static List<guest> guestList = new List<guest>();

        internal static List<guest> GuestList1 { get => guestList; set => guestList = value; }

        public static void addIntoFile(guest gust, string path)
        {
            StreamWriter f = new StreamWriter(path, true);
            f.WriteLine(gust.Gid1 + "," + gust.Name + "," + gust.Addres + "," + gust.Contact + "," + gust.Email + "," + gust.Gender);
            f.Flush();
            f.Close();
        }
        public static void addIntoFile(string path)
        {
            StreamWriter f = new StreamWriter(path);
            foreach (guest gust in guestList)
            {
                f.WriteLine(gust.Gid1 + "," + gust.Name + "," + gust.Addres + "," + gust.Contact + "," + gust.Email + "," + gust.Gender);

            }
            f.Flush();
            f.Close();
        }

        public static void addIntoList(guest gust)
        {
            guestList.Add(gust);
        }

        public static bool loadGuest(string path)
        {
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    string[] rec = record.Split(',');
                    int id = int.Parse(rec[0]);
                    string name = rec[1];
                    string address = rec[2];
                    string contact = rec[3];
                    string email = rec[4];
                    string gender = rec[5];
                    guest r = new guest(id, name, address, contact, email, gender);
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
        public static void dellGuest(guest gust)
        {
            for (int idx = 0; idx < guestList.Count; idx++)
            {
                if (gust.Name == guestList[idx].Name)
                {
                    guestList.RemoveAt(idx);
                }
            }
        }
        public static bool isExist(guest gust )
            {
            int count = 0;
            foreach(guest g in guestList)
            {
                if(g.Name == gust.Name)
                {
                    return true;
                }
                else
                {
                    count++;
                }
            }
            if(count==guestList.Count)
            {
                return false;
            }
            return false;
            }
    }
}
