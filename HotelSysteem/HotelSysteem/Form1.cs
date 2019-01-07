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
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Graphics = e.Graphics;
            Graphics.DrawEllipse(Pens.Blue, 460, 22, 75, 75);
            SolidBrush fillbrush = new SolidBrush(Color.Green);
            Graphics.FillEllipse(fillbrush, new Rectangle(460,22,74,74));
            Point p1 = new Point();
            p1.X = 430;
            p1.Y = 60;
            Point p2 = new Point();
            p2.X = 570;
            p2.Y = 60;
            Graphics.DrawLine(Pens.Red, p2, p1);
        }
    }
}
