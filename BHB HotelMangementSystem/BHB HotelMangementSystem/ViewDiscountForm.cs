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
    public partial class ViewDiscountForm : Form
    {
        public ViewDiscountForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewDiscountForm_Load(object sender, EventArgs e)
        {
            gv.DataSource = discountDL.DiscountList;
        }
    }
}
