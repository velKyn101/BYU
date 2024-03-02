#Lets make a loan calculator, first we will ask some basic questions to gather informations.

print("Answer the following questions on a scale of 1-10:\n")
loan_size = int(input("How large is the loan? "))
score = int(input("How good is your credit score? "))
income = int(input("How high is your income? "))
down_payment = int(input("How large is your down payment? "))

should_loan = False
if loan_size >= 5:
    if score >= 7 and income >= 7:
        should_loan = True

    elif score >= 7 or income >= 7:
        if down_payment >= 5:
            should_loan = True

        else:
            should_loan = False

else:
    if score < 4:
        should_loan = False

    else:
        if income >= 7 or down_payment >= 7:
            should_loan = True

        elif income >= 4 and down_payment >= 4:
            should_loan = True
        
        else:
            should_loan = False
if should_loan:
    print("The decision is yes. You should have a loan!")
else:
    print("The decision is no. You should not have a loan!")