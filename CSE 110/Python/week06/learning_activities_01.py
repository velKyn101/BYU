with open("week06\kbooks.txt") as books:
    for book in books:
        book = book.strip()
        print(book)