using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Model
{
    public class NrOfBookings
    {
        public string Name { get; set; }
        public int? numberOfBooking { get; set; }


        public NrOfBookings(string name, int numberOfbookings)
        {
            this.Name = name;
            this.numberOfBooking = numberOfbookings;
        }

        public override string ToString()
        {
            return $"Navn: {Name}, NrOfBookings: {numberOfBooking}";
        }
    }
}
