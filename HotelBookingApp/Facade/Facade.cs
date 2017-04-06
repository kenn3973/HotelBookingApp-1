using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using Windows.UI.Popups;
using System.Collections.ObjectModel;

namespace HotelBookingApp.Facade
{
    static class Facade
    {

        const string serverUrl = "http://hotelws20170329124147.azurewebsites.net";

        /*GET GUESTS ASYNC*/
        public static async Task<ObservableCollection<Guest>> GetGuestsAsync()
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                string urlStringGet = "api/Guests/";

                try
                {
                    HttpResponseMessage getResponse = await client.GetAsync(urlStringGet);

                    if (getResponse.IsSuccessStatusCode)
                    {
                        var TempGuestsCollection = await getResponse.Content.ReadAsAsync<ObservableCollection<Guest>>();
                        return TempGuestsCollection;
                    }
                }
                catch (Exception e)
                {
                    MessageDialog exception = new MessageDialog(e.Message);
                }
                /*Har prøvet at få en MessageDialog til at bekræfte at gæsterne er hentet fra databasen, men det lykkedes ikke.*/
                //MessageDialog succes = new MessageDialog($"Gæsterne blev hentet fra databasen via {serverUrl} Hotel Guest Web Service.");
                return null;
            }
        }
    }
}
