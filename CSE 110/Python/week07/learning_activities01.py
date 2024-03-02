def display_regular(phrase):
    print(phrase)

def display_uppercase(phrase):
    print(phrase.upper())

def display_lowercase(phrase):
    print(phrase.lower())

message = input("What is your message? ")

display_regular(message)
display_uppercase(message)
display_lowercase(message)