namespace AndersonKParticipation07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Starts a new instance of the main page of the project
            MainPage = new NavigationPage(new MainPage());
        }
    }
}