using Microsoft.AspNetCore.Mvc;
using UsingViewComponents.Models;

namespace UsingViewComponents.Controllers
{
    public class HomeController :Controller
    {
        private IProductRepository repository;
        public HomeController(IProductRepository repo) => repository = repo;



    }
}
