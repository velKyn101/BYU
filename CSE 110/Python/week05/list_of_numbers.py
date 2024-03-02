number_list = []

number = 0

while True:
    number = int(input("Enter a list of numbers, type 0 when finished: "))

    if number != 0:
        number_list.append(number)
        continue

    else:
        break

total_sum = 0

for numbers in number_list:
    total_sum += numbers

print(f"The sum of the numbers is: {total_sum}")

index = len(number_list)
average = total_sum / index
print(f"The average is {average}")

largest_number = 0

for value in number_list:
    if value > largest_number:
        largest_number = value

print(f"The largest number {largest_number}")

smalest = 9999999999

for number in number_list:
    if number > 0 and number < smalest:
        smalest = number

print(f"The smallest positive number is {smalest}")

sorted_list = sorted(number_list)

print("The sorted list is:")
for number in sorted_list:
    print(number)