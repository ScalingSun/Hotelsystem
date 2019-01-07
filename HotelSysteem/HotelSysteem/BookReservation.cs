using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSysteem
{
    class BookReservation
    {
        public string Name;
        public string Address;
        public string Room;
        public string Date;
        public BookReservation(string Name , string Address, string Room, string Date)
        {
            this.Name = Name;
            this.Address = Address;
            this.Room = Room;
            this.Date = Date;
        }
    }
}
