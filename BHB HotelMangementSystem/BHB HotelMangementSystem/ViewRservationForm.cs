using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BHB_HotelMangementSystem.DL;
using BHB_HotelMangementSystem.BL;
namespace BHB_HotelMangementSystem
{
    public partial class ViewRservationForm : Form
    {
        public ViewRservationForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewRservationForm_Load(object sender, EventArgs e)
        {
            List<CheckIn> ro = new List<CheckIn>(); 
            foreach(CheckIn s in CheckInDL.FormList)
            {
                if(s.Status == "R")
                {
                    ro.Add(s);
                }
            }
            gv.DataSource = ro;
        }
    }
}
