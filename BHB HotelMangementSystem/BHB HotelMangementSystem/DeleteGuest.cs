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
    public partial class DeleteGuest : Form
    {
        private string path = "guest.txt";
        public DeleteGuest()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeleteGuest_Load(object sender, EventArgs e)
        {
            gv.DataSource = guestDL.GuestList1;
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guest gust = (guest)gv.CurrentRow.DataBoundItem;
            if(gv.Columns[e.ColumnIndex].HeaderText == "DELETE")
           // if (gv.Columns["Delete"].Index == e.ColumnIndex)
            {
                guestDL.dellGuest(gust);
                guestDL.addIntoFile(path);
                dataBind();
            }
        }
        private void dataBind()
        {
            gv.DataSource = null;
            gv.DataSource = guestDL.GuestList1;
            gv.Refresh();
        }

    
    }
}
