using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movieList = GetMovies();
            return View(movieList);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                //new Movie { Id = 1, Name = "Shrek!"},
                //new Movie { Id = 2, Name = "Antz!"}
            };
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(x => x.Id == id);
            return View(movie);
        }
      

        // GET: Movies/Random
        public ActionResult Random()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" },
            };
            var movie = new Movie() { Name = "Shrek!"};
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

    }
}