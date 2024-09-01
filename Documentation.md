## Brief assignment

Library Manager is an application for library management. It allows its users to create book/author/publisher, delete book, borrow and return book, filter books by name, author or alphabetically and by availability.

## Exact assignment

Library Manager is an winforms application developed in C# programming language for library management. Application uses Microsoft Entity Framework, MySql and AutoMapper. To access the application you need to have your own account, so you need to register. After the login you can use its features. It allows its users to create book/author/publisher, delete book, borrow and return book, filter books by name, author or alphabetically and by availability.

## Algorithm

The application works in 4 Layers: Database, Repository Layer, Business Layer and Form Layer.

Database provides models classes of database tables. In this case these are Author, User, Book, Borrowings, Publisher. It also create a database connection.

Repository Layer is determined to evaluate some query and send specific data it gets from database to Business Layer. Before it sends it map the database model to BusinessObject Model. It also store data to database, update or delete them.

Business Layer is determined to evaluate business logic and manipulate with data obtained from Repository Layer. It maps Data Transfer Objects to Business object for manipulation. It sends commands to create/update/delete entity to repository.

Form Layer is set to give user options to do specific actions mentioned in assignment. It provides UI for the interaction. There are stored forms for Menu, LoggedMenu, Registration, profile ,see books, see book details ,see borrowed books, create book/author/publisher.
Almost every form has back button which go back to previous form.

In Form layer is also Session Manager class which is Singleton representing logged user to maintain users properties when borrowing is created or user want to see his profile

## Program

Database project contains Models folder where is every model representing table in database.

```C#
 public partial class Author : IEntity<long>
 {
     public long Id { get; set; }
     public string Name { get; set; }
     public string? Email { get; set; }
 }

 public partial class Book : IEntity<long>
{
    public long Id { get; set; }
    public string Title { get; set; }
    [ForeignKey("AuthorId")]
    public long AuthorId { get; set; }
    [ForeignKey("PublisherId")]
    public long PublisherId { get; set; }
    public DateTime PublishDate { get; set; }
    public string ISBN { get; set; }
    public string AuthorName { get; set; }
    public string PublisherName { get; set; }
    public bool Available { get; set; }
}

public partial class Borrowings : IEntity<long>
{
    public long Id { get; set; }
    [ForeignKey("BookId")]
    public long BookId { get; set; }
    [ForeignKey("UserId")]
    public long UserId { get; set; }
    public DateTime BorrowDate { get; set; }
}
public partial class Publisher : IEntity<long>
 {

     public long Id { get; set; }
     public string Name { get; set; }
     public string? Email { get; set; }   
}

public partial class User : IEntity<long>
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
```

Then there is ManagerDbContext
```C#
public class ManagerDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Borrowings> Borrowings { get; set; }

    public ManagerDbContext() { }

    public ManagerDbContext(DbContextOptions<ManagerDbContext> options)
       : base(options) { }
}
```

this class inherits from DbContext so it represents session with a database.

In BusinessObjectProfile is created mapping from business objects to models and reverse.
With this mapping work with business objects and entities gets synoptical 
```C#
public class BusinessObjectsProfile : Profile
{
    public BusinessObjectsProfile()
    {
        CreateMap<Author, AuthorBO>();
        CreateMap<AuthorBO, Author>();
        CreateMap<Book, BookBO>();
        CreateMap<BookBO, Book>();
        CreateMap<Publisher, PublisherBO>();
        CreateMap<PublisherBO, Publisher>();
        CreateMap<User, UserBO>();
        CreateMap<UserBO, User>();
        CreateMap<BorrowingsBO, Borrowings>();
        CreateMap<Borrowings, BorrowingsBO>();
    }
}
```
In Migration folder are stored all migrations which were used for updating the database

 # ManagerHelpers
In ManagerHelper project are some interfaces and base classes which base for repository logic

IEntity interface is used
```C#
/// <summary>
/// Represents an entity with single-column unique ID.
/// </summary>
public interface IEntity<TKey>
{
    /// <summary>
    /// Gets or sets the unique identification of the entity.
    /// </summary>
    TKey Id { get; set; }
}
```

Irepository and Repository

The IRepository<TEntity, TKey> interface and its implementation Repository<TEntity, TKey> provide a generic repository pattern for data access in an Entity Framework context. This pattern abstracts common data operations such as CRUD (Create, Read, Update, Delete) and allows for easier testing and maintenance of data access code.

IRepository Interface
The IRepository<TEntity, TKey> interface defines the contract for the repository, specifying the essential CRUD operations. Here’s a detailed breakdown of its members:
Properties:
DbContext Context { get; set; }: Represents the database context used for performing operations.

Repository Class
The Repository<TEntity, TKey> class provides the concrete implementation of the IRepository interface. It utilizes Entity Framework to perform the defined operations and manages entity states for efficient data manipulation.
Constructor:
public Repository(IUnitOfWork unitOfWork, IMapper mapper): Initializes a new instance of the Repository class with the specified unit of work and mapper.

UnitOfWork.cs
The UnitOfWork class holds a reference to the DbContext which represents the session with the database. All CRUD operations on the database are performed through this context.
It manages the database context and transactions, allowing for coordinated commits and rollbacks of changes.


 # Repository Layer

The InterpreterRepository<TypedEntity, TEntity> class extends the generic Repository<TEntity, long> class and implements the IRepostitory<TypedEntity, long> interface. This repository pattern provides a bridge between two different representations of data: the database entities (TEntity) and business objects (TypedEntity).

Methods Implemented from IRepostitory<TypedEntity, long>:

IList<TypedEntity> GetAll(): Retrieves all entities from the base repository, maps them to business objects (TypedEntity), and sets their Model property to the corresponding database entity.

TypedEntity GetById(long id): Retrieves a single entity by its ID from the base repository, maps it to a business object, and sets the Model property to the corresponding database entity.

IList<TypedEntity> GetByIds(IEnumerable<long> ids): Retrieves multiple entities by their IDs from the base repository, maps them to business objects, and sets their Model properties to the corresponding database entities.

void Insert(TypedEntity entity): Maps the business object to a database entity and inserts it into the base repository. Updates the business object's Model property to the inserted database entity.

void Insert(IEnumerable<TypedEntity> entities): Maps a collection of business objects to database entities and inserts them into the base repository.

void Delete(TypedEntity entity): Maps the business object to a database entity and deletes it from the base repository.

void Delete(IEnumerable<TypedEntity> entities): Maps a collection of business objects to database entities and deletes them from the base repository.

void Update(TypedEntity entity, TypedEntity bo): Updates the database entity by applying non-null properties from the business object (bo) to the current entity, using the AutoMapper for property mapping. The propertiesToExclude list is used to specify properties that should not be updated.

Private Methods:

private static U UpdateEntityByNonNullProperties<T, U>(U oldEntity, T changes, IMapper mapper, IList<string> propertiesToExclude): Updates the properties of the old entity based on non-null values from the changes object. Excludes properties specified in the propertiesToExclude list and uses AutoMapper to handle type differences between properties.

Then there are repositories for each model which extends InterpreterRepository methods
Each repository provides data access methods specifically for the tis entity and its corresponding business object

BorrowingsRepository methods:
IEnumerable<BookBO> GetBorrowedBooksByUser(long userId):
long GetBorrowingByBookId(long bookId);

BookRepository methods:
 IEnumerable<BookBO> GetBooksByAuthor(long authorId);
 IEnumerable<BookBO> GetBooksByAuthor(string authorName);
 IEnumerable<BookBO> GetBooksByPublisher(long publisherId);
 IEnumerable<BookBO> GetBooksByTitle(string title);
 IEnumerable<BookBO> GetBooksByIsbn(string isbn);
 IEnumerable<BookBO> GetAllAvailable();
 IEnumerable<BookBO> GetByAuthorAndTitle(string authorName, string title);

AuthorRepository methods:
 AuthorBO GetAuthorByName(string name);
 IEnumerable<AuthorBO> GetAuthorsByName(string name);
 IEnumerable<AuthorBO> GetAuthorsByEmail(string email);

PublisherRepository methods:
 public PublisherBO GetPublisherByName(string name);
 public PublisherBO GetPublisherByEmail(string email);

UserRepository methods:
 UserBO GetByName(string name);
 UserBO GetByEmail(string email);

 # Business Layer

ManagerService
The ManagerService class provides a common set of methods for creating, reading, updating, and deleting business objects. It is designed to be extended by concrete service classes that will specify the exact types for data transfer objects, business objects, and repositories.

Generic Parameters:

DTO: The type of data transfer object used for input and output operations. Must be a class.
UpdateDTO: The type of data transfer object used specifically for updating existing records. Must be a class.
BO: The type of business object representing the core business data. Must inherit from AbstractBO.
Repository: The type of repository used for data operations. Must implement both IRepostitory<BO, long> and IInterpreterRepositoryTypedEntity<BO>.
Protected Members:

Repository _repository: An instance of the repository used for data access operations.
Constructor:

public ManagerService(IUnitOfWork unitOfWork, IMapper mapper, Repository repository): Initializes a new instance of the ManagerService class with the specified unit of work, AutoMapper instance, and repository. Calls the base class constructor with the unit of work and mapper.

The AuthorService class is designed to handle operations specific to Author entities and provide additional functionalities beyond the generic CRUD operations provided by the ManagerService base class.
Methods:

CheckAccessibility(string name, string email):
Checks if an Author can be created with the given name and email without conflicts.
Retrieves lists of authors by name and email using the repository methods GetAuthorsByName and GetAuthorsByEmail.
Returns true if there are no authors with the given name or email (i.e., the name and email are available), and false otherwise.

BookService
Methods:
GetAllAvailable():
Retrieves all available books and maps them to BookBO.

GetBooksByAuthor(string authorName):
Retrieves books by author name and returns them as a list of BookBO.

GetBooksByTitle(string title):
Retrieves books by title and returns them as a list of BookBO.

GetBooksByAuthorAndTitle(string authorName, string title):
Retrieves books by both author name and title and returns them as a list of BookBO.

Borrow(long bookId):
Marks a book as unavailable and updates it in the repository.

Return(long bookId):
Marks a book as available and updates it in the repository.

CheckAccessibility(string title, string isbn):
Checks if a book with the given title or ISBN already exists.

PublisherService
Methods:


Borrow(long bookId, long userId):
Creates a new borrowing record with the current date.
Calls _bookService.Borrow(bookId) to mark the book as borrowed.
Commits the transaction to save changes.

GetBorrowedBooks(long userId):
Retrieves a list of books borrowed by a specific user.
Uses the repository method GetBorrowedBooksByUser to get the list and maps it to BookBO.

Return(long bookId):
Calls _bookService.Return(bookId) to mark the book as available.
Retrieves the borrowing record ID using GetBorrowingByBookId from the repository.
Deletes the borrowing record and commits the transaction.

PublisherService
Methods:

CheckExistingPublisherByName(string name):
Checks if a publisher with the specified name already exists.
Returns true if no publisher with that name exists, false otherwise.

CheckExistingPublisherByEmail(string email):
Checks if a publisher with the specified email already exists.
Returns true if no publisher with that email exists, false otherwise.

UserService
Methods:

Register(UserDTO.Create dto):
Registers a new user by calling Create and committing the changes to the database.

Login(UserDTO.Login dto):
Retrieves a user by email to facilitate login.
Returns the user object if found.

CheckName(string name):
Checks if a user with the specified name already exists.
Returns true if no user with that name exists, false otherwise.

CheckEmail(string email):
Checks if a user with the specified email already exists.
Returns true if no user with that email exists, false otherwise.

CheckLogin(string email, string password):
Verifies user credentials during login.
Returns true if the user with the given email exists and the password matches, false otherwise.

DataTransferObjectProfile.cs
The DataTransferObjectProfile class is an implementation of the Profile class from AutoMapper. It defines mappings between various Data Transfer Objects (DTOs) and Business Objects (BOs) for the application's data layer.

Data Transfer Objects:

```c#
public class AuthorDTO
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string? Email { get; set; }
    [JsonIgnore]
    public ICollection<Book>? Books { get; set; }

    public class Create
    {
        public string Name { get; set; }
        public string? Email { get; set; }
    }

    public class Update
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}

 public class BookDTO
 { 
     public long Id { get; set; }
     public string Title { get; set; }
     public long AuthorId { get; set; }
     public long PublisherId { get; set; }
     public DateTime PublishDate { get; set; }
     public string ISBN { get; set; }
     public string AuthorName { get; set; }
     public string PublisherName { get; set; }
     public bool Available { get; set; } = true;

     public class Create
     {
         public string Title { get; set; }
         public string AuthorName { get; set; }
         public long? AuthorId { get; set; }
         public string PublisherName { get; set; }
         public long? PublisherId { get; set; }
         public DateTime PublishDate { get; set; }
         public string ISBN { get; set; }
         public bool Available { get; set; } = true;
     }

     public class Update
     {
         public string? Title { get; set; }
         public DateTime? PublishDate { get; set; }
         public string? ISBN { get; set; }
         public bool? Available { get; set; }
     }
 }

 public class BorrowingsDTO
{
    public long Id { get; set; }
    public long BookId { get; set; }
    public long UserId { get; set; }
    public DateTime BorrowDate { get; set; }

    public class Create
    {
        public long BookId { get; set; }
        public long UserId { get; set; }
        public DateTime BorrowDate { get; set; }
    }

    public class Update
    {
        public DateTime BorrowDate { get; set; }
    }
}

 public class PublisherDTO
 {
     public long Id { get; set; }
     public string Name { get; set; }
     public string? Email { get; set; }
     [JsonIgnore]
     public ICollection<Book>? Books { get; set; }

     public class Create
     {
         public string Name { get; set; }
         public string? Email { get; set; }
     }

     public class Update
     {
         public string? Name { get; set; }
         public string? Email { get; set; }
     }
 }

   public class UserDTO
  {
      public long Id { get; set; }
      public string Name { get; set; }
      public string Email { get; set; }
      public string Password { get; set; }

      public class Create
      {
          public string Name { get; set; }
          public string Email { get; set; }
          public string Password { get; set; }
      }

      public class Update
      {
          public string? Name { get; set; }
          public string? Email { get; set; }
      }

      public class Login
      {
          public string Email { get; set; }
          public string Password { get; set; }
      }
  }

```

Form Layer

There are:

AuthorCreateForm 
-for creating author
-calls author service

BookAddForm
-create book
-calls book service

BooksAll
-provide all filtered books in data grid view

BooksBorrowed
-provide all borrowed books in data grid view

DetailBookForm
-provides book details with option to update it

DetailBorrowedBookForm
- provides book details without option to update it

EditBookForm
-provides form for editing book

LoggedMenuForm
-menu for logged user with actions

LoginForm

RegistrationForm

ProfileForm
-represents logged user data

Menu
-first menu where user can login or register

SessionManager class is Singleton which holds logged user

The Program class in the LibraryManager namespace sets up and initializes the dependency injection container for the application. The Main method configures a ServiceCollection, adds necessary services and dependencies through ConfigureServices, builds the ServiceProvider, and starts the application by running the Menu form. Key services are registered, including DbContext for database interactions, unit of work and repository implementations, and various application-specific services and forms. The class leverages AutoMapper for object mapping and MySQL as the database provider, ensuring that all required components are properly instantiated and injected throughout the application.

# Input Data

Input data for this application are set in text boxes where user put his input.
It can be use for login, creating or searching.

# Output Data

Output data are represented in grid view for searching books or borrowed books.
The messages for action are showed in MessageBox