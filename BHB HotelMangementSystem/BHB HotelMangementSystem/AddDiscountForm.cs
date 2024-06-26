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
    public partial class AddDiscountForm : Form
    {
        private string path = "discount.txt";

        public AddDiscountForm()
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
                if (tbId.Text.Length > 0 && cbType.Text.Length > 0 && cbStatus.Text.Length > 0 && tbDiscountRate.Text.Length > 0)
                {
                    discount dis = new discount(int.Parse(tbId.Text), cbType.Text, cbStatus.Text, tbDiscountRate.Text);
                    if (discountDL.isExist(dis))
                    {
                        MessageBox.Show("already present with this information ");
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "added successfully";
                        discountDL.addIntoList(dis);
                        discountDL.addIntoFile(dis, path);
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "first fulfill the data";
                }
            }
            catch (Exception exp)
            {
                lblError.Visible = true;
                lblError.Text = "enter  the valid  data";
            }
        }
    }
}
