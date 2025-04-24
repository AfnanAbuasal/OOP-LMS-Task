using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LMS_Task
{
    class Member: AbstractPerson
    {
        public List<Book> BorrowedBooks;
        public Member(int id, string name): base(id, name)
        {
            BorrowedBooks = new List<Book>();
        }
        public bool BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                this.BorrowedBooks.Add(book);
                book.IsAvailable = false;
                Console.WriteLine("Book Borrowed Successfully!");
                return true;
            }
            return false;
        }
        public bool ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine("Book Returned Successfully!");
                return true;
            }
            return false;
        }
        public void DisplayBorrowedBooks()
        {
            foreach (Book book in BorrowedBooks)
            {
                Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.AuthorName}.");
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Borrowed Books:");
            foreach (Book book in BorrowedBooks)
            {
                Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.AuthorName}.");
            }
        }
    }
}
