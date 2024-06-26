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
    public partial class ViewAvailableRoomForm : Form
    {
        public ViewAvailableRoomForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewAvailableRoomForm_Load(object sender, EventArgs e)
        {
            List<room> ro = new List<room>();
            foreach (room s in roomDL.RoomList)
            {
                if (s.Status == "AR")
                {
                    ro.Add(s);
                }
            }
            gv.DataSource = ro;
        }
    }
}
