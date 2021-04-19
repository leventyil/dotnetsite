using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using moviesite.Models;
using X.PagedList;



namespace moviesite.Controllers
{
    public class FilmController : Controller
    {
        private readonly AppDbContext c;

        public FilmController(AppDbContext c)
        {
            this.c = c;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int searchYear, int? pageNumber, int pageSize = 10)
        {

            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;
            ViewBag.NameSortParam = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["YearSortParam"] = sortOrder == "year" ? "year_asc" : "year";
            ViewBag.LengthSortParam = sortOrder == "length" ? "length_asc" : "length";
            ViewBag.ScoreSortParam = sortOrder == "score" ? "score_asc" : "score";
            ViewBag.Score1SortParam = sortOrder == "score1" ? "score1_asc" : "score1";


            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var query = from x in c.TBLMOVIES select x;

            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(x => x.FilmName.Contains(searchString));
            }
            if (searchYear != 0)
            {
                query = query.Where(x => x.FilmYear == searchYear);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    query = query.OrderByDescending(x => x.FilmName);
                    break;
                case "year_asc":
                    query = query.OrderBy(x => x.FilmYear);
                    break;
                case "year":
                    query = query.OrderByDescending(x => x.FilmYear);
                    break;
                case "length_asc":
                    query = query.OrderBy(x => x.FilmLength);
                    break;
                case "length":
                    query = query.OrderByDescending(x => x.FilmLength);
                    break;
                case "score_asc":
                    query = query.OrderBy(x => x.FilmScore);
                    break;
                case "score":
                    query = query.OrderByDescending(x => x.FilmScore);
                    break;
                case "score1_asc":
                    query = query.OrderBy(x => x.FilmScoreTwo);
                    break;
                case "score1":
                    query = query.OrderByDescending(x => x.FilmScoreTwo);
                    break;
                default:
                    query = query.OrderBy(x => x.FilmName);
                    break;
            }



            return View(await PaginatedList<Film>.CreateAsync(query.AsNoTracking(), pageNumber ?? 1, pageSize));

        }



        public IActionResult Search(string searchName, int searchYear)
        {
            var query = from x in c.TBLMOVIES select x;

            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(x => x.FilmName.Contains(searchName));
            }
            if (searchYear != 0)
            {
                query = query.Where(x => x.FilmYear == searchYear);
            }
            return View(query);
        }

        public IActionResult FilmSil(int id)
        {
            var film = c.TBLMOVIES.Find(id);
            c.TBLMOVIES.Remove(film);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult FilmGetir(int id)
        {
            var film = c.TBLMOVIES.Find(id);
            return View("FilmGetir", film);
        }

        public IActionResult FilmGuncelle(Film f)
        {
            var film = c.TBLMOVIES.Find(f.id);
            film.FilmName = f.FilmName;
            film.FilmYear = f.FilmYear;
            film.FilmLength = f.FilmLength;
            film.FilmScore = f.FilmScore;
            film.FilmScoreTwo = f.FilmScoreTwo;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult YeniFilm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniFilm(Film f)
        {
            if (!ModelState.IsValid)
            {
                return View("YeniFilm");
            }
            c.TBLMOVIES.Add(f);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
