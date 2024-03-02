#creating an area calculator

import math

#area of the square
square_length = float(input('What is the length of the side of the square? '))
print(f'The area of the square is {square_length ** 2}')

#area of the rectangle
rectangle_length = float(input('What is the legth of the rectangle? '))
rectangle_width = float(input('What is the width of the rectangle? '))
print(f'The area of the rectangle is {rectangle_length * rectangle_width}')

#area of the circle using 'pi' from the math library
circle_radius = float(input('What is the radius of the circle? '))
circle_area = math.pi * (circle_radius ** 2)
print(f'The area of the circle is {circle_area}')