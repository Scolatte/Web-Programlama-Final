using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProgramlamaFinal2023.Models;

namespace WebProgramlamaFinal2023.Controllers
{
   
    public struct NewsPacket
    {
        public IQueryable<News> News;
        public News PopNew => News.Last();
    }

    public class HomeController : Controller
    {
        public static HomeController Instance = null;

        public List<string> imagesSrc = new List<string>()
                { "/WebFinalTemplate/news-website-templates/img/top-news-1.jpg",
                "/WebFinalTemplate/news-website-templates/img/top-news-2.jpg",
                "/WebFinalTemplate/news-website-templates/img/top-news-3.jpg",
                "/WebFinalTemplate/news-website-templates/img/top-news-4.jpg",
                "/WebFinalTemplate/news-website-templates/img/top-news-5.jpg"
                };

        private INewsRepository repository;


        public HomeController(INewsRepository _context)
        {
            Instance = this;

            repository = _context;
        }

        //public IEnumerable<News> GetNews(INewsRepository repository)
        //{
        //    return repository.News.ToList();
        //}
        //[HttpGet("News/{id}")]

        //public ActionResult<News> GetNews(int id)
        //{
        //    var haber = News.(id);
        //    if (haber == null)
        //    {
        //        return NotFound();
        //    }
        //    return haber;
        //}


        public IActionResult Index()
        {
            NewsPacket news = new NewsPacket();
            news.News = repository.News.OrderBy(i => i.PublishDate);

            return View(news);
        }

        public IActionResult Admin()
        {
            return View(repository.News);
        }

        public IActionResult Delete(int id)
        {
            repository.DeleteNews(id);
            repository.Save();

            return RedirectToAction("Admin");
        }

        public IActionResult SingleNewPage(int newID)
        {
            return View(repository.FindNews(newID));
        }

        public IActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddNew(News news)
        {
            if (ModelState.IsValid)
            {
                news.Image = imagesSrc[new Random().Next(0, 5)];
                news.PublishDate = DateTime.Now;

                repository.AddNew(news);
                repository.Save();

                return RedirectToAction("Admin");
            }
            else
            {
                //Hata verirse

                return View();
            }
        }

        //GET
        public IActionResult UpdateNew(int? id)
        {
            if (id == null)
                return NotFound();

            var ano = repository.FindNews(id);
            
            if (ano == null) return NotFound();

            return View(ano);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateNew(News news)
        {
            if (ModelState.IsValid)
            {
                repository.UpdateNews(news);
                repository.Save();

                return RedirectToAction("Admin");
            }
            else
            {
                //Hata verirse

                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
