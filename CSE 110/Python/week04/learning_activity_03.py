favorite_letter = input("What is your favorite letter? ")

word = "commitment"

for letter in word:
    if letter == favorite_letter:
        print("_", end='')
    
    else:
        print(letter, end='')