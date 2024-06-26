using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BHB_HotelMangementSystem.BL;
using BHB_HotelMangementSystem.DL;
using System.Windows.Forms;

namespace BHB_HotelMangementSystem
{
    public partial class ViewCheckInForm : Form
    {
        public ViewCheckInForm()
        {
            InitializeComponent();
        }

       
        private void ViewCheckInForm_Load(object sender, EventArgs e)
        {
            List<CheckIn> ro = new List<CheckIn>();
            foreach (CheckIn s in CheckInDL.FormList)
            {
                if (s.Status == "CI")
                {
                    ro.Add(s);
                }
            }
            gv.DataSource = ro;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
