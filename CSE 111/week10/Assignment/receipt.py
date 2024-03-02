import csv
import os
from datetime import datetime, date

def read_dictionary(filename, key_column_index):
    compound_dict = {}
    with open(os.path.join(os.path.dirname(__file__), filename), newline='') as file:
        reader = csv.reader(file)
        next(reader)  # Skip the header row
        for row in reader:
            key = row[key_column_index]
            try:
                price = float(row[2])
            except ValueError:
                # Handle the case where the price cannot be converted to float
                print(f"Skipping row with invalid price: {row}")
                continue
            value = [row[0], row[1], price]
            compound_dict[key] = value
    return compound_dict

def main():
    try:
        # Step 1: Call the read_dictionary function
        products_dict = read_dictionary('products.csv', 0)



        # Step 2: Print the products_dict
        #print("\nProducts Dictionary:")
        #for key, value in products_dict.items():
            #print(f"{key}: {value}")

        # Step 3: Open the request.csv file for reading
        with open(os.path.join(os.path.dirname(__file__), 'request.csv'), newline='') as request_file:
            request_reader = csv.reader(request_file)
            next(request_reader)  # Skip the header row

            ordered_items = []  # To store ordered items for later printing
            total_items = 0
            subtotal = 0

            # Step 4: Process each row in the request.csv file
            for row in request_reader:
                product_number = row[0]


                product_info = products_dict[product_number]
                product_name = product_info[1]
                product_price = product_info[2]
                requested_quantity = int(row[1])

                # Update totals
                total_items += requested_quantity
                subtotal += product_price * requested_quantity

                # Append ordered item for later printing
                ordered_items.append(f"{product_name}: {requested_quantity} units")
            
            # Step 5: Print the store name
            print("Inkom Emporium")

            # Step 6: Print the list of ordered items
            print("\nOrdered Items:")
            for item in ordered_items:
                print(item)

            # Step 7: Print the number of ordered items
            print("\nTotal Ordered Items:", total_items)
            
            current_day = date.today()

            if current_day.weekday() == 1 or current_day.weekday() == 2:
                subtotal = subtotal - (subtotal * 0.1)
                print("Subtotal: ${:.2f}".format(subtotal))

            else:
                # Step 8: Print the subtotal
                print("Subtotal: ${:.2f}".format(subtotal))

            # Step 9: Compute and print the sales tax amount
            sales_tax_rate = 0.06  # 6% sales tax
            sales_tax = subtotal * sales_tax_rate
            print("Sales Tax (6%): ${:.2f}".format(sales_tax))

            # Step 10: Compute and print the total amount due
            total_due = subtotal + sales_tax
            print("Total Amount Due: ${:.2f}".format(total_due))

            # Step 11: Print a thank you message
            print("\nThank you for shopping with us!")

            # Step 12: Print the current date and time
            current_datetime = datetime.now().strftime("%a %b %d %H:%M:%S %Y")
            print(current_datetime)

    except FileNotFoundError:
        print("[Errno 2] File not found. Please check the file paths.")
    except KeyError as e:
        print(f"Error: unknown product ID in the request.csv file {e}")

if __name__ == "__main__":
    # Step 13: Call the main function
    main()