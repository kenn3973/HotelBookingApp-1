using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Model;
using System.ComponentModel;

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


        /*Selected Guest*/
        private Guest _selectedGuest;
        public Guest SelectedGuest
        {
            get { return _selectedGuest; }
            set { _selectedGuest = value; }
        }

        /*Constructor*/
        public MainViewModel()
        {
            DataSingelton = DataCatalogSingelton.Instance;
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
