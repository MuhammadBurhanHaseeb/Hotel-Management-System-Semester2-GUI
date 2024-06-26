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
    public partial class EditUser : Form
    {
        private string path = "user.txt"; 
        public EditUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Muser user = (Muser)gv.CurrentRow.DataBoundItem;
            if (gv.Columns[e.ColumnIndex].HeaderText == "EDIT")
                //if (gv.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditUser2 form = new EditUser2(user);
                form.ShowDialog();
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

        private void EditUser_Load(object sender, EventArgs e)
        {
            gv.DataSource = MuserDL.UserList;
        }
    }
}
