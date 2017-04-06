using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Facade;
using HotelBookingApp.Model;
using HotelBookingApp.ViewModel;

namespace HotelBookingApp.Handler
{
    class GuestHandler
    {
        /*Properties*/
        public MainViewModel MainViewModel { get; set; }


        /*Contsructor*/
        public GuestHandler(MainViewModel MvM)
        {
            this.MainViewModel = MvM;
        }

        /*Methods*/
        public void CreateGuest()
        {
            Guest newGuest = new Guest(MainViewModel.Guest_No, MainViewModel.Name, MainViewModel.Address);
            DataCatalogSingelton.Instance.AddGuest(newGuest);
        }


        /*Update*/
        public void UpdateGuest()
        {
            Guest updateGuest = MainViewModel.NewGuest;
            DataCatalogSingelton.Instance.UpdateGuest(updateGuest);
        }

        public void DeleteGuest()
        {
            DataCatalogSingelton.Instance.RemoveGuest(MainViewModel.SelectedGuest);
        }
    }
}
