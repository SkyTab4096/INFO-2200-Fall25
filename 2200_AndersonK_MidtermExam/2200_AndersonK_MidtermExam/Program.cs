/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: October 14, 2025
Participation or Assignment #: Midterm
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

using System.Runtime.CompilerServices;

// Create a dictionary in the global scope that will contain the currency name as the key and the contents of the currencies.txt file as the value
Dictionary<string, string[]> currencyDict = [];

// Call the main method of the project
main();

// Define a method that contains the code that only runs at the start of the program
string? initialize()
{
    // Displays the title of the console app
    Console.WriteLine("Welcome to Kory's currency symbol lookup!");

    // Provides instructions to the user on how to utilize the app, then store the value the user enters
    Console.WriteLine("Currency Name (x to exit)\t");
    string? userInput = Console.ReadLine()?.ToLower();

    // Call the method to fill the currency dictionary
    readFile("currencies.txt");

    // Return the value the user enters to the main method
    return userInput;
}

// Define the method to read the contents of the currencies.txt file and store it in the currencyDict
void readFile(string file)
{
    // Create a new streamreader object that will read the contents of the currencies.txt file, then void the first line of the file
    StreamReader reader = new(file);
    reader.ReadLine();

    // Start a loop that will iterate until we read the end of the file
    while (!reader.EndOfStream)
    {
        // Create a potentially null string that is the contents of the current line of the file
        string? line = reader.ReadLine();
        // Check to see if the line was null, if it was move onto the next line
        if (line is null) continue;
        // Create a new string array that will contain the contents of the file, split by the ; in the line
        string[] tempCurrencies = line.Split(';');
        // Store the name of the currency as a seperate variable
        string currency = tempCurrencies[0];
        // Add the contents of the file to the dictionary with the name as the key and the string array as the value
        currencyDict.Add(currency.ToUpper(), tempCurrencies);
    }
    // Close the streamreader
    reader.Close();
}

// Define the main method of the project
void main()
{
    // Run the initialization method and store the contents of what the user entered
    string? userInput = initialize();
    // Check to make sure that what the user entered is not the escape character and that they actually entered something
    while (userInput != "x" && userInput is not null)
    {
        // Attempt to get the value from the from the dictionary as a string array
        if (currencyDict.TryGetValue(userInput.ToUpper(), out string[]? currency))
        {
            // If the value the user entered was in the dictionary as a key, display the currency symbol.
            Console.WriteLine($"The symbol for {userInput} is {currency[2]}");
        }
        else
        {
            // If the value the user entered was not in the dictionary as a key, display an error message to the user
            Console.WriteLine($"Could not find {userInput} in the database");
        }
        // Redisplay the intructions to the user, and reget a value from the user
        Console.Write("Currency Name (x to exit)\t");
        userInput = Console.ReadLine()?.ToLower();
    }
}