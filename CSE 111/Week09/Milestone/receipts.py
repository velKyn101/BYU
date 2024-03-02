import csv
import os

def read_dictionary(filename, key_column_index):
    compound_dict = {}
    with open(os.path.join(os.path.dirname(__file__), filename), newline='') as file:
        reader = csv.reader(file)
        headers = next(reader)  # Skip the header row
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
    # Step 1: Call the read_dictionary function
    products_dict = read_dictionary('products.csv', 0)

    # Step 2: Print the products_dict
    print("Products Dictionary:")
    for key, value in products_dict.items():
        print(f"{key}: {value}")

    # Step 3: Open the request.csv file for reading
    with open(os.path.join(os.path.dirname(__file__), 'request.csv'), newline='') as request_file:
        request_reader = csv.reader(request_file)
        next(request_reader)  # Skip the header row

        # Step 4: Process each row in the request.csv file
        for row in request_reader:
            product_number = row[0]

            # Check if the product number is in the products_dict
            if product_number in products_dict:
                product_info = products_dict[product_number]
                product_name = product_info[1]
                product_price = product_info[2]
                requested_quantity = int(row[1])

                # Print the product name, requested quantity, and product price
                print(f"Product: {product_name}, Quantity: {requested_quantity}, Price: ${product_price:.2f}")

if __name__ == "__main__":
    # Step 5: Call the main function
    main()
