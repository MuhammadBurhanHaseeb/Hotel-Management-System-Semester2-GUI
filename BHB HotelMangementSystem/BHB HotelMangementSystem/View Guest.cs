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
    public partial class View_Guest : Form
    {
        public View_Guest()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Guest_Load(object sender, EventArgs e)
        {
            gv.DataSource = guestDL.GuestList1;
        }
    }
}
