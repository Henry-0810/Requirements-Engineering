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
    public partial class frmAddRoom : Form
    {
        public frmAddRoom()
        {
            InitializeComponent();
        }

        private void frmAddRoom_Load(object sender, EventArgs e)
        {
            //Get Room Type from Database WONT BE DOING THIS
            cboRoomTypes.Items.Add("SD - Standard Double");
            cboRoomTypes.Items.Add("SS - Standard Single");
            cboRoomTypes.Items.Add("DD - Deluxe Double");
            cboRoomTypes.Items.Add("DS - Deluxe Single");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validate data

            //check room no is numeric

            //set status

            //save data
            //NOT DOING THIS


            //display confirmation
            MessageBox.Show("Room has Been Added", "Information", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            cboRoomTypes.SelectedIndex = -1;
            txtRoomNo.Clear();
            txtRoomNo.Focus();

        }
    }
}
