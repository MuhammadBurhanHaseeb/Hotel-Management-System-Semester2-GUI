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
    public partial class SearchCheckOutUserForm : Form
    {
        public SearchCheckOutUserForm()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (CheckIn s in CheckInDL.FormList)
            {
               /* if (tbGuestName.Text == s.Name)
                {
                    pannelGrid.Visible = true;
                    gv.DataSource = null;
                    gv.ReadOnly = true;
                    DataTable table = new DataTable();
                    table.Columns.Add("Name", typeof(string));
                    table.Columns.Add("Contact", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Address", typeof(string));
                    table.Columns.Add("CheckInDate", typeof(string));
                    table.Columns.Add("CheckOutDate", typeof(string));
                    table.Columns.Add("Days", typeof(int));
                    table.Columns.Add("Adults", typeof(int));
                    table.Columns.Add("Children", typeof(int));
                    table.Columns.Add("Gender", typeof(string));
                    table.Columns.Add("Balance", typeof(double));
                    table.Rows.Add(s.Name , s.Contact , s.Email,s.Addres ,s.InDate,s.OutDate,s.Days,s.Adult,s.Children,s.Gender,s.Balance);

                    gv.DataSource = table;
                }*/
               if (tbUserName.Text == s.Name  && s.Status == "CO")
                {
                    pannelTextBox.Visible = true;
                    tbGuestName.Text = s.Name;
                    tbGuestId.Text = s.Gid.ToString();
                    tbGuestAddress.Text = s.Addres;
                    tbGuestEmail.Text = s.Email;
                    tbGuestContact.Text = s.Contact;
                    tbGuestGender.Text = s.Gender;
                    tbAdults.Text = s.Adult.ToString();
                    tbChildren.Text = s.Children.ToString();
                    tbRoomNo.Text = s.RoomNo.ToString();
                    tbRoomStatus.Text = s.Sroom;
                    tbRoomType.Text = s.Troom;
                    tbRoomRate.Text = s.RoomRate.ToString();
                    tbCheckInDate.Text = s.InDate;
                    tbCheckOutDate.Text = s.OutDate;
                    tbDiscountRate.Text = s.DiscountRate.ToString();
                    tbDiscountStatus.Text = s.Sdiscount.ToString();
                    tbDiscountType.Text = s.Tdiscount;
                    tbBalance.Text = s.Balance.ToString();
                    tbDays.Text = s.Days.ToString();
                }
                else
                {
                    count++;
                }
            }
            if(count==CheckInDL.FormList.Count)
            {
                //lblError.Visible = true;
                label.Visible = true;
                lblError.Text = "Not Found !";
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
