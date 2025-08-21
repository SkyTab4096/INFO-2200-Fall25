#!/usr/bin/env python3

'''
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: 
Participation or Assignment #: 01
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
'''

def initialize(): # Defines a function to initialize the program
    with open('M01/statecaps.txt', "r", newline="") as file: # Opens the statecaps.txt file
        states = file.readlines() # Stores the contents of the file
    states.pop(0) # Removes the first line of the file that was the header
    statesCaps = [] # Defines an empty array to store the states with their capital as a 2 dimentional array
    for state in states: # Starts a loop to iterate for every state in the file
        stateCap = state.split(",") # Splits the string containing the state and it's capital into multiple strings
        capital = stateCap[1].split("\n") # Stores specifically the capital of the state without the new line marker
        stateCap[1] = capital[0] # Redefines the capital in the array with the state as the capital without the new line marker
        statesCaps.append(stateCap) # Adds the array with the state and capital into a master array that stores all states
    return statesCaps # Returns the master array to the main function of the program

def main(): # Defines the main function of the program
    statesCaps = initialize() # Gets the master array from the initialization function
    print(f"Welcome to Kory's State Capital Lookup App") # Displays a welcome message to the user
    stateCheck = "" # Initializes the variable that will store the state the user wants the capital of
    while stateCheck.lower() != "x": # Checks to make sure that the user hasn't entered the command to exit the program
        stateCheck = input("Please enter a state and I will return the capital (x to exit)  ") # Gets the state that the user wants to find the capital of
        capital = '' # Initializes and clears any stored capital in a variable

        for row in statesCaps: # For every row in the master array, run the following test
            if str(row[0]).lower() == stateCheck.lower(): # Check to see if the state matchs the state the user wants to find the capital of
                state = row[0] # Stores the state of the matching state, important because then the state on the output will be capitalized
                capital = row[1] # Stores the capital of the state
            
        if capital == '' and stateCheck.lower() != "x": # Checks to see if a capital was found and makes sure that the exit command was not given
            print(f"Could not find {stateCheck} in the database.\n") # Displays an error message to the user
        elif stateCheck.lower() != "x": # Makes sure that the exit command wasn't given
            print(f"\nState: {state}") # Display the state
            print(f"Capital: {capital}\n") # Display the capital of the state
    print("Bye!") # Display an exit message


if __name__ == "__main__": # checks whether the current module is being run as the main module; if so, it calls the main() function. otherwise, it does not call the main() function; this lets other programs import this module without running the main() function
    main() # Calls the main function of the program
