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
    public partial class AddUser : Form
    {
        private string path = "user.txt";
        public AddUser()
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
                Muser usr = new Muser(tbName.Text, tbPass.Text, cbRole.Text);
                if (MuserDL.isExist(usr))
                {
                    lblError.Visible = true;
                    lblError.Text = "User already with name is present :";
                }
                else
                {
                    MuserDL.addIntoList(usr);
                    MuserDL.addIntoFile(usr, path);
                    lblError.Visible = true;
                    lblError.Text = "added suucessfully :";
                    // dataBindings();
                }
            }
            catch (Exception exp)
            {
                lblError.Visible = true;
                lblError.Text = "Enter the valid data :";
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
