/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: 12/05/25
Participation or Assignment #: 07
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/
namespace AndersonKAssignment07
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Initialize a new instance of the main page of the project
            MainPage = new NavigationPage(new MainPage());
        }
    }
}