import time
#explaining how the game works.
print("\n\nDuring the game you will be presented to situations where you will have to choose. Some words will be in upper case, this means that they are options. When asked you just have to type the word that is in upper case. Have in mind that your choices will impact directly on the outcome of the story. Have fun, and take care.\n")
for i in range(3):
    print(". ")
    time.sleep(1)
#Let's create an adventure game. We will have a story and the player should choose between options that will be presented?
name = input("Welcome detective, may I know your name?\nType your name here: ")
#Starting with a description of the scenario.
print(f"Welcome Detective {name.capitalize()}, we are pleased to have you here. We need your help to find a missing person. Her name is Margareth Fetcher. The last time she was seen it was in a hotel. We have reasons to believe she was linked to mexican smugglers. You have to find her.\n")
print("You decide to take a look at the hotel where Margareth was last seen. You arrive at the hotel and find the front desk unoccupied. You can either SEARCH the lobby or go up to the SECOND FLOOR and investigate the rooms.\n")
choice = input("Choose your option: ")
if choice.lower == "search":
    print("You search the lobby and find a piece of torn clothing. Do you want to ASK the hotel staff about it or continue to the second floor?")
    choice.lower = input("Choose your option: ")

    if choice.lower == "ask":
        print("\nYou ask the hotel staff about the torn clothing and they tell you that it belongs to a guest who checked out the day before. Do you want to TRACK DOWN the guest or continue searching the hotel?\n")
        choice = input("Choose your option: ")
        if choice == "track down":
            print("\nYou decide to track down the clue. You discover that the guest is Margareth Fecthcer and she went to a city neaby. When you arrive there you see the face of Margareth Fetcher in every poster in the town. It turns out that she decided to quit her job and abandon her old life to start living in a circus.")











    elif choice == "2":
        print("You go up to the second floor and find two rooms: Room 201 and Room 202. Which room do you want to investigate?\n")

elif choice == "2":
    print("You go up to the second floor and find two rooms: Room 201 and Room 202. Which room do you want to investigate?\n")