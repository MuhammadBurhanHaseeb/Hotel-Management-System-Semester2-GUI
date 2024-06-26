using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BHB_HotelMangementSystem.BL;
namespace BHB_HotelMangementSystem.DL
{
    class MessageDL
    {
        private static List<Message> messageList = new List<Message>();

        internal static List<Message> MessageList { get => messageList; set => messageList = value; }

        public static void addIntoList(Message m)
        {
            MessageList.Add(m);
        }

        public static void addIntoFile(Message s , String path)
        {
            StreamWriter f = new StreamWriter(path , true);
            f.WriteLine(s.Messag+","+s.Index);
            f.Flush();
            f.Close();
        }

        public static bool loadMessage(string path)
        {
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    string[] rec = record.Split(',');
                    string message = rec[0];
                    int index = int.Parse(rec[1]);
                    Message r = new Message(message , index);
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
