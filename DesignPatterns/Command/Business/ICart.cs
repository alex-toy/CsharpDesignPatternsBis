using Command.Models;

namespace Command.Business
{
    public interface ICart
    {
        void IncreaseShoppingCartItem(Book book);
        void DecreaseShoppingCartItem(Book book);
        void IncreaseWishListItem(Book book);
        void DecreaseWishListItem(Book book);
        int GetWishListCount(Book book);
        int GetShoppingCartCount(Book book);
    }
}
