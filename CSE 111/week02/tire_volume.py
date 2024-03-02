#import math.py to use pi
import math
from datetime import datetime

# Get the current date
current_date = datetime.now().strftime("%Y-%m-%d")

#Printing what this program does.

print("This program computes and outputs the")
print("volume of a car tire in United States.")

#prompting the user for width, aspect ratio and diameter's values.

width = float(input("Enter the width of the tire in mm (ex 205): "))
aspect_ratio = float(input("Enter the aspect ratio of the tire (ex 60): "))
diameter = float(input("Enter the diameter of the wheel in inches (ex 15): "))

#Designating new names for the variables to shorten the formula and make it easier to read.

w = width
a = aspect_ratio
d = diameter

#Formula

volume = (math.pi * (w ** 2) * a * (w * a + 2540 * d)) / 10000000000

#Printing the result

print(f"The approximate volume is {volume:.2f} liters.")

data = f"{current_date}, {width}, {aspect_ratio}, {diameter}, {volume:.2f}"

while True:
    want_to_buy = input("Would you like to buy tires with these dimensions? (Y - yes; N - no)").strip().upper()

    if want_to_buy == "Y":
        phone_number = input("Please, type in your phone number so we can contact you and offer the best prices: ")
        with open('volumes.txt', 'at') as file:
            file.write(f"{data}, {phone_number}\n")
        break
    elif want_to_buy == "N":
        with open('volumes.txt', 'at') as file:
            file.write(f"{data}\n")
        break
    else:
        print("Invalid option. Type 'Y' for yes or 'N' for no.")