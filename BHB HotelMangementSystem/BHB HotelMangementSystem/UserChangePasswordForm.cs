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
    public partial class UserChangePasswordForm : Form
    {
        private Muser PreviousStatus;
        public UserChangePasswordForm(Muser previous)
        {
            InitializeComponent();
            PreviousStatus = previous;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int count = 0;
            Muser s = Form1.CurrentUser();
            foreach (Muser a in MuserDL.UserList)
            {
                if (s.UserName == a.UserName)
                {
                    if (s.UserPassword == tbPreviousPassword.Text)
                    {
                        a.UserPassword = tbNewPassword.Text;
                        lblError.Visible = true;
                        lblError.Text = "Change Successfully";

                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Previous password not matched";
                    }


                }
                else
                {
                    count++;
                }
            }
            if (count == MuserDL.UserList.Count)
            {
                lblError.Visible = true;
                lblError.Text = "user not find";
            }

           /* foreach (Muser a in MuserDL.UserList)
            {
                if (PreviousStatus.UserName == a.UserName)
                {
                    if (s.UserPassword == tbPreviousPassword.Text)
                    {
                        a.UserPassword = tbNewPassword.Text;
                        lblError.Visible = true;
                        lblError.Text = "Change Successfully";

                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Previous password not matched";
                    }


                }
                else
                {
                    count++;
                }
            }
            if (count == MuserDL.UserList.Count)
            {
                lblError.Visible = true;
                lblError.Text = "user not find";
            }*/
        }

    }
}
