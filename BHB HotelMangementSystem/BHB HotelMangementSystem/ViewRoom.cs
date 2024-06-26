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
    public partial class ViewRoom : Form
    {
        public ViewRoom()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewRoom_Load(object sender, EventArgs e)
        {
            List<room> ro  = new List<room>(); 
            foreach(room s in roomDL.RoomList)
            {
                if(s.Status == "R")
                {
                    ro.Add(s);
                }
            }
            gv.DataSource = ro;
                   
           // gv.DataSource = roomDL.RoomList;
        }
    }
}
