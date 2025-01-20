using Task03;

namespace Task03
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;
        bool avb;

        public Book(string Title, string Author, string ISBN, bool avb = true)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
            this.avb = avb;
        }

        public string GetTitle()         //Getter for title
        {
            return this.Title;
        }

        public void SetTitle(string title)     // setter for title
        {
            this.Title = title;
        }

        public string GetAuthor()  // getter for author
        {
            return Author;
        }

        public void SetAuthor(string author) // setter for author
        {
            this.Author = author;
        }

        public string GetISBN()  // getter for author
        {
            return ISBN;
        }

        public void SetISBN(string ISBN) // setter for author
        {
            this.ISBN = ISBN;
        }

        public bool GetAvb()  // getter for avalability
        {
            return avb;
        }

        public void SetAvb(bool avb) // setter for avalability
        {
            this.avb = avb;
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
                if (word == books[i].GetTitle())
                {

                    found = true;
                    Console.WriteLine("book founded");
                    return true;

                    
                }
            }
            if (!found)
            {
                Console.WriteLine("book not founded");
            }

            return false;
        }

        public void BorrowBook(string word) //method th borrow a book
        {
            int flag = 0;
            for (int i = 0; i < books.Count; i++)
            {

                if (word == books[i].GetTitle())
                {
                    flag++;
                    if (books[i].GetAvb()==true)
                    {
                        
                        books[i].SetAvb(false);
                        Console.WriteLine($"{books[i].GetTitle()} is borrowed"); // done borrwing
                    }
                    else if(books[i].GetAvb()==false)
                    {
                        Console.WriteLine($"{books[i].GetTitle()} is already borrowed"); // book already borrowed
                    }
                }
                
  
            }
            if (flag == 0)  // if there is no book with the entered title to borrow
            {
                Console.WriteLine($"{word} we don't have this book in our collection to borrow");
            }

        }

        public void ReturnBook(string word) // method to return a book
        {
            int flag = 0;
            for (int i = 0; i < books.Count; i++)
            {



                if (word == books[i].GetTitle())
                {
                    flag++;

                    if (books[i].GetAvb() == false)
                    {
                        books[i].SetAvb(true);
                        Console.WriteLine($"{books[i].GetTitle()} is Returned");
                    }
                    else if (books[i].GetAvb()==true)
                    {
                        Console.WriteLine($"{books[i].GetTitle()} is not borrowed, you can borrow it now..");
                    }

                }
               
            }

            if (flag == 0)  // if there is no book with the entered title to return
            {
                Console.WriteLine($"{word} we don't have this book in our collection");
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



