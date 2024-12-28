# Library Management Application

This is a simple library management application developed using C# and Microsoft Access. The primary goal of this project is to demonstrate database operations by utilizing custom classes. The application features a user-friendly interface for managing books in a library.

## Features
* Book Management: Add, update, delete, and list books.
* Database Integration: Uses Microsoft Access to store book information.

## Database Structure
* The application uses an Access database with a single table.
* Books table with columns;
  - ID (Primary Key, Auto-incremented)
  - BookName (Text)
  - BookAuthor (Text)

## Custom Classes
* Books: Represents the properties of a book.
* BooksDB: Handles database operations for books.

## Interactive UI
* Textboxes for entering book details (ID, Name, Author).
* Buttons for various operations (Add, Update, Delete, List).
* DataGridView to display the list of books.

## Functionality
* List Books: Clicking the List button retrieves all books from the database and displays them in the DataGridView.
* Add Book: Enter the book name and author in the respective textboxes, then click the Add button to save the book to the database. The DataGridView is automatically updated to reflect the changes.
* Update Book: Double-click on a cell in the DataGridView to populate the textboxes with the book's details.
Modify the book's name or author (ID is non-editable) and click the Update button to save the changes.
* Delete Book: Select a book from the DataGridView and click the Delete button to remove it from the database.

## Requirements
* Visual Studio 2022 (or later)
* Microsoft Access
* .NET Framework

![1](https://github.com/user-attachments/assets/9cd63b42-a7b0-4c79-a782-472b6f28635a)

![2](https://github.com/user-attachments/assets/7fcb6496-582c-4886-b1aa-e2e0d7a4f5ae)

![3](https://github.com/user-attachments/assets/3231627a-996d-4e75-a7c5-eb2ad3441820)

![4](https://github.com/user-attachments/assets/4c0270a4-8c6e-48a9-809d-51a191174ff1)

![5](https://github.com/user-attachments/assets/0f9ad45e-9941-4522-91d0-76069346de69)

