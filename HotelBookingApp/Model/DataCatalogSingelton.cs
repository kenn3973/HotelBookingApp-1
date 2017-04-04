using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HotelBookingApp.Model
{
    class DataCatalogSingelton
    {
        private static DataCatalogSingelton _instance;

        public static DataCatalogSingelton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataCatalogSingelton();
                }
                return _instance;
            }
        }

        public ObservableCollection<Guest> Guests { get; set; }

        private DataCatalogSingelton()
        {
            Guests = new ObservableCollection<Guest>();
        }

    }
}
