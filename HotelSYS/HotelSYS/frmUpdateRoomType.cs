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
    public partial class frmUpdateRoomType : Form
    {
        public frmUpdateRoomType()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUpdateRoomType_Load(object sender, EventArgs e)
        {
            //Retrieve room types
            cboRoomTypes.Items.Add("SD - Standard Double");
            cboRoomTypes.Items.Add("SS - Standard Single");
            cboRoomTypes.Items.Add("DD - Deluxe Double");
            cboRoomTypes.Items.Add("DS - Deluxe Single");
            cboRoomTypes.Items.Add("SD - Standard Double");
        }

        private void cboRoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoomTypes.SelectedIndex == -1)
                return;
            //get room type details and load on UI
            txtDescription.Text = "Standard Double";
            txtRate.Text = "80.00";

            grpRoomType.Visible = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate data
            if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Type Code must be Entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
                return;
            }


            //Update data in DB
            //NOT DOING THIS!

            //Display comfirmation
            MessageBox.Show("Room Type Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grpRoomType.Visible = false;
            cboRoomTypes.SelectedIndex = -1;
        }
    }
}
