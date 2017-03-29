using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Model
{
    class Hotel
    {
        public int Hotel_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public virtual ICollection<Room> Rooms { get; set; }


        public Hotel(int Hotel_No, string Name, string Address)
        {
            this.Hotel_No = Hotel_No;
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Hotel_No {Hotel_No}, Name {Name}, Address {Address}";
        }
    }
}
