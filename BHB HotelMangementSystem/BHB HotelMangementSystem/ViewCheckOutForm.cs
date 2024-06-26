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
    public partial class ViewCheckOutForm : Form
    {
        public ViewCheckOutForm()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewCheckOutForm_Load(object sender, EventArgs e)
        {
            List<CheckIn> ro = new List<CheckIn>();
            foreach (CheckIn s in CheckInDL.FormList)
            {
                if (s.Status == "CO")
                {
                    ro.Add(s);
                }
            }
            gv.DataSource = ro;
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
