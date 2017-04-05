using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HotelBookingApp.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GuestView : Page
    {
        public GuestView()
        {
            this.InitializeComponent();
        }


        private void Hotel_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Guest_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(GuestView));
        }

        private void Room_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(RoomView));
        }

        private void Booking_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BookingView));
        }
    }
}
