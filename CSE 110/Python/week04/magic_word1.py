import random

# List of secret words
secret_words = ["mosiah", "nephi", "alma", "helaman", "mormon"]

# Select a random secret word
secret_word = random.choice(secret_words)

# Initialize the guess count
guess_count = 0

# Function to generate the initial hint
def generate_hint(secret_word):
    hint = ""
    for _ in secret_word:
        hint += "_ "
    return hint.strip()

# Function to display the hint
def display_hint(hint):
    print("Your hint is:", hint)

# Function to check if the guess is correct
def is_guess_correct(guess, secret_word):
    return guess.lower() == secret_word

# Function to provide the hint based on the guess
def provide_hint(guess, secret_word):
    hint = ""
    for i in range(len(secret_word)):
        if guess[i].lower() == secret_word[i]:
            hint += secret_word[i].upper() + " "
        elif guess[i].lower() in secret_word:
            hint += guess[i].lower() + " "
        else:
            hint += "_ "
    return hint.strip()

# Game loop
print("Welcome to the word guessing game!")
print()

while True:
    guess = input("What is your guess? ")

    # Check if guess has the same number of letters as the secret word
    if len(guess) != len(secret_word):
        print("Sorry, the guess must have the same number of letters as the secret word.")
        guess_count += 1
        continue

    guess_count += 1
    

    if is_guess_correct(guess, secret_word):
        print("Congratulations! You guessed it!")
        print("It took you", guess_count, "guesses.")
        break
    else:
        print("Your guess was not correct.")
        if guess_count == 1:
            hint = generate_hint(secret_word)
            display_hint(hint)
        else:
            hint = provide_hint(guess, secret_word)
            display_hint(hint)
        print()