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
    public partial class overview : Form
    {
        FileManager data = new FileManager();
        List <BookReservation> Reservation = new List <BookReservation>();
        public overview()
        {
            InitializeComponent();
            int i = 0;
            string[] array = new string[6];

            List<string> list = data.OverviewList();
            foreach (string item in list)
            {
                array[i] = item;
                i++;
                if (i == 6)
                {
                    Reservation.Add(new BookReservation(array[0],array[1],array[2],array[3]));
                    dgvOverView.Rows.Add(array[0], array[1], array[2], array[3]);
                    i = 0;
                }
            }
        }
        
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Dispose();
            frm.Show();
        }
    }
}
