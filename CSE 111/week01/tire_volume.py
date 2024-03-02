#import math.py to use pi
import math

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