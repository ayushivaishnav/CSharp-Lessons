using Microsoft.AspNetCore.Mvc;
using NWind.Models;

namespace NWind.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }
        public ActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetOrders();
            OrderIdViewModel idsViewModel = new OrderIdViewModel(orderIds);
            return View(idsViewModel);
        }
        public ActionResult Details(int id)
        {
            Order order = _repositoryOrders.PutOrder(id);
            return View(order);
        }
    }
}
