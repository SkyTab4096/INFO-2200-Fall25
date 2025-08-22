#!/usr/bin/env python3

'''
Name: Kory Anderson
Class: INFO 2200
Section: 001
Professor: Sharp
Date: Insert date submitted
Participation or Assignment #: 01
By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
'''

def randomCollege(database):
    import random
    randomInt = random.randint(0, len(database) - 1)
    print(f"\nCollege:\t{database[randomInt][0]}")
    print(f"City:\t\t{database[randomInt][1]}\n")


def initialization():
    print("Welcome to Kory's city checker for colleges.")
    collegesCitys = []
    collegeCityDatabase = []
    fileName = "database.txt"
    with open(fileName, "r", newline="") as file:
        file.readline()
        collegesCitys = file.readlines()
    for collegeCity in collegesCitys:
        collegeCity = collegeCity.split(",")
        city = collegeCity[1]
        city = city.split("\n")
        city = str(city[0])
        collegeCity[1] = city
        collegeCityDatabase.append(collegeCity)
    return collegeCityDatabase

def main():
    database = initialization()
    collegeCheck = input("Please enter a college to find the city of. (x to exit)\t")
    city = ""
    while collegeCheck.lower() != "x":
        if collegeCheck.lower() == "random":
            randomCollege(database)
        else:
            for row in database:
                if collegeCheck.lower() == row[0].lower():
                    college = row[0]
                    city = row[1]
                    break
            if city != "":
                print(f"\nCollege:\t{college}")
                print(f"City:\t\t{city}\n")
                city = ""
            else:
                print(f"\n{collegeCheck} was not found in the database.\n")
        collegeCheck = input("Please enter a college to find the city of. (x to exit)\t")
    print("\nBye!")

if __name__ == "__main__":
    main()