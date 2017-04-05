using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace HotelBookingApp.Facade
{
    static class Facade
    {
        /*GET*/
        public static void getAllGuests()
        {
            DataCatalogSingelton.Instance.Guests.Clear();
            const string serverUrl = "http://hotelws20170329124147.azurewebsites.net";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string urlString = "api/guests";

                HttpResponseMessage response = client.GetAsync(urlString).Result;
                try
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var eventList = response.Content.ReadAsAsync<List<Guest>>().Result;
                        var query = from e in eventList
                                    select e;

                        foreach (var item in query)
                        {
                            DataCatalogSingelton.Instance.Guests.Add(item);
                        }
                    }
                    else
                    {
                        Debug.Write("Something went wrong " + response);

                    }
                }
                catch (Exception e)
                {
                    Debug.Write("The error is : " + e.Message);
                }
            }
        }
    }
}
