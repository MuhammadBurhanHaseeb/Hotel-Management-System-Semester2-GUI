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
    public partial class MessageFormcs : Form
    {
        private string path = "Message.txt";
        public MessageFormcs()
        {
            InitializeComponent();
        }

       
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //int index = 0;
            try
            {
                int count = 0;
                for (int x = 0; x < MuserDL.UserList.Count; x++)
                {
                    if (tbName.Text == MuserDL.UserList[x].UserName)
                    {
                        BL.Message s = new BL.Message(tbMessage.Text, x);
                        MessageDL.addIntoList(s);
                        MessageDL.addIntoFile(s, path);

                        lblError.Visible = true;
                        lblError.Text = "send successfully";
                        break;
                    }
                    else
                    {
                        count++;
                    }
                }
                if (count == MuserDL.UserList.Count)
                {
                    lblError.Visible = true;
                    lblError.Text = "User Not Find";
                }
            }
            catch (Exception exp )
            {
                lblError.Visible = true;
                lblError.Text = "enter the valis data";
            }
        }

        private void MessageFormcs_Load(object sender, EventArgs e)
        {

        }
    }
}
