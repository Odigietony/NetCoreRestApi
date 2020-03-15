using DAL.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class BaseRepository<T> : IBaseInterface<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> entity;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }
        public void Create(T data)
        {
            _context.Add(data);
            Save();
        }

        public void Delete(int Id)
        {
            _context.Remove(GetOne(Id));
            Save();
        }

        public IEnumerable<T> GetAll()
        {
            return entity;
        }

        public T GetOne(int Id)
        {
            T data = entity.Find(Id);
            return data;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T data)
        {
            _context.Update(data);
            Save();
        }
    }
}
