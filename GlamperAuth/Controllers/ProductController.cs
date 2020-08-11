using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlamperAuth.Models;
using Microsoft.AspNetCore.Mvc;


namespace GlamperAuth.Controllers
{
        public class ProductController : Controller
        {
            private readonly IProductRepository repo;

            public ProductController(IProductRepository repo)
            {
                this.repo = repo;
            }

            // GET: /<controller>/
            public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }

        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);

            return View(product);
        }

        public IActionResult InsertFavoriteToDatabase(Favorites favoriteToInsert)
        {
            repo.InsertFavorite(favoriteToInsert);

            return RedirectToAction("Index");
        }

        //public IActionResult DetailPageGet()
        //{

        //    return RedirectToAction("Index");
        //}

    }
}
