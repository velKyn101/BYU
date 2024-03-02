gpa = int(input("What is your grade percentage? "))
grade = "a"
if gpa >= 90:
    grade = "A"
elif gpa >= 80 and gpa < 90:
    grade = "B"
elif gpa >= 70 and gpa < 80:
    grade = "C"
elif gpa >= 60 and gpa < 70:
    grade = "D"
else:
    grade = "F"

sign = ""
last_digit = gpa % 10

if last_digit >= 7:
    sign = "+"
elif last_digit <= 3:
    sign = "-"

if gpa >= 93:
    sign = ""

if grade == "F":
    sign = ""

print(f"Your grade is {grade + sign}")

if gpa >= 70:
    print("Congratulations! You passed the class!")
else:
    print("Try harder next semester and you will be done!")