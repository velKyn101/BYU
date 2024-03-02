import random

looping = "yes"

print("Welcome to magic number, you have to guess what is the number chosen by the CPU. Have fun!")

while looping == "yes":
    magic_number = random.randint(1, 100)

    guess_counter = 0

    guess = 0

    while guess != magic_number:
        guess = int(input("What is your guess? "))

        guess_counter += 1

        if guess > magic_number:
            print("Lower")

        elif guess < magic_number:
            print("Higher")

        else:
            print("You guessed it!")
    print(f"It took you {guess_counter} guesses.\n")

    looping = input("Do you want to keep playing? (Type [yes] or [no])")

print("Thank you for playing!")