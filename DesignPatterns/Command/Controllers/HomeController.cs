using Command.Business;
using Command.CommandManagers;
using Command.Commands;
using Command.DataAccess;
using Command.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Command.Controllers
{
    public class HomeController : Controller
    {
        ICommandManager _commandManager;
        private readonly IStore _store;
        private readonly ICart _cart;

        public HomeController(ICommandManager commandManager, IStore store, ICart cart)
        {
            _commandManager = commandManager;
            _store = store;
            _cart = cart;
        }

        public IActionResult Index()
        {
            DisplayCardDetail();
            return View();
        }

        private void DisplayCardDetail()
        {
            Book book = GetBook();
            ViewBag.TotalCartItems = _cart.GetShoppingCartCount(book);
        }

        private Book GetBook()
        {
            return _store.GetBook("B001");
        }

        [HttpPost]
        public IActionResult AddToCart()
        {
            var command = new AddToShoppingCartCommand(GetBook(), _store, _cart);
            _commandManager.Invoke(command);

            DisplayCardDetail();

            return View("Index");
        }

        [HttpPost]
        public IActionResult MoveToWishList()
        {
            var command = new AddToWishListCommand(GetBook(), _store, _cart);
            _commandManager.Invoke(command);

            DisplayCardDetail();

            return View("Index");
        }

        [HttpPost]
        public IActionResult Undo()
        {
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
