using Command.Models;
using System.Collections.Generic;

namespace Command.DataAccess
{
    public class BookStore : IStore
    {
        Dictionary<string, (Book book, int stock)> _books;

        public BookStore()
        {
            _books = new Dictionary<string, (Book book, int stock)>();
            _books["B001"] = (new Book { BookId = "B001", Name = "harry potter" }, 2);
            _books["B002"] = (new Book { BookId = "B002", Name = "marry poppins" }, 7);
            _books["B003"] = (new Book { BookId = "B003", Name = "agatha cristie" }, 4);
            _books["B004"] = (new Book { BookId = "B004", Name = "stephen king" }, 9);
        }

        public void DecreaseBook(string bookId)
        {
            Book book = _books[bookId].book;
            int stock = _books[bookId].stock;
            _books[bookId] = (book, stock - 1);
        }

        public Book GetBook(string bookId)
        {
            return _books[bookId].book;
        }

        public int GetTotalStock(string bookId)
        {
            return _books[bookId].stock;
        }

        public void IncreaseBook(string bookId)
        {
            Book book = _books[bookId].book;
            int stock = _books[bookId].stock;
            _books[bookId] = (book, stock + 1);
        }
    }
}
