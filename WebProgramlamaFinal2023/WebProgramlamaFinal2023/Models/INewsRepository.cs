using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProgramlamaFinal2023.Models
{
    public interface INewsRepository
    {
        IQueryable<News> News { get; }
        

        void AddNew(News news);
        void DeleteNews(int? id);
        void UpdateNews(News news);
        News FindNews(int? anoID);
       // Admin FindAdmin(int? adminID);
        void Save();
    }
}
