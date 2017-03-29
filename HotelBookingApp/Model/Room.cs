using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Model
{
    class Room
    {
        public int Room_No { get; set; }
        public int Hotel_No { get; set; }
        public string Types { get; set; }
        public double? Price { get; set; }
        //public virtual ICollection<Booking> Bookings { get; set; }
        //public virtual Hotel Hotel { get; set; }

        public Room(int Room_No, int Hotel_No, string Types, double Price)
        {
            this.Room_No = Room_No;
            this.Hotel_No = Hotel_No;
            this.Types = Types;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"Room_No {Room_No}, Hotel_No {Hotel_No}, Types {Types}, Price {Price}";
        }
    }
}
