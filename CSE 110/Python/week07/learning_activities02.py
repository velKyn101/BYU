import math

def compute_area_square(side):
    return compute_area_rectangle(side, side)

def compute_area_rectangle(length, height):
    area = length * height
    return area

def compute_area_circle(radius):
    area = math.pi * radius**2
    return area

def get_user_input():
    shape = input("\nType in the type of shape you want to calculate the area [square, rectangle, circle] or 'quit' to exit.\n")
    shape = shape.lower()
    if shape == 'exit':
        return shape
    
    if shape == 'square':
        side = float(input("\nWhat is the side of the square? "))
        area = compute_area_square(side)
        print(area)

    elif shape == 'rectangle':
        length = float(input("\nWhat is the length of the rectangle? "))
        height = float(input("What is the height of the rectangle? "))
        area = compute_area_rectangle(length, height)
        print(area)

    elif shape == 'circle':
        radius = float(input("\nWhat is the radius of the circle? "))
        area = compute_area_circle(radius)
        print(area)

    elif shape == 'quit':
        print("\nThanks for using our program.")

    else:
        print("\nInvalid shape entered. Please try again!")

    return shape

while True:
    shape = get_user_input()

    if shape == 'quit':
        break