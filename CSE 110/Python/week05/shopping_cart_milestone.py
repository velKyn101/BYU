user_choice = -1
shopping_cart = []

while user_choice != 5:
    user_choice = int(input("Please select the number that matches your choice:\n1. Add item\n2- View cart\n3- Remove item\n4- Compute total\n5- quit\n"))
    if user_choice == 1:
        item = input("What item would you want to add? ")
        shopping_cart.append(item)  
        print(f"'{item} was added to the cart'")
        print()
    
    elif user_choice == 2:
        print("The content of the cart is: ")
        for item in shopping_cart:
            print(item)
        print()

    elif user_choice == 3:
        print("Your cart has the following itens:")
        for index in range(len(shopping_cart)):
            print(f"{index}. {shopping_cart[index]}")
        remove_item = int(input("Choose the index of the item you want to remove: "))
        shopping_cart.pop(remove_item)

    
            
