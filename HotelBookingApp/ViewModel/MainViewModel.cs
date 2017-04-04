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

        private DataCatalogSingelton _dataSingelton;

        public DataCatalogSingelton DataSingelton
        {
            get { return _dataSingelton; }
            set { _dataSingelton = value; }
        }




        public MainViewModel()
        {
            Guest g1 = new Guest(1, "Rudi", "Something");
            Guest g2 = new Guest(2, "Rudi", "Something");
            Guest g3 = new Guest(3, "Rudi", "Something");

            DataSingelton = DataCatalogSingelton.Instance;
            //DataSingelton.Guests.Add(g1);
            //DataSingelton.Guests.Add(g2);
            //DataSingelton.Guests.Add(g3);

            DataCatalogSingelton.Instance.Guests.Add(g1);


        }
    }

}
