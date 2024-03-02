#importing the math library

import math

#ask for the values of items and boxes.

itens = int(input("Enter the number of items: "))
itens_boxes = int(input("Enter the number of boxes: "))

#Use math.ceil to know how many boxes we need.

num_boxes = math.ceil(itens / itens_boxes)

#Printing the results.

print(f"For {itens} items, packing {itens_boxes} items in each box, you will need {num_boxes} boxes.")