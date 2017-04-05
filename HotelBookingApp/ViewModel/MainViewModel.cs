using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Model;

namespace HotelBookingApp.ViewModel
{
    class MainViewModel
    {
        /*Singelton*/
        private DataCatalogSingelton _dataSingelton;

        public DataCatalogSingelton DataSingelton
        {
            get { return _dataSingelton; }
            set { _dataSingelton = value; }
        }

        /*Properties*/
        public int Guest_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        /*Test*/
        //Guest g1 = new Guest(1, "Rudi", "Something");
        //Guest g2 = new Guest(2, "Rudi", "Something");
        //Guest g3 = new Guest(3, "Rudi", "Something");


        /*Constructor*/
        public MainViewModel()
        {
            DataSingelton = DataCatalogSingelton.Instance;

            Facade.Facade.getAllGuests();


        }
    }

}
