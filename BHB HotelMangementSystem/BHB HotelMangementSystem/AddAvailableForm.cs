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
    public partial class AddAvailableForm : Form
    {
        private string path = "room.txt";
        public AddAvailableForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbRoomId.Text.Length > 0 && tbRoomNo.Text.Length > 0 && tbRoomType.Text.Length > 0 && tbRoomStatus.Text.Length > 0 && tbRoomRate.Text.Length > 0)
                {
                    room r = new availableRoom("AR", int.Parse(tbRoomId.Text), int.Parse(tbRoomNo.Text), tbRoomType.Text, tbRoomStatus.Text, int.Parse(tbRoomRate.Text));
                    roomDL.addIntoList(r);
                    roomDL.addIntoFile(r, path);
                    lblError.Visible = true;
                    lblError.Text = "suucessfully added!!";
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "first fullfill all the data";
                }
            }
            catch (Exception exp) 
            {
                lblError.Visible = true;
                lblError.Text = "enter Valid data";
            }
        }
    }
}
