#The program identify the year and country that has the largest drop from one year to the next and allow the user to type in a country, then show the minimum, maximum, and average life expectancy for that country. 
import csv

with open("week06/life-expectancy.csv") as database:
    reader = csv.DictReader(database)
    data = list(reader)
    
    country_expectancy = 0
    max_drop = 0
    selected_min_country_year = 0
    selected_max_country_year = 0
    min_country_expectancy = 999
    max_country_expectancy = 0
    max_life_expectancy = 0
    min_life_expectancy = 999
    overall_max_country = ''
    overall_max_year = 0
    overall_min_country = ''
    overall_min_year = 0
    total_expectancy = 0
    selected_expectancy = 0
    count = 0
    selected_max_country = ''
    selected_max_expectancy = 0
    selected_min_country = ''
    selected_min_expectancy = 999
    selected_count = 0
    selected_max_year = 0
    selected_min_year = 0

    selected_year = input("What is the year of interest? ")
    selected_country = input("What is the country of interest? ").capitalize()


    #Checking if we can find the overall max life expectancy drop

    for i in range(1, len(data)):
            prev_live_expectancy = float(data[i-1]['Life expectancy (years)'])
            current_life_expectancy = float(data[i]['Life expectancy (years)'])
            drop = prev_live_expectancy - current_life_expectancy

            #Certifying that we are comparing the same country.

            if data[i-1]['Entity'] == data[i]['Entity']:
                if drop > max_drop:
                    max_drop = drop
                    max_drop_year = data[i]['Year']
                    max_drop_country = data[i]['Entity']

    for record in data:
        country = record['Entity']
        year = record['Year']
        expectancy = float(record['Life expectancy (years)'])


        #Check the overall min life expectancy

        if expectancy < min_life_expectancy:
                    min_life_expectancy = expectancy
                    overall_min_country = country

                    overall_min_year = year

        #Overall max life expectancy

        if expectancy > max_life_expectancy:
                max_life_expectancy = expectancy

                overall_max_country = country

                overall_max_year = year

        #Let's use the selected country.

        if selected_country == record['Entity']:
            country_expectancy = expectancy
            selected_expectancy += expectancy
            selected_count += 1

            if country_expectancy > max_country_expectancy:
                max_country_expectancy = country_expectancy
                selected_max_country_year = year

            if country_expectancy < min_country_expectancy:
                min_country_expectancy = country_expectancy
                selected_min_country_year = year


        #selected year

        if year == selected_year:
            total_expectancy += expectancy
            count += 1
            
            #Finding the max expectancy from the selected year
            if expectancy > selected_max_expectancy:
                selected_max_expectancy = expectancy
                selected_max_country = country

                selected_max_year = year

            #Finding the max expectancy from the selected year

            if expectancy < selected_min_expectancy:
                selected_min_expectancy = expectancy

                selected_min_country = country

                selected_min_year = year

    if selected_count == 0:
        average_country_expetancy = 0

    else:
        average_country_expetancy = selected_expectancy / selected_count

        
    if count == 0:
        average_expectancy = 0

    else:
        average_expectancy = total_expectancy / count
        
    print(f"\nThe overall max life expectancy is {max_life_expectancy} from {overall_max_country} in {overall_max_year}.")
    print(f"The overall min life expectancy is {min_life_expectancy} from {overall_min_country} in {overall_min_year}.")
    print(f"The overall max drop in life expectancy based on the database is {max_drop:.3f} which occured in {max_drop_country} in the year of {max_drop_year}")

    #Now let's do it for the year of interest.

    print(f"\nFor the year {selected_year}:")
    print(f"The average life expectancy across all countries was {average_expectancy:.3f}")
    print(f"The max life expectancy was in {selected_max_country} with {selected_max_expectancy}")
    print(f"The min life expectancy was in {selected_min_country} with {selected_min_expectancy}")

    #For the selected country
    print(f"\nFor the country {selected_country}")
    print(f"The average life expectancy is {average_country_expetancy:.3f}")
    print(f"The max life expectancy was in {selected_max_country_year} with {max_country_expectancy}")
    print(f"The min life expectancy was in {selected_min_country_year} with {min_country_expectancy}\n")