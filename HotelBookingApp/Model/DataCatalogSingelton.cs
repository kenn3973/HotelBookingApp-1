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
            GetGuestsAsync();
        }


        /*Guest List methoder*/

        /*Foreaches over all objects from GetGuestsAsync Get call, and inserts them into the Guests observable collection list*/
        public async Task GetGuestsAsync()
        {
            foreach (var item in await Facade.Facade.GetGuestsAsync())
            {
                this.Guests.Add(item);
            }
        }

        /*Add guest*/
        public void AddGuest(Guest GuestToAdd)
        {
            Facade.Facade.PostNewGuest(GuestToAdd);
            DataCatalogSingelton.Instance.Guests.Add(GuestToAdd);
            DataCatalogSingelton.Instance.Guests.Clear();
            GetGuestsAsync();
        }

        /*Update*/
        public void UpdateGuest(Guest guestToUpdate)
        {
            Facade.Facade.PutNewGuest(guestToUpdate);
            DataCatalogSingelton.Instance.Guests.Clear();
            GetGuestsAsync();
        }

        /*Delete guest*/
        public void RemoveGuest(Guest GuestToRemove)
        {
            if (GuestToRemove != null)
            {
                Facade.Facade.DeleteGuestFromWS(GuestToRemove);
                DataCatalogSingelton.Instance.Guests.Remove(GuestToRemove);
            }
        }
    }
}
