def temperature_converter(celsius):
    celsius = float(celsius)
    temperature = (celsius * 9)/5 + 32
    return temperature

def windchill_calculator(temperature):
        wind_speed = 5
        for i in range(12):
            wind_chill = 35.74 + (0.6215 * temperature) - (35.75 * (wind_speed ** 0.16)) + (0.4275 * temperature) * (wind_speed ** 0.16)
            print(f"At temperature {temperature}F, and wind speed {wind_speed} mph, the windchill is {wind_chill:.2f}F ")
            wind_speed += 5

while True:
    temperature = float(input("\nWhat is the temperature? "))
    scale = input("Fahrenheit or Celsius (F/C)? ")

    scale = scale.upper()

    if scale == 'C':
        temperature = temperature_converter(temperature)
        windchill_calculator(temperature)

    else:
        windchill_calculator(temperature)

    user_choice = input("Do you want to add another value (Y/N)?")

    user_choice = user_choice.upper()

    if user_choice == 'N':
        break