using Command.Business;
using Command.DataAccess;
using Command.Models;

namespace Command.Commands
{
    public class AddToWishListCommand : ICommand
    {
        private readonly Book _book;
        private readonly IStore _store;
        private readonly ICart _cart;

        public AddToWishListCommand(Book book, IStore store, ICart cart)
        {
            _book = book;
            _store = store;
            _cart = cart;
        }

        public bool CanExecute()
        {
            return _store.GetTotalStock(_book.BookId) > 0;
        }

        public void Execute()
        {
            _store.DecreaseBook(_book.BookId);
            _cart.IncreaseWishListItem(_book);
        }

        public void Undo()
        {
            _store.IncreaseBook(_book.BookId);
            _cart.DecreaseWishListItem(_book);
        }
    }
}
