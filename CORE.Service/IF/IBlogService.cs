using CORE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.IF
{
    public interface IBlogService
    {
        List<Blog> GetAll();

        void Add(Blog obj);
        void AddToCategory(BlogCategory obj);
        string GetCategoryId(string blogId);
         void UpdateToCategory(string blogId, string categoryId);

        void Update(Blog obj);

        void Delete(string id);

        Blog GetById(string id);

        void Save();

    }
}
