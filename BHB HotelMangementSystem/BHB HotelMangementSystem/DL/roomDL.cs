using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BHB_HotelMangementSystem.BL;
using System.IO;
namespace BHB_HotelMangementSystem.DL
{
    class roomDL
    {
        private static List<room> roomList = new List<room>();

        internal static List<room> RoomList { get => roomList; set => roomList = value; }

        public static void addIntoList(room roo)
        {
            RoomList.Add(roo);
        }

        public static void addIntoFile(room rom , string path )
        {
            StreamWriter f = new StreamWriter(path,true);
                f.WriteLine(rom.Status +","+rom.Rid + "," + rom.RoomNO + "," + rom.Troom + "," + rom.Sroom + "," + rom.RoomRate);
            f.Flush();
            f.Close();
        }
        public static bool loadRoom(string path)
        {
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    string[] rec = record.Split(',');
                    string statu = rec[0];
                    int id = int.Parse(rec[1]);
                    int roomNO =int.Parse( rec[2]);
                    string type = rec[3];
                    string status = rec[4];
                    int rate = int.Parse(rec[5]);
                    availableRoom r = new availableRoom(statu,id,roomNO, type, status, rate);
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
    }
}
