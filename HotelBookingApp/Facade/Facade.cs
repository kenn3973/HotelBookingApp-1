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
    public static class Facade
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

        public static async Task<Guest> GetGuestAsync(int guestId)
        {

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                string urlStringGet = "api/Guests/" + guestId;

                try
                {
                    HttpResponseMessage getResponse = await client.GetAsync(urlStringGet);

                    if (getResponse.IsSuccessStatusCode)
                    {
                        var TempGuestsCollection = await getResponse.Content.ReadAsAsync<Guest>();
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

        /*Delete Guest*/
        /*Mangler at slettes bookings først. Elelrs bliver guest ikke slettet fra WS*/
        public static void DeleteGuestFromWS(Guest selectedGuest)
        {
            var urlString = "api/guests/" + selectedGuest.Guest_No;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();

                try
                {
                    var response = client.DeleteAsync(urlString).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Debug.Write("You deleted an event");
                        Debug.Write("StatusCode : " + response.StatusCode);
                    }
                    else
                    {
                        Debug.Write("Event was not deleted");
                        Debug.Write("StatusCode : " + response.StatusCode);
                    }
                }
                catch (Exception e)
                {
                    Debug.Write("Something went wrong " + e.Message);
                }
            }
        }


        /*POST Guest*/
        public static void PostNewGuest(Guest newGuest)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.PostAsJsonAsync<Guest>("api/Guests", newGuest).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        //MessageDialogHelper.show("ny event added");
                        Debug.Write("You have insertet a new event to the DB");
                        Debug.Write("Status code : " + response.StatusCode);
                    }
                    else
                    {
                        Debug.Write("Something went wrong " + response);
                        Debug.Write("Statuscode : " + response.StatusCode);
                    }
                }
                catch (Exception e)
                {
                    Debug.Write("The error is : " + e.Message);
                }
            }
        }

        public static void PutNewGuest(Guest newGuest)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(serverUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    var response = client.PutAsJsonAsync<Guest>($"api/Guests/{newGuest.Guest_No}", newGuest).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        //MessageDialogHelper.show("ny event added");
                        Debug.Write("You have insertet a new event to the DB");
                        Debug.Write("Status code : " + response.StatusCode);
                    }
                    else
                    {
                        Debug.Write("Something went wrong " + response);
                        Debug.Write("Statuscode : " + response.StatusCode);
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
