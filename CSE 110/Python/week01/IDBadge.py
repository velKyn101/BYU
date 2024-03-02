#let's generate an ID Card
print("-----------------------------------------------------------------------------")
#first, we need to gather informations such as name, hair color, email, phone, etc)
print("Welcome to your ID Badge Generator!\nPlease submit the following informations: ")

#Here we start to ask the user to input informations required for generating ther ID Card

first = input("First name: ")
last = input("Last name: ")
hair = input("Hair color: ")
eyes = input("Eyes color: ")
month = input("Month of beginning: ")
training = input("Did you completed your training? ")
email = input("Email Address: ")
phone = input("Phone number: ")
job = input("Job Title: ")
id= input("ID Number: ")

#Now that we gather all information needed we are able to generate their ID

print("Your ID Card is:")
print("-----------------------------------------------------------------------------")
#First we made sure that their last name is all in upper case and the first name is capitalized
print(f'{last.upper()}, {first.capitalize()}')

#Now we certify that their job is in title case, this means that the first letter of each word will be capitalized.
print(f'{job.title()}')

#now we just print their ID Number
print(f'ID: {id}\n')

#Printing their email in lower case
print(email.lower())
#printing their phone number
print(phone)
#Here comes the catch, we will print their hair color and eyes in the same line and the month of beginning and training in other line. To organize, the second collumn have to be alligned. To do this we manipulate the first collumn to occupy 25 spaces (which is more than we need) by using ":<x" where x equals the number os spaces our array will occupy. Using it in both lines will grant that our second collumn will start at the 26th space.
print(f"{'Hair: ' + hair.capitalize():<25} Eyes: {eyes.capitalize()}")
print(f"{'Month: ' + month.capitalize():<25} Training: {training.capitalize}")
print("-----------------------------------------------------------------------------")