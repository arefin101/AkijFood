using AkijFood.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkijFood.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected AkijFoodContext context = new AkijFoodContext();
        public void Delete(int id)
        {
            context.Set<TEntity>().Remove(GetById(id));
            context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
