using CORE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CORE.Service.IF
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        void Add(Category obj);

        void Update(Category obj);

        void Delete(string id);

        Category GetById(string id);

        void Save();

    }
}
