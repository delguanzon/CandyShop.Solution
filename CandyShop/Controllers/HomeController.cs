using Microsoft.AspNetCore.Mvc;
using CandyShop.ViewModels;
using CandyShop.Models;
using System.Linq;

namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {

      private readonly CandyShopContext _db;

      public HomeController(CandyShopContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        ListAllViewModel model = new ListAllViewModel();
        model.Flavors = _db.Flavors.ToList();
        model.Treats = _db.Treats.ToList();
        return View(model);
      }

    }
}