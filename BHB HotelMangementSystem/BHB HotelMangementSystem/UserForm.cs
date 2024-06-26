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
    public partial class UserForm : Form
    {
        private Muser PreviousStatus;
        private int index = 0;
        public UserForm(Muser previous , int index)
        {
            InitializeComponent();
            PreviousStatus = previous;
            this.index = index;
        }

        private void viewRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRoom frm = new ViewRoom();
            frm.ShowDialog();
        }

        private void viewDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDiscountForm frm = new ViewDiscountForm();
            frm.ShowDialog();
        }

        private void seeAlertMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMessageForm frm = new ShowMessageForm(index);
            frm.ShowDialog();
        }

        private void changePaswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserChangePasswordForm frm = new UserChangePasswordForm(PreviousStatus);
            frm.ShowDialog();
        }

        private void addReservationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddReservationForm frm = new AddReservationForm();
            frm.ShowDialog();
        }
        private void viewAvailableRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAvailableRoomForm frm = new ViewAvailableRoomForm();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
