using Command.Models;

namespace Command.DataAccess
{
    public interface IStore
    {
        void IncreaseBook(string bookId);
        void DecreaseBook(string bookId);
        Book GetBook(string bookId);
        int GetTotalStock(string bookId);
    }
}
