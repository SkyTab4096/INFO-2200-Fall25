using System.Net;
using Newtonsoft.Json.Linq;

namespace AndersonKParticipation07
{
    public partial class MainPage : ContentPage
    {
        string APIKEY = "1e00561e3e30e6524cd38e649f6b7908";

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for when the button on the main page is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowTemp_Clicked(object sender, EventArgs e)
        {
            // Checks to make sure that the user entered a value in the zipcode text box
            if (EntryZipCode.Text != null)
            {
                // Intializes a new instance of a webclient to call the api
                using (WebClient wc = new())
                {
                    try
                    {
                        // Sets the http headers for the api call
                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        // Stores the results of the api call
                        string json = wc.DownloadString($"http://api.openweathermap.org/data/2.5/weather?zip={EntryZipCode.Text}&appid={APIKEY}&units=imperial");
                        
                        // Attempts to parse the results of the api call into a json object
                        JObject jo = JObject.Parse(json);
                        JObject main = JObject.Parse(jo["main"].ToString());
                        
                        // Sets the values in the weatherGV class to be the api results
                        WeatherGV.CityName = jo["name"].ToString();
                        WeatherGV.CurTemp = double.Parse(main["temp"].ToString());
                        WeatherGV.MinTemp = double.Parse(main["temp"].ToString());
                        WeatherGV.MaxTemp = double.Parse(main["temp"].ToString());
                        
                        // Loads a new instance of the weather results page
                        Navigation.PushAsync(new WeatherPage());
                    }
                    catch (Exception ex)
                    {
                        // Display an error message with the contents of the error
                        DisplayAlert("Error", ex.Message, "Close");
                    }
                }
            }
            else
            {
                // Displays an error message to make sure the user enters a zip code
                DisplayAlert("Invalid Input", "Please enter a zip code", "Close");
            }
        }
    }
}
