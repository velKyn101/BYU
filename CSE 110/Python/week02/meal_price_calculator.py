#Using the math library I added the option to donate the cents of the change to charity.
import math

#Let's make a meal price calculator.

#Let's start by prompting the user the values of the meals
childs_meal_price = float(input("What is the price of a child's meal? "))
adult_meal_price = float(input("What is the price of a adult's meal? "))

#Now we need to now how many children and adults there are
children_number = int(input("How many children are there? "))
adults_number = int(input("How many adults are there? "))

#The last information we need is the sales tax rate
sales_tax_rate = float(input("What is the sales tax rate? "))

#Now that we gathered all informations needed let's calculate.
subtotal = (childs_meal_price * children_number) + (adult_meal_price * adults_number)
print(f"\nSubtotal: ${subtotal:.2f}")

#Now we need to add the sales tax
sales_tax = (sales_tax_rate / 100) * subtotal
print(f"Sales tax: ${sales_tax:.2f}")

#And the total cost
total = sales_tax + subtotal
print(f'Total: ${total:.2f}')

#Now we ask if they want to donate the cents to charity. Based on the answer we will calculate the total.
payment_amout = float(input('\nWhat is the payment amount? '))

choice = int(input("Do you want to donate the cents to charity?\n1- Yes\n2- No\n"))
if choice == 1:
    total = math.floor(total)
    change = payment_amout - total
    print(f"\nChange: ${change:.2f}\n")


else:
    change = payment_amout - total
    print(f"\nChange: ${change}\n")