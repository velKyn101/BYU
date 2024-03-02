import time
#It asks the name of the player and i'm using the time function to put delay in presenting the options.

# Introduction
name = input("Welcome, may I know your name? ")
print(f"Welcome {name} to the mysterious island! You find yourself stranded on a deserted island, with no idea how you got here.")
print("You see two paths ahead of you. One leads to the forest and the other to the beach. Which one do you want to take?")
time.sleep(1)
print("Type FOREST or BEACH to choose your path.")

# Path choice
path = input().lower()
if path == "forest":
    print("You walk along the forest path until you come across a river. Do you want to SWIM across, FOLLOW the river or REST?")
    time.sleep(1)
    print("Type SWIM, FOLLOW or REST to choose your next action.")
    
    # River choice
    river_choice = input().lower()

    if river_choice == "swim":
        print("You dive into the river and start swimming. But you soon realize that the current is too strong.")
        print("You are quickly swept downstream and over a waterfall. You didn't make it. GAME OVER.")
    
    elif river_choice == "follow":
        print("You follow the river until you come across a small village. The villagers welcome you and give you food and shelter.")
        print("You live the rest of your life on the island, content and happy. YOU WON!")
    
    elif river_choice == "rest":
        print("You are very tired and decide to take a quick nap under a tree. While sleeping you are attacked by an wild bear, you try to fight but you fail. GAME OVER!")
    
    else:
        print("Invalid choice. Please try again.")
        
elif path == "beach":
    print("You walk along the beach until you come across a cave. Do you want to ENTER the cave or CLIMB the nearby hill?")
    time.sleep(1)
    print("Type ENTER or CLIMB to choose your next action.")
    
    # Cave choice
    cave_choice = input().lower()
    if cave_choice == "enter":
        print("You enter the dark cave and soon realize that it's a dead end. You are trapped!")
        print("You starve to death, alone in the darkness. GAME OVER.")
    
    elif cave_choice == "climb":
        print("You climb to the top of the hill and see a ship in the distance. You light a signal fire and are rescued!")
        print("You return home, relieved and grateful. YOU WON!")
    
    else:
        print("Invalid choice. Please try again.")

else:
    print("Invalid choice. Please try again.")

