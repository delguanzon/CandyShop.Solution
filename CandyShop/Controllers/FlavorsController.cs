using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CandyShop.Models;

namespace CandyShop.Controllers
{
    public class FlavorsController: Controller
    {
        private readonly CandyShopContext _db;
        public FlavorsController(CandyShopContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Flavor> model = _db.Flavors.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Flavor flavor)
        {
            if(!ModelState.IsValid)
            {
                return View(flavor);
            }
            {
                _db.Flavors.Add(flavor);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            
        }

        public ActionResult Details(int id)
        {
            Flavor thisFlavor = _db.Flavors
                .Include(flavor => flavor.JoinEntities)
                .ThenInclude(join => join.Treat)
                .FirstOrDefault(flavor => flavor.FlavorId == id);
            return View(thisFlavor);
        }
        public ActionResult Edit(int id)
        {
            Flavor thisFlavor = _db.Flavors
                .Include(flavor => flavor.JoinEntities)
                .ThenInclude(join => join.Treat)
                .FirstOrDefault(flavor => flavor.FlavorId == id);
            return View(thisFlavor);
        }

        public ActionResult Edit(Flavor flavor)
        {
            if(!ModelState.IsValid)
            {
                return View(flavor);
            }
            else 
            {
                _db.Flavors.Update(flavor);
                _db.SaveChanges();
                return RedirectToAction("Details", new { id = flavor.FlavorId });
            }
        }

    }
}