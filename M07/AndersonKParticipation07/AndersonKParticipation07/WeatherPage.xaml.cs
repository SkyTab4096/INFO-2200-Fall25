namespace AndersonKParticipation07;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();

		// Updates the contents of the results labels to the contents of the WeatherGV class
		LblCity.Text = WeatherGV.CityName;
		LblCurTemp.Text = $"Current Temp: {WeatherGV.CurTemp}�F";
		LblHighTemp.Text = $"High Temp: {WeatherGV.MaxTemp}�F";
		LblLowTemp.Text = $"Low Temp: {WeatherGV.MinTemp}�F";
	}
}