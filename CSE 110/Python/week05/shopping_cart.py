#The user can add more from the same items at the same time (check line 21-31)
user_choice = -1

#creating the lists to store the names and prices.

shopping_cart = []
item_prices = []


while user_choice != 5:
    user_choice = int(input("Please select the number that matches your choice:\n1. Add item\n2- View cart\n3- Remove item\n4- Compute total\n5- quit\n"))
    #creating the variable for computing the total price
    total_sum = 0
    count = 1
    #creating a switch case for each possible choice.
    match user_choice:
        #Adding items to the cart.
        case 1:
            item = input("\nWhat item would you want to add? ")
            price = float(input(f"What is the price of {item}? $"))
            quantity = int(input(f"How many {item}s would you want to add?"))
            while count <= quantity:
                shopping_cart.append(item)
                item_prices.append(price)
                count += 1
            if count > 0:    
                print(f"'{quantity} {item.capitalize()}s were added to the cart'")
                print()
            else:
                print(f"'{quantity} {item.capitalize()} was added to the cart'")
                print()
        
        #Viewing the cart.
        case 2:
            print("\nThe content of the cart is: ")
            for index in range(len(shopping_cart)):
                print(f"{index + 1}. {shopping_cart[index]} - ${item_prices[index]:.2f}")
            print()

        #Removing items from the cart.
        case 3:
            print("\nYour cart has the following items:")
            for index in range(len(shopping_cart)):
                print(f"{index + 1}. {shopping_cart[index]}")
            remove_item = int(input("Choose the index of the item you want to remove: "))
            shopping_cart.pop(remove_item - 1)
            item_prices.pop(remove_item - 1)

        #Computing the total price of the items.
        case 4:
            for price in item_prices:
                total_sum += price
            print(f"\nThe total price of the items in the shopping cart is: ${total_sum:.2f}\n")