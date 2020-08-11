using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GlamperAuth.Models;
using Microsoft.AspNetCore.Mvc;

namespace GlamperAuth.Controllers
{
    public class FavoritesController : Controller
    {
        private readonly IFavoritesRepository repo;

        public FavoritesController(IFavoritesRepository repo)
        {
            this.repo = repo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var favorites = repo.GetAllFavorites();
            return View(favorites);
        }

        public IActionResult InsertFavoriteToDatabase(Favorites favoriteToInsert)
        {
            repo.InsertFavorite(favoriteToInsert);

            return RedirectToAction("Index");
        }
      
    }
}


