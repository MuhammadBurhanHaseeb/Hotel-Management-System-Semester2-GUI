using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BHB_HotelMangementSystem.BL;
using BHB_HotelMangementSystem.DL;
namespace BHB_HotelMangementSystem
{
    public partial class CheckOutFormInOrder : Form
    {
        public CheckOutFormInOrder()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckOutFormInOrder_Load(object sender, EventArgs e)
        {
            List<CheckIn> ro = new List<CheckIn>();
            foreach (CheckIn s in CheckInDL.FormList)
            {
                if (s.Status == "CO")
                {
                    ro.Add(s);
                }
            }
            ro = ro.OrderByDescending(o => o.Balance).ToList();
            gv.DataSource = ro;
        }
    }
}
