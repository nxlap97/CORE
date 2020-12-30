using CORE.Data.Infrastructor;
using CORE.Domain.Models;
using CORE.Service.IF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CORE.Service.EF
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category, string> _categoryRepository;

        public CategoryService(IRepository<Category, string> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void Add(Category obj)
        {
            _categoryRepository.Add(obj);
        }

        public void Delete(string id)
        {
            _categoryRepository.Remove(id);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.FindAll().ToList();
        }

        public Category GetById(string id)
        {
            return _categoryRepository.FindById(id);
        }

        public void Save()
        {
            _categoryRepository.SaveChange();
        }

        public void Update(Category obj)
        {
            _categoryRepository.Update(obj);
        }
    }
}
