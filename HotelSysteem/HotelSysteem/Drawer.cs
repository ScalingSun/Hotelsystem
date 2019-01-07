using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace HotelSysteem
{
    class Drawer
    {
        private Graphics somevalue;
        public Drawer(Graphics somevalue)
        {
            this.somevalue = somevalue;
        }
        public void DrawLogo()
        {
            SolidBrush brush = new SolidBrush(Color.Blue);
        }
    }
}
