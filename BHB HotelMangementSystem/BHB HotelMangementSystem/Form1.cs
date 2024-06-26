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
    public partial class Form1 : Form
    {
        static Muser status = null;
        static int index = 0;

        private string userPath = "user.txt";
        private string guestPath = "guest.txt";
        private string discountPath = "discount.txt";
        private string roomPath = "room.txt";
        private string FormPath = "Form.txt";
        private string messagePath = "Message.txt";
        public Form1()
        {
            try
            {
                MuserDL.loadUser(userPath);
                guestDL.loadGuest(guestPath);
                discountDL.loadDiscount(discountPath);
                roomDL.loadRoom(roomPath);
                CheckInDL.loadForms(FormPath);
                MessageDL.loadMessage(messagePath);
            }
            catch (Exception exp)
            {
                MessageBox.Show("on loading ");
            }

            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkBox1.Checked == true)

                {
                    Muser a = new Muser(tbName.Text, tbPassword.Text);
                    if (Muser.isValid(a))
                    {
                        Muser b = Muser.isAdmin(a);
                        if (b != null && b.UserRole == "MANAGER")
                        {

                            status = a;
                            MangerForm frm = new MangerForm();
                            frm.Show();
                        }
                        else if (b != null && b.UserRole == "USER")
                        {
                            status = a;
                            index = getIndex(b);
                            UserForm form = new UserForm(a, index);
                            form.Show();
                        }
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Invalid Username / Password";
                    }
                }
                else
                {
                    MessageBox.Show("First Tccept The Conditions");
                }
            }
            catch (Exception exp)
            {
                lblError.Visible = true;
                lblError.Text = "Enter the valid data";
            }

           
            
        }
        public static int getIndex(Muser a)
        {
            int y = 0;
            for(int x = 0; x <MuserDL.UserList.Count; x++)
            {
                if (a.UserName == MuserDL.UserList[x].UserName)
                {
                    y = x;
                }
            }
            return y;
        }
        public  static Muser CurrentUser()
        {
            return status;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
