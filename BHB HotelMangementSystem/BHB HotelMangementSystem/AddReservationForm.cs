using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BHB_HotelMangementSystem.BL;
using BHB_HotelMangementSystem.DL;
using System.Windows.Forms;

namespace BHB_HotelMangementSystem
{
    public partial class AddReservationForm : Form
    {
        private string path = "Form.txt";
        public AddReservationForm()
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
                if (tbGuestId.Text.Length > 0 && tbGuestName.Text.Length > 0 && tbGuestAddress.Text.Length > 0 && tbGuestContact.Text.Length > 0 && tbGuestEmail.Text.Length > 0 && cbGuestGender.Text.Length > 0 && tbAdults.Text.Length > 0 && tbChildren.Text.Length > 0 && tbCheckInDate.Text.Length > 0 && tbCheckOutDate.Text.Length > 0 && cbDays.Text.Length > 0 && tbRoomNo.Text.Length > 0 && cbRoomType.Text.Length > 0 && cbRoomStatus.Text.Length > 0 && cbDiscountStatus.Text.Length > 0 && cbDiscountType.Text.Length > 0)
                {
                    if (tbGuestContact.Text.Length == 11)
                    {
                        int a = 0, b = 0;
                        if ((cbDiscountStatus.Text == "vip" && cbRoomStatus.Text == "vip") && (cbDiscountType.Text == "four" && cbRoomType.Text == "four"))
                        {
                            a = 50;
                            b = 4000;


                        }

                        else if ((cbDiscountStatus.Text == "vip" && cbRoomStatus.Text == "vip") && (cbDiscountType.Text == "three" && cbRoomType.Text == "three"))
                        {
                            a = 45;
                            b = 3500;
                        }

                        else if ((cbDiscountStatus.Text == "vip" && cbRoomStatus.Text == "vip") && (cbDiscountType.Text == "two" && cbRoomType.Text == "two"))
                        {
                            a = 40;
                            b = 3000;
                        }
                        else if ((cbDiscountStatus.Text == "vip" && cbRoomStatus.Text == "vip") && (cbDiscountType.Text == "one" && cbRoomType.Text == "one"))
                        {
                            a = 35;
                            b = 2800;
                        }
                        else if ((cbDiscountStatus.Text == "regular" && cbRoomStatus.Text == "regular") && (cbDiscountType.Text == "four" && cbRoomType.Text == "four"))
                        {
                            a = 30;
                            b = 2500;
                        }
                        else if ((cbDiscountStatus.Text == "regular" && cbRoomStatus.Text == "regular") && (cbDiscountType.Text == "three" && cbRoomType.Text == "three"))
                        {
                            a = 25;
                            b = 2000;
                        }
                        else if ((cbDiscountStatus.Text == "regular" && cbRoomStatus.Text == "regular") && (cbDiscountType.Text == "two" && cbRoomType.Text == "two"))
                        {
                            a = 20;
                            b = 1500;
                        }
                        else if ((cbDiscountStatus.Text == "regular" && cbRoomStatus.Text == "regular") && (cbDiscountType.Text == "one" && cbRoomType.Text == "one"))
                        {
                            a = 15;
                            b = 1400;
                        }
                        else if ((cbDiscountStatus.Text == "none" && cbRoomStatus.Text == "none") && (cbDiscountType.Text == "four" && cbRoomType.Text == "four"))
                        {
                            a = 10;
                            b = 1200;
                        }
                        else if ((cbDiscountStatus.Text == "none" && cbRoomStatus.Text == "none") && (cbDiscountType.Text == "three" && cbRoomType.Text == "three"))
                        {
                            a = 5;
                            b = 1000;
                        }
                        else if ((cbDiscountStatus.Text == "none" && cbRoomStatus.Text == "none") && (cbDiscountType.Text == "two" && cbRoomType.Text == "two"))
                        {
                            a = 1;
                            b = 800;
                        }
                        else if ((cbDiscountStatus.Text == "none" && cbRoomStatus.Text == "none") && (cbDiscountType.Text == "one" && cbRoomType.Text == "one"))
                        {
                            a = 0;
                            b = 700;
                        }

                        double balance, discount;
                        balance = b * int.Parse(cbDays.Text);
                        discount = (b * int.Parse(cbDays.Text)) * (a / 100.0F);
                        balance = balance - discount;
                        CheckIn s = new Reservation("R", int.Parse(tbGuestId.Text), tbGuestName.Text, tbGuestAddress.Text, tbGuestContact.Text, tbGuestEmail.Text, cbGuestGender.Text, int.Parse(tbAdults.Text), int.Parse(tbChildren.Text), tbCheckInDate.Text, tbCheckOutDate.Text, int.Parse(cbDays.Text), int.Parse(tbRoomNo.Text), cbRoomType.Text, cbRoomStatus.Text, b, cbDiscountStatus.Text, cbDiscountType.Text, a, balance);

                        if (CheckInDL.isExist(s))
                        {
                            lblError.Visible = true;
                            lblError.Text = "already present with this name";
                        }
                        else
                        {
                            tbRoomRate.Text = b.ToString();
                            tbDiscountRate.Text = a.ToString();
                            tbBalance.Text = balance.ToString();
                            CheckInDL.addIntoList(s);
                            CheckInDL.addIntoFile(s, path);
                            lblError.Visible = true;
                            lblError.Text = "succesfully added";
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
                lblError.Text = "Enter  the Valid data";
            }
        }
    }
}
