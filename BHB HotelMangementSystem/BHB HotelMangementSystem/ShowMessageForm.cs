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
    public partial class ShowMessageForm : Form
    {
        private int index;
        public ShowMessageForm(int index)
        {
            this.index = index;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int x = 0; x< MessageDL.MessageList.Count; x++)
            {
                if (index == MessageDL.MessageList[x].Index)
                {
                    tbMessage.Text = MessageDL.MessageList[x].Messag;
                    break;
                }
                else
                {
                    count++;
                }
            }
            if(count == MessageDL.MessageList.Count)
            {
                lblError.Visible = true;
                lblError.Text = "Message not found ";
            }

        }

        private void ShowMessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
