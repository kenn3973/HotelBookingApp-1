using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Model
{
    class Booking
    {
        public int Booking_id { get; set; }
        public int Hotel_No { get; set; }
        public int Guest_No { get; set; }
        public DateTime Date_From { get; set; }
        public DateTime Date_To { get; set; }
        public int Room_No { get; set; }
        //public virtual Room Room { get; set; }
        //public virtual Guest Guest { get; set; }


        public Booking(int Booking_id, int Hotel_No, int Guest_No, DateTime Date_From, DateTime Date_To, int Room_No)
        {
            this.Booking_id = Booking_id;
            this.Hotel_No = Hotel_No;
            this.Guest_No = Guest_No;
            this.Date_From = Date_From;
            this.Date_To = Date_To;
            this.Room_No = Room_No;
        }

        public override string ToString()
        {
            return $"Booking_id {Booking_id}, Hotel_No {Hotel_No}, Guest_no {Guest_No}, Date_from {Date_From}, Date_to {Date_To}, Room_no {Room_No}";
        }
    }
}
