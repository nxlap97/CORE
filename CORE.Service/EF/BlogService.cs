using CORE.Data.Infrastructor;
using CORE.Domain.Models;
using CORE.Service.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Service.EF
{
    public class BlogService : IBlogService
    {
        private readonly IRepository<Blog, string> _blogRepository;
        private readonly IRepository<BlogCategory, string> _blogCategoryRepository;

        public BlogService(IRepository<Blog, string> blogRepository, IRepository<BlogCategory, string> blogCategoryRepository)
        {
            _blogRepository = blogRepository;
            _blogCategoryRepository = blogCategoryRepository;
        }

        public string GetCategoryId(string blogId)
        {
            var blogCategory = _blogCategoryRepository.FindAll(x => x.BlogId == blogId).FirstOrDefault();
            return blogCategory?.CategoryId;
        }

        public void Add(Blog obj)
        {
             _blogRepository.Add(obj);
        }

        public void AddToCategory(BlogCategory obj)
        {
            _blogCategoryRepository.Add(obj);
        }

        public void UpdateToCategory(string blogId,string categoryId)
        {
            var blogCategory =  _blogCategoryRepository.FindAll().Where(x=>x.BlogId == blogId).FirstOrDefault();
           
            if (blogCategory == null)
            {
                var obj = new BlogCategory()
                {
                    BlogId = blogId,
                    CategoryId = categoryId,
                };
                _blogCategoryRepository.Add(obj);
            }
            else
            {
                _blogCategoryRepository.Delete(blogCategory.Id);

                var obj = new BlogCategory()
                {
                    BlogId = blogId,
                    CategoryId = categoryId,
                };
                _blogCategoryRepository.Add(obj);
                //var obj = new BlogCategory()
                //{
                //    Id = blogCategory.Id,
                //    BlogId = blogId,
                //    CategoryId = categoryId,
                //    CreatedBy = blogCategory.CreatedBy,
                //    CreatedDate = blogCategory.CreatedDate,
                    
                //};
                //_blogCategoryRepository.Update(obj);
            }
        }

        public void Delete(string id)
        {
            _blogRepository.Remove(id);
        }

        public List<Blog> GetAll()
        {
            return _blogRepository.FindAll().ToList();
        }

        public Blog GetById(string id)
        {
            return _blogRepository.FindById(id);
        }

        public void Save()
        {
            _blogRepository.SaveChange();
        }

        public void Update(Blog obj)
        {
            _blogRepository.Update(obj);
        }
    }
}
