using RepositoryPattern.Models;
using System;
using System.Collections.Generic;

namespace RepositoryPattern.Repository
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void AddBook(Book bookEntity);
        void UpdateBook(Book bookEntity);
        void DeleteBook(int bookId);
        void Save();
    }
}
