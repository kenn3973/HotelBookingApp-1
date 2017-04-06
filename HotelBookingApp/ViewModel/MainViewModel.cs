using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Model;
using System.ComponentModel;
using System.Windows.Input;
using HotelBookingApp.Handler;
using HotelBookingApp.Common;

namespace HotelBookingApp.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
        public GuestHandler guestHandler { get; set; }




        private Guest _newGuest;

        public Guest NewGuest
        {
            get { return _newGuest; }
            set
            {
                _newGuest = value;
                OnPropertyChanged(nameof(NewGuest));

            }
        }



        /*Selected Guest*/
        private Guest _selectedGuest;
        public Guest SelectedGuest
        {
            get { return _selectedGuest; }
            set
            {
                _selectedGuest = value;
                OnPropertyChanged(nameof(SelectedGuest));
                NewGuest = new Guest(SelectedGuest.Guest_No, SelectedGuest.Name, SelectedGuest.Address);
            }
        }

        /*Commands Properties*/
        public ICommand CreateGuestCommand { get; set; }
        public ICommand DeleteGuestComand { get; set; }
        public ICommand UpdateGuestCommand { get; set; }



        /*Constructor*/
        public MainViewModel()
        {

            DataSingelton = DataCatalogSingelton.Instance;

            /*RelayCommand og refrence til handler*/
            guestHandler = new GuestHandler(this);

            CreateGuestCommand = new RelayCommand(guestHandler.CreateGuest, null);
            DeleteGuestComand = new RelayCommand(guestHandler.DeleteGuest, null);

            UpdateGuestCommand = new RelayCommand(guestHandler.UpdateGuest, null);


        }


        /*Prop changed*/
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }

    }

}
