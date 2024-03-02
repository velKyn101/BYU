#I created functions to improve my writing.
import random

def generate_hint(magic_word):
    hint = ""
    for i in magic_word:
        hint += "_"
    
    return hint.strip()

def is_guess_correct(guess, magic_word):
    return guess.lower() == magic_word

def provide_hint(guess, magic_word):
    hint = ""
    for i in range(len(magic_word)):
        if guess[i].lower() == magic_word[i]:
            hint += magic_word[i].upper() + "_"
        
        elif guess[i].lower() in magic_word:
            hint += guess[i].lower() + "_"
        
        return hint.strip()

print("Welcome to the magic word game!")

words = ("wizard", "lion", "leopard", "dog", "cat", "temple", "apostle", "prophet", "missionary")

magic_word = random.choice(words)

guess_count = 0

hint = generate_hint(magic_word)

keep_playing = "yes"

while keep_playing == "yes":
    while True:

        print(f"Your hint is: {hint}")
        guess = input("What is your guess? ").lower()
    
        guess_count += 1

        if len(guess) != len(magic_word):
            print("Sorry, the guess must have the same number of letters as the secret word.")
            guess_count += 1
            continue


        if is_guess_correct(guess, magic_word):
            print("Congratulations, you guessed it!")
            print(f"It took you {guess_count} guesses.")
            break
        
        else:
            print("Your guess was not correct!")
            hint = provide_hint(guess, magic_word)
            print(hint)
            continue

    keep_playing = input("Do you want to keep playing? ")

print("Thank you for playing!")