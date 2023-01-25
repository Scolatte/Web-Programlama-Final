using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaFinal2023.Models
{
    public class NewsRepository : INewsRepository
    {
        private NewsDbContext context;
        public NewsRepository(NewsDbContext _context)
        {
            context = _context;
        }

        public IQueryable<News> News => context.News;

        public void AddNew(News news) => context.News.Add(news);

        public void DeleteNews(int? id) => context.News.Remove(context.News.Where(i => i.ID == id).First());

        public News FindNews(int? newsID) => context.News.Find(newsID);

        public void Save() => context.SaveChanges();

        public void UpdateNews(News news) => context.News.Update(news);
    }
}
