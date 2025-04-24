using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Task
{
    class Library
    {
        public static List<AbstractPerson> Members;
        public static List<Book> Books;
        public Library()
        {
            Members = new List<AbstractPerson>();
            Books = new List<Book>();
        }
        public static bool AddBook(Book book)
        {
            if (!Books.Contains(book))
            {
                Books.Add(book);
                return true;
            }
            return false;
        }
        public bool AddMember(AbstractPerson member)
        {
            if (!Members.Contains(member))
            {
                Members.Add(member);
                return true;
            }
            return false;
        }
        public Book FindBookById(int id)
        {
            foreach(Book book in Books)
            {
                if(book.ID == id)
                {
                    return book;
                }
            }
            return null;
        }
        public AbstractPerson FindMemberById(int id)
        {
            foreach (AbstractPerson member in Members)
            {
                if (member.ID == id)
                {
                    return member;
                }
            }
            return null;
        }
        public void DisplayAllBooks()
        {
            foreach(Book book in Books)
            {
                string keyword = book.IsAvailable ? "Available" : "Not Available";
                Console.WriteLine($"ID: {book.ID}, Title: {book.Title}, Author: {book.AuthorName}.  {keyword}!");
            }
        }
        public void DisplayAllMembers()
        {
            foreach (AbstractPerson member in Members)
            {
                Console.WriteLine($"ID: {member.ID}, Name: {member.Name}.");
            }
        }
    }
}
