shopping_list = []

shopping_item = ""

print("Please enter the items of the shopping list (type quit to finish): ")
while True:
    shopping_item = input("Item: ")

    if shopping_item != "quit":
        shopping_list.append(shopping_item)
        continue

    else: 
        break

print("\nThe shopping List is:")

for itens in shopping_list:
    print(itens)

print("\nThe shopping list with indexes:")

for i in range(len(shopping_list)):
    item = shopping_list[i]
    print(f"{i}. {item}")

index = int(input("\nWhich item would you want to change? "))
new_item = input("What is the new item? ")

shopping_list[index] = new_item

print("\nThe new shopping list with indexes is: ")
for i in range(len(shopping_list)):
    item = shopping_list[i]
    print(f"{i}. {item}")