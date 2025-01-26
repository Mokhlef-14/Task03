using Task03;

namespace Task03
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool Avb { get; set; }

        public Book(string Title, string Author, string ISBN, bool avb = true)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
            this.Avb = Avb;
        }

    }

    class Library
    {
        public List<Book> books;

        public Library()  //contructor
        {
             books = new List<Book>();
        }

        public void AddBook(Book bookname) // metjod to add a book
        {
            books.Add(bookname);
        }

        public bool SearchBook(string word) // method to search for a book
        {
            bool found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title.Contains(word))
                {

                    found = true;
                    Console.WriteLine($"{word} founded");
                    return true;

                    
                }
            }
            if (!found)
            {
                Console.WriteLine($"{word} not founded");
            }

            return false;
        }

        public void BorrowBook(string word) //method th borrow a book
        {
            
            for (int i = 0; i < books.Count; i++)
            {

                if (word == books[i].Title)
                {
                    
                    if (books[i].Avb==true)
                    {
                        
                        books[i].Avb=false;
                        Console.WriteLine($"{books[i].Title} is borrowed"); // done borrwing
                    }
                    else if(books[i].Avb==false)
                    {
                        Console.WriteLine($"{books[i].Title} is already borrowed"); // book already borrowed
                    }
                }
                
  
            }
            if (!SearchBook(word))  // if there is no book with the entered title to borrow
            {
                Console.WriteLine($"{word} we don't have this book in our collection to borrow");
            }

        }

        public void ReturnBook(string word) // method to return a book
        {
            
            for (int i = 0; i < books.Count; i++)
            {



                if (word == books[i].Title)
                {
                    

                    if (books[i].Avb == false)
                    {
                        books[i].Avb=true;
                        Console.WriteLine($"{books[i].Title} is Returned");
                    }
                    else if (books[i].Avb==true)
                    {
                        Console.WriteLine($"{books[i].Title} is not borrowed, you can borrow it now..");
                    }

                }
               
            }

            if (!SearchBook(word))  // if there is no book with the entered title to return
            {
                Console.WriteLine($"{word} we don't have this book in our collection, may be you are worng with our library");
            }


        }

    }
}    

    internal class Program
    {
    static void Main(string[] args)
    {
        Library library = new Library();

        // Adding books to the library
        library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
        library.AddBook(new Book("1984", "George Orwell", "9780451524935"));

        Console.WriteLine(library.SearchBook("Gatsby"));


        // Searching and borrowing books
        Console.WriteLine("Searching and borrowing books...");
        library.BorrowBook("Gatsby");
        library.BorrowBook("1984");
        library.BorrowBook("Harry Potter"); // This book is not in the library

        // Returning books
        Console.WriteLine("\nReturning books...");
        library.ReturnBook("Gatsby");
        library.ReturnBook("Harry Potter"); // This book is not borrowed

        Console.ReadLine();
    }

    /* static void Main(string[] args)
     {

            library myLibrary = new library();

         // Add books to the library
         myLibrary.AddBook(new book("1919", "Ahmed Morad", "00", true));
         myLibrary.AddBook(new book("Guantanamo", "Youssef Zidan", "01", true));
         myLibrary.AddBook(new book("Blue Elephant", "Ahmed Morad", "02", false));

         myLibrary.SearchBook("1929");
         myLibrary.BorrowBook("1929");
         myLibrary.ReturnBook("1919");









 }*/
}



