/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: Insert date submitted
Participation or Assignment #: 01
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

Console.WriteLine("Welcome to Kory's College City Lookup App\n");

Console.Write("Please enter a college and I will return the city. (x to exit)\t");
string userInput = Console.ReadLine().ToLower();

Dictionary<string, string> collegeCityDict = new Dictionary<string, string>();

StreamReader reader = new StreamReader("database.txt");

reader.ReadLine();

while (!reader.EndOfStream)
{
    string line = reader.ReadLine();
    string[] tempCollegeCity = line.Split(',');
    string college = tempCollegeCity[0];
    string city = tempCollegeCity[1];
    collegeCityDict.Add(college.ToUpper(), city.ToUpper());
}

reader.Close();

while (userInput != "x")
{
    if (userInput == "random")
    {
        Random rand = new Random();
        int totalColleges = rand.Next(collegeCityDict.Count);
        string randomCollege = collegeCityDict.ElementAt(totalColleges).Key;
        collegeCityDict.TryGetValue(randomCollege.ToUpper(), out string randomCity);
        Console.WriteLine($"\nCollege: {randomCollege}");
        Console.WriteLine($"City: {randomCity}\n");
    }
    if (collegeCityDict.TryGetValue(userInput.ToUpper(), out string city))
    {
        Console.WriteLine($"\nCollege: {userInput.ToUpper()}");
        Console.WriteLine($"City: {city}\n");
    }
    else if (userInput != "random")
    {
        Console.WriteLine($"Could not find {userInput} in the database.\n");
    }
    Console.Write("Please enter a college and I will return the city. (x to exit)\t");
    userInput = Console.ReadLine().ToLower();
}