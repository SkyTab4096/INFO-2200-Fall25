/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: 12/05/25
Participation or Assignment #: 07
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/
using System.Net;
using Newtonsoft.Json.Linq;

namespace AndersonKAssignment07
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
		/// Create the event handler for when the button to find the earthquake information is pressed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void BtnFind_Clicked(object sender, EventArgs e)
        {
            // Checks to see if the user entered information in the start date box
            if (EnterStartDate.Text != "")
            {
                // Checks to see if the user entered information in the end date box
                if (EnterEndDate.Text != "")
                {
                    // Checks to make sure the user entered information in the magnitude box
                    if (EnterEarthquakeSize.Text != "")
                    {
                        // Initalizes an instance of the webclient class to perform the api call
                        using (WebClient wc = new WebClient())
                        {
                            // Starts an exception handling instance to perform the API call
                            try
                            {
                                // API Call
                                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                                string json = wc.DownloadString($"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&starttime={EnterStartDate.Text}&endtime={EnterEndDate.Text}&minmagnitude={EnterEarthquakeSize.Text}");

                                // JObject Class
                                JObject jo = JObject.Parse( json );
                                JObject main = JObject.Parse(jo["metadata"].ToString());

                                // JArray Class
                                JArray features = JArray.Parse(jo["features"].ToString());
                                JArray eQjArray = new();

                                // Number of earthquakes
                                int count = 0;
                                int.TryParse(main["count"].ToString(), out count);

                                // Loop to populate the eQJarray which stores the values obtained from the features node
                                // Using the count variable as the counter control variable
                                for (int i = 0; i < count; ++i)
                                {
                                    eQjArray.Add(features[i]);
                                }

                                // Create a list of earthquakes and gets values from the API
                                List<Earthquake> eqList = new List<Earthquake>();
                                int idx = 0;
                                foreach (var eq in eQjArray)
                                {
                                    // Attempt to parse the properties of the returned earthquake into a json object
                                    JObject eqJObj = JObject.Parse(eq["properties"].ToString());
                                    // Turns the properties in the json object into an object of the earthquake class
                                    Earthquake earthquake = new Earthquake()
                                    {
                                        EQid = idx + 1,
                                        EQSize = double.Parse(eqJObj["mag"].ToString()),
                                        EQLocation = eqJObj["place"].ToString()
                                    };
                                    // Adds the earthquake to a list of earthquakes
                                    eqList.Add(earthquake);
                                }

                                // Display the results of ONE random earthquake from the list recieved
                                Random random = new();
                                int randeq = random.Next(0, eqList.Count);
                                Earthquake displayEQ = eqList[randeq];
                                lblResults.Text = $"There were {count} earthquakes during this time.\n\n" +
                                    $"Details of one of them:\nPlace: {displayEQ.EQLocation}, \nMagnitude: {displayEQ.EQSize}.";
                            }
                            catch (Exception ex)
                            {
                                // Display an error if an error occured during runtime
                                DisplayAlert("Error", ex.Message, "Close");
                            }
                        }
                    }
                    else
                    {
                        // Displays an error if the user did not enter a magnitude
                        DisplayAlert("Error", "Please enter earthquake size", "Close");
                    }
                }
                else
                {
                    // Displays an error if the user did not enter an end date
                    DisplayAlert("Error", "Please enter end date", "Close");
                }
            }
            else
            {
                // Displays an error if the user did not enter a start date
                DisplayAlert("Error", "Please enter start date", "Close");
            }
        }
    }
}
