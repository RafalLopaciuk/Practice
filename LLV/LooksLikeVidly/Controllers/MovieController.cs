using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LooksLikeVidly.Models;
using LooksLikeVidly.ViewModels;

namespace LooksLikeVidly.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Index()
        {
            var Movies = new List<Movie>
            {
                new Movie {Id = 1, Name = "A Silent Voice" },
                new Movie {Id = 2, Name = "Kimi no Na wa." },
                new Movie {Id = 3, Name = "Kizumonogatari III: Reiketsu-hen" },
                new Movie {Id = 4, Name = "Ookami Kodomo no Ame to Yuki" },
                new Movie {Id = 5, Name = "Gintama Movie 2: Kanketsu-hen - Yorozuya yo Eien Nare" }

            };

            var viewModel = new MoviesListViewModel
            {
                Movie = Movies
            };

            return View(viewModel);
        }  
    }
}