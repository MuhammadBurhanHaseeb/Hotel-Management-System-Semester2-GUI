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
    public partial class AddCheckOutForm : Form
    {
        private string path = "Form.txt";
        public AddCheckOutForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbGuestId.Text.Length > 0 && tbGuestName.Text.Length > 0 && tbGuestAddress.Text.Length > 0 && tbGuestContact.Text.Length > 0 && tbGuestEmail.Text.Length > 0 && cbGuestGender.Text.Length > 0 && tbAdults.Text.Length > 0 && tbChildren.Text.Length > 0 && tbCheckInDate.Text.Length > 0 && tbCheckOutDate.Text.Length > 0 && cbDays.Text.Length > 0 && tbRoomNo.Text.Length > 0 && cbRoomType.Text.Length > 0 && cbRoomStatus.Text.Length > 0 && cbRoomRate.Text.Length > 0 && cbDiscountStatus.Text.Length > 0 && cbDiscountType.Text.Length > 0 && cbDiscountRate.Text.Length > 0)
                {
                    if (tbGuestContact.Text.Length == 11)
                    {
                        double balance, discount;
                        balance = int.Parse(cbRoomRate.Text) * int.Parse(cbDays.Text);
                        discount = (int.Parse(cbRoomRate.Text) * int.Parse(cbDays.Text)) * (int.Parse(cbDiscountRate.Text) / 100.0F);
                        balance = balance - discount;
                        CheckIn s = new CheckOut("CO", int.Parse(tbGuestId.Text), tbGuestName.Text, tbGuestAddress.Text, tbGuestContact.Text, tbGuestEmail.Text, cbGuestGender.Text, int.Parse(tbAdults.Text), int.Parse(tbChildren.Text), tbCheckInDate.Text, tbCheckOutDate.Text, int.Parse(cbDays.Text), int.Parse(tbRoomNo.Text), cbRoomType.Text, cbRoomStatus.Text, int.Parse(cbRoomRate.Text), cbDiscountStatus.Text, cbDiscountType.Text, int.Parse(cbDiscountRate.Text), balance);
                        if (CheckInDL.isExist(s))
                        {
                            lblError.Visible = true;
                            lblError.Text = "already present with this name!";
                        }
                        else
                        {

                            tbBalance.Text = balance.ToString();
                            CheckInDL.addIntoList(s);
                            CheckInDL.addIntoFile(s, path);
                            lblError.Visible = true;
                            lblError.Text = "added succesfully!";
                        }
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Contact must be in Corresct way";
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "FulFill all the data";
                }
            }
            catch (Exception exp)
            {
                lblError.Visible = true;
                lblError.Text = "Enter Vlid";
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCheckOutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
