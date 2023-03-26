using Command.Models;
using System.Collections.Generic;

namespace Command.Business
{
    public class BookShoppingCart : ICart
    {
        private Dictionary<string, (Book book, int total)> _shoppingCart;
        private Dictionary<string, (Book book, int total)> _wishList;

        public BookShoppingCart()
        {
            _shoppingCart = new Dictionary<string, (Book book, int total)>();
            _wishList = new Dictionary<string, (Book book, int total)>();
        }

        public void DecreaseShoppingCartItem(Book book)
        {
            if (_shoppingCart.ContainsKey(book.BookId))
            {
                var b = _shoppingCart[book.BookId];
                _shoppingCart[book.BookId] = (b.book, b.total - 1);
            }
        }

        public void DecreaseWishListItem(Book book)
        {
            if (_wishList.ContainsKey(book.BookId))
            {
                var b = _wishList[book.BookId];
                _wishList[book.BookId] = (b.book, b.total - 1);
            }
        }

        public int GetShoppingCartCount(Book book)
        {
            if (!_shoppingCart.ContainsKey(book.BookId)) return 0;

            return _shoppingCart[book.BookId].total;
        }

        public int GetWishListCount(Book book)
        {
            if (!_wishList.ContainsKey(book.BookId)) return 0;
                
            return _wishList[book.BookId].total;
        }

        public void IncreaseShoppingCartItem(Book book)
        {
            if (_shoppingCart.ContainsKey(book.BookId))
            {
                var b = _shoppingCart[book.BookId];
                _shoppingCart[book.BookId] = (b.book, b.total + 1);
            }
            else
            {
                _shoppingCart[book.BookId] = (book, 1);
            }
        }

        public void IncreaseWishListItem(Book book)
        {
            if (_wishList.ContainsKey(book.BookId))
            {
                var b = _wishList[book.BookId];
                _wishList[book.BookId] = (b.book, b.total + 1);
            }
            else
            {
                _wishList[book.BookId] = (book, 1);
            }
        }
    }
}
