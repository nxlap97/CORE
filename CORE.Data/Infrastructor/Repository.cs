using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using CORE.Domain.Models;
using CORE.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using CORE.Utility.StringHelper;

namespace CORE.Data.Infrastructor
{
    public class Repository<T,K> : IRepository<T,K>, IDisposable where T : ParentEntity<string>
    {
        private readonly COREDbContext _context;
        private readonly IHttpContextAccessor _httpContext;

        public Repository(COREDbContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _httpContext = httpContext;
        }

        private void UpdateInfo(T obj, string state, bool published = true)
        {
            var claim = _httpContext.HttpContext.User.Claims.Where(x => x.Type == ClaimHelper.ID).FirstOrDefault();
            switch (state)
            {
                case "ADD_ENTITY_STATE":
                    obj.CreatedDate = DateTime.Now;
                    obj.CreatedBy = claim?.Value;
                    //obj.Published = published;
                    _context.Add(obj);
                    break;
                case "UPDATE_ENTITY_STATE":
                    obj.UpdatedDate = DateTime.Now;
                    obj.UpdatedBy = claim?.Value;
                    //obj.Published = published;
                    _context.Set<T>().Update(obj);
                    break;
                case "REMOVE_ENTITY_STATE":
                    obj.DeletedDate = DateTime.Now;
                    obj.DeletedBy = claim?.Value;
                   // obj.Published = published;
                    _context.Set<T>().Update(obj);
                    break;
            }
            
            SaveChange();
        }

        public void Add(T entity)
        {
            UpdateInfo(entity, InfoState.ADD);
        }

        public void AddRang(List<T> entities)
        {
            foreach(var entity in entities)
            {
                UpdateInfo(entity, InfoState.ADD);
            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items;
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items.Where(predicate);
        }

        public T FindById(K id, params Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(x => x.Id.Equals(id));
        }

        public T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(predicate);
        }

        public void Remove(T entity)
        {
            UpdateInfo(entity, InfoState.REMOVE);
            //_context.Set<T>().Remove(entity);
        }

        public void Remove(K id)
        {
            var obj = FindById(id);
            UpdateInfo(obj, InfoState.REMOVE);
        }

        public void Delete(K id)
        {
            var obj = FindById(id);
            _context.Remove(obj);
        }

        public void RemoveMultiple(List<T> entities)
        {
            foreach (var entity in entities)
            {
                Remove(entity);
            }
        }

        public void Update(T entity)
        {
            UpdateInfo(entity, InfoState.UPDATE);
        }

        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
}
