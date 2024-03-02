#I changed the story to allow people to choose the place where it happens and added the reaction of the family.
#Let's build a MadLib program.
#To begin we will ask for informations and store them in variables.
print("Please, enter the following:\n")
place = input("Place: ")
adjective = input("Adjective: ")
animal = input("Animal: ")
first_verb = input("Verb: ")
exclamation = input("Exclamation: ")
family_verb = input("Verb: ")
middle_verb = input("Verb: ")
last_verb = input("Verb: ")
#Now that we have all the informations we need, let's start to build our story.
#To do it in a way that it looks like a story we will use "\n" to break lines.
output = f'\nThe other day, I was really in trouble. It all started when i went to the {place}. \nThere I saw a very {adjective} {animal} {first_verb} down the hallway. "{exclamation.capitalize()}!" I yelled. \nMy family started to {family_verb} but all I could think to do was to {middle_verb} over and over. \nMiraculously, that caused it to stop, but not before it tried to {last_verb}\nright in front of my family.\n'
print(output)