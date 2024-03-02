#importing datetime library

from datetime import datetime

#asking for the input

subtotal = 0

loop = True

while loop == True:
    price = float(input("What is the price? "))

    if price != 0:
        quantity = int(input("Please, enter the quantity: "))
        subtotal += price * quantity
    
    else:
        print()
        loop = False

#Now let's check the day of the week using the .now() method.

current_date_and_time = datetime.now()

day_of_week = current_date_and_time.weekday()

#Now let's go to the logic part

#let's compare the day and the value to see if it fits in our parameters.

if day_of_week == 1 or day_of_week == 2:

    if subtotal > 50.00:

        discount = subtotal * 0.1
        subtotal -= discount
        sales_tax = subtotal * 0.06
        amount_due = subtotal + sales_tax
        amount_due = round(amount_due, 2)
        print(f"Your subtotal is {subtotal:.2f}$")
        print(f"Discount amount: {discount:.2f}$")
        print(f"Sales tax amount: {sales_tax:.2f}$")
        print(f"Total: {amount_due}$")
        print()

    else:
        sales_tax = subtotal * 0.06
        amount_due = subtotal + sales_tax
        amount_due = round(amount_due, 2)
        lacking = 50 - subtotal
        print(f"In order to receive the discount you have to buy {lacking:.2f}$")
        print()
        print(f"Your subtotal is {subtotal:.2f}$")
        print(f"Sales tax amount: {sales_tax:.2f}$")
        print(f"Total: {amount_due}")
        print()

else:
    sales_tax = subtotal * 0.06
    amount_due = subtotal + sales_tax
    amount_due = round(amount_due, 2)
    print(f"Your subtotal is {subtotal:.2f}$")
    print(f"Sales tax amount: {sales_tax:.2f}$")
    print(f"Total: {amount_due}$")
    print()


        