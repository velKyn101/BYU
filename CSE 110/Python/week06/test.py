import csv

with open("week06/life-expectancy.csv") as dashboard:
    reader = csv.DictReader(dashboard)
    data = list(reader)

    max_drop = 0

    for i in range(1, len(data)):
        prev_live_expectancy = float(data[i-1]['Life expectancy (years)'])
        current_life_expectancy = float(data[i]['Life expectancy (years)'])
        drop = prev_live_expectancy - current_life_expectancy

        if data[i-1]['Entity'] == data[i]['Entity']:
            if drop > max_drop:
                max_drop = drop
                max_drop_year = data[i]['Year']
                max_drop_country = data[i]['Entity']

    print(f"The overall highest drop in life expectancy based on the database is {max_drop} which occured in {max_drop_country} in the year of {max_drop_year}")
        
