using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSysteem
{
    public partial class Form1 : Form
    {
        FileManager File = new FileManager();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
           string Name =  txbName.Text;
           string Address = txbAddress.Text;
           int Room = Convert.ToInt32(txbRoom.Text);
           DateTime Date = Convert.ToDateTime(dtpDate.Text);
           File.Insert(Name, Address, Room, Date);
        }

        private void btnOverView_Click(object sender, EventArgs e)
        {
            overview form = new overview();
            this.Hide();
            form.Show();
        }
    }
}
