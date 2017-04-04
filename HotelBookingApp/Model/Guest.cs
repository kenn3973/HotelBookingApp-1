using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Model
{
    class Guest
    {

        public int Guest_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        //public virtual ICollection<Booking> Bookings { get; set; }

        public Guest(int guest_no, string Name, string Address)
        {
            this.Guest_No = guest_no;
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Guest_no: {Guest_No}, Name: {Name}, Address: {Address}";
        }

    }
}
