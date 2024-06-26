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
    public partial class EditUser2 : Form
    {
        private Muser previous;
        public EditUser2(Muser previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Muser updateUsr = new Muser(tbName.Text, tbPass.Text, tbRole.Text);
                MuserDL.editUserFromList(previous, updateUsr);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void EditUser2_Load(object sender, EventArgs e)
        {
            tbName.Text = previous.UserName;
            tbPass.Text = previous.UserPassword;
            tbRole.Text = previous.UserRole;
        }
    }
}
