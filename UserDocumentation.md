In Library Manager user starts in Menu form. There he has choices:

- Login
- Register

each option create it own new form.

LoginForm

- There user log in to application with his email and password
- there is back button which sends him back to Menu

Registration

- provide option to register user
- after successful registration message box shows up and send him back to menu
- if it was not successful message box shows up and tells what is wrong

LoggedMenuForm

- this form provides menu for logged user
- user can:
 - Create Book
 - Create Author
 - Create Publisher
 - Show Books
 - Show Borrowed Books
 - Show Profile
 - Logout

ShowProfile Form
- user can see his email and name
- back button gets him to logged menu

Create Author/Publisher/Book
- each of them provides its own form for creating this entity with specified properties
- back button gets him to logged menu
- when you want create a book the Publisher and Author must exist, you can create them

Show Books Form

- user can see all books in library
- he can filter it by author, title and availability
- he can alphabetically order it
- there are 3 buttons:
 - borrow : user borrows book, message box saying he successfully borrowed book shows up
 - Delete : user can delete book, message box saying he successfully deleted book shows up
 - Details : this take user to other form where he can see book details and edit some of them, back button gets him to all books

 Show Borrowed Books

 - user can see his borrowed books
 - there are buttons :
  - Details : user see book details without option to update them,  back button gets him to borrowed books
  - Return : user can return book, message box shows up saying return is successful
 - back button gets him to logged menu
