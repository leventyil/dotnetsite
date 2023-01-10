using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using moviesite.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace moviesite.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDbContext c;
        private readonly UserManager<IdentityUser> _userManager;

        public ProfileController(AppDbContext c, UserManager<IdentityUser> userManager)
        {
            this.c = c;
            _userManager = userManager;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Watchlist(string sortOrder, string currentFilter, string searchString, int searchYear, int? pageNumber, int pageSize = 25)
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


            var user = await _userManager.GetUserAsync(HttpContext.User);
            var table = c.WantToWatch.Where(x => x.UserId.ToString() == user.Id);
            Console.Write(table);
            //var query = from t1 in c.TBLMOVIES
            //             join t2 in table
            //             on t1.Id equals t2.MovieId.ToString()
            //             select new { t1.Id, t1.FilmName, t1.FilmYear, t1.FilmLength, t1.FilmScore, t1.FilmScoreTwo };

            var query = c.TBLMOVIES.Join(c.WantToWatch, x => x.Id, y => y.MovieId.ToString(), (x, y) => x);

            //var query = from x in c.TBLMOVIES select x;


            if (!String.IsNullOrEmpty(searchString))
            {
                query = query.Where(b => b.FilmName.Contains(searchString));
            }
            if (searchYear != 0)
            {
                query = query.Where(x => x.FilmYear == searchYear);
            }

            query = sortOrder switch
            {
                "name_desc" => query.OrderByDescending(x => x.FilmName),
                "year_asc" => query.OrderBy(x => x.FilmYear),
                "year" => query.OrderByDescending(x => x.FilmYear),
                "length_asc" => query.OrderBy(x => x.FilmLength),
                "length" => query.OrderByDescending(x => x.FilmLength),
                "score_asc" => query.OrderBy(x => x.FilmScore),
                "score" => query.OrderByDescending(x => x.FilmScore),
                "score1_asc" => query.OrderBy(x => x.FilmScoreTwo),
                "score1" => query.OrderByDescending(x => x.FilmScoreTwo),
                _ => query.OrderBy(x => x.FilmName),
            };
            
            return View(await PaginatedList<Film>.CreateAsync(query.AsNoTracking(), pageNumber ?? 1, pageSize));

        }
    }
}
