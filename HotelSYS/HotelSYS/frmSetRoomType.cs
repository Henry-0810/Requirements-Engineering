using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSYS
{
    public partial class frmSetRoomType : Form
    {
        public frmSetRoomType()
        {
            InitializeComponent();
        }

        private void txtTypeCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //check all fields are entered
            if (txtTypeCode.Text.Equals(""))
            {
                MessageBox.Show("Type Code must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTypeCode.Focus();
                return;
            }

            //check rate
            if(Convert.ToDouble(txtRate.Text) <= 0)
            {
                MessageBox.Show("Rate Must be greater than Zero", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return;
            }

            //check if type code already set up
            if (txtTypeCode.Text.Equals("DB"))
            {
                MessageBox.Show("This Type Code already Exists", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTypeCode.Focus();
                return;
            }


            //Save data in database
            //YOU ARE NOT IMPLEMENTING THIS!

            //Display confirmation message
            MessageBox.Show("Roomtype has Been Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtTypeCode.Clear();
            txtDescription.Clear();
            txtRate.Text = "0.00";
            txtTypeCode.Focus();
        }
    }
}
