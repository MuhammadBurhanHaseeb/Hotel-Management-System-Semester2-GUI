using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using BHB_HotelMangementSystem.BL;
namespace BHB_HotelMangementSystem.DL
{
    class discountDL
    {
        private static List<discount> discountList = new List<discount>();

        internal static List<discount> DiscountList { get => discountList; set => discountList = value; }
        public static void addIntoList(discount dis)
        {
            DiscountList.Add(dis);
        }
        public static void addIntoFile (discount dis , string path )
        {
              StreamWriter f = new StreamWriter(path,true);
              f.WriteLine(dis.Did1 + "," + dis.Tdiscount1 + "," + dis.Sdiscount1 + "," + dis.DiscountRate);
              f.Flush();
              f.Close();
        }
        public static bool  isExist(discount dis)
        {
            int count = 0;
            foreach(discount di in DiscountList)
            {
                if(dis.Did1 == di.Did1)
                {
                    return true;
                }
                else
                {
                    count++;
                }
            }
            if(count == DiscountList.Count)
            {
                return false;
            }
            return false;
        }
        public static bool loadDiscount(string path )
        {
            if (File.Exists(path))
            {
                StreamReader f = new StreamReader(path);
                string record;
                while ((record = f.ReadLine()) != null)
                {
                    string[] rec = record.Split(',');
                    int id = int.Parse(rec[0]);
                    string type = rec[1];
                    string status = rec[2];
                    string rate = rec[3];
                    discount r = new discount(id, type, status, rate);
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
