friend_names = []

name = ""

while True:
    name = input("Type the name of a friend: ")
    if name != "end":
        friend_names.append(name)
        continue

    else:
        break

print("your friends are:")

for names in friend_names:
    print(names)