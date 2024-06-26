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
    public partial class MangerForm : Form
    {

        public MangerForm()
        {
            InitializeComponent();
        }
        private void addDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDiscountForm frm = new AddDiscountForm();
            frm.ShowDialog();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser frm = new AddUser();
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewReservationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser frm = new DeleteUser();
            frm.ShowDialog();
        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewUser frm = new ViewUser();
            frm.ShowDialog();

        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser frm = new EditUser();
            frm.ShowDialog();
        }

        private void searchUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchUser frm = new SearchUser();
            frm.ShowDialog();
        }

        private void addGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGuest frm = new AddGuest();
            frm.ShowDialog();
        }

        private void viewGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Guest frm = new View_Guest();
            frm.ShowDialog();
        }

        private void deleteGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteGuest frm = new DeleteGuest();
            frm.ShowDialog();
        }

        private void addRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRoom frm = new AddRoom();
            frm.ShowDialog();

        }

        private void viewRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewRoom frm = new ViewRoom();
            frm.ShowDialog();
        }

        private void addCheckOutFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCheckOutForm frm = new AddCheckOutForm();
            frm.ShowDialog();
        }

        private void viewCheckOutFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCheckOutForm frm = new ViewCheckOutForm();
            frm.ShowDialog();
        }

        private void searchCheckOutCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchCheckOutUserForm frm = new SearchCheckOutUserForm();
            frm.ShowDialog();
        }

        private void addCheckInFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCheckInForm frm = new AddCheckInForm();
            frm.ShowDialog();
        }

        private void viewCheckInFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCheckInForm frm = new ViewCheckInForm();
            frm.ShowDialog();
        }

        private void addAvailableRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAvailableForm frm = new AddAvailableForm();
            frm.ShowDialog();
        }

        private void viewAvailableRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAvailableRoomForm frm = new ViewAvailableRoomForm();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CheckOutFormInOrder frm = new CheckOutFormInOrder();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageFormcs frm = new MessageFormcs();
            frm.ShowDialog();
        }

        private void viewReservationFormToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewRservationForm frm = new ViewRservationForm();
            frm.ShowDialog();
        }

        private void viewDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDiscountForm frm = new ViewDiscountForm();
            frm.ShowDialog();
        }

        private void bucketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 9;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void radixSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 8;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void countingSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 7;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 6;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 5;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 4;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void insertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 3;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void selectionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 2;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInDL.Type = 1;
            SORT frm = new SORT();
            frm.ShowDialog();
        }

        private void sORTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
