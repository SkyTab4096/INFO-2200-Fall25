/*
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: Insert date submitted
Participation or Assignment #: 01
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
*/

Console.WriteLine("Welcome to Kory's State Capital Lookup App"); // display title text
Console.WriteLine(); // blank line

Console.Write("Please enter a state and I will return the capital (x to exit): "); // prompt the user for input
string userInput = Console.ReadLine().ToLower(); // assign console input to a string variable and convert to lower case

Dictionary<string, string> stateCapDict = new Dictionary<string, string>(); // create a dictionary containing two string values

StreamReader reader = new StreamReader("statecaps.txt"); // create a StreamReader object and assign it the input file

//reader.ReadLine();

// loop to read in the contents of the file until end of stream
while (!reader.EndOfStream)
{
    string line = reader.ReadLine(); // returns line as a string
    string[] tempstatecaps = line.Split(',');
    string state = tempstatecaps[0];
    string capital = tempstatecaps[1];
    stateCapDict.Add(state.ToUpper(), capital.ToUpper()); // not title case, convert State to all caps as the key
}

reader.Close();

// loop to continue while user input is not equal to lowercase x
while (userInput != "x")
{
    // call the TryGetValue() method
    if (stateCapDict.TryGetValue(userInput.ToUpper(), out string cap))
    {
        Console.WriteLine(); // display blank line
        Console.WriteLine($"State: {userInput}"); // display print value of userInput variable
        Console.WriteLine($"Capital: {cap}"); // display print value of cap variable
        Console.WriteLine(); // display blank line
    }
    else
    {
        Console.WriteLine($"Could not find {userInput} in the database"); // display error message
        Console.WriteLine(); // display blank line
    }
    Console.Write("Please enter a state and I will return the capital (x to exit): "); // prompt for secondary read
    userInput = Console.ReadLine().ToLower(); // secondary read
}