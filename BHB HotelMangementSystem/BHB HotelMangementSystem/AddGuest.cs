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
    public partial class AddGuest : Form
    {
        private string path = "guest.txt";
        public AddGuest()
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
                int a = tbId.Text.Length;
                int b = tbName.Text.Length;
                int c = tbGender.Text.Length;
                int d = tbContact.Text.Length;
                int f = tbAddress.Text.Length;
                if (a > 0 && b > 0 && c > 0 && d > 0 && f > 0)
                {
                    if (d == 11)
                    {
                        guest gust = new guest(int.Parse(tbId.Text), tbName.Text, tbAddress.Text, tbContact.Text, tbEmail.Text, tbGender.Text);

                        if (guestDL.isExist(gust))
                        {
                            MessageBox.Show("Guest with this name is already present ");

                        }
                        else
                        {
                            guestDL.addIntoList(gust);
                            guestDL.addIntoFile(gust, path);
                            lblError.Visible = true;
                            lblError.Text = "Added successfully";
                        }

                    }
                    else
                    {
                        MessageBox.Show("contact is not in correct way:");
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "fulfill all data";
                }
            }
            catch (Exception exp )
            {
                lblError.Visible = true;
                lblError.Text = "Enter the valid data";
            }
        }
    }
}
