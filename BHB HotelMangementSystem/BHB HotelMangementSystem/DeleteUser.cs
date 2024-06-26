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
    public partial class DeleteUser : Form
    {
        private string path = "user.txt";
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            gv.DataSource = MuserDL.UserList;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Muser user = (Muser)gv.CurrentRow.DataBoundItem;
            if (gv.Columns[e.ColumnIndex].HeaderText == "DELETE")
             //   if (gv.Columns["Delete"].Index == e.ColumnIndex )
            {
                MuserDL.dellUser(user);
                MuserDL.addDataIntoFile(path);
                dataBind();
            }
        }
        private void dataBind()
        {
            gv.DataSource = null;
            gv.DataSource = MuserDL.UserList;
            gv.Refresh();
        }
    }
}
