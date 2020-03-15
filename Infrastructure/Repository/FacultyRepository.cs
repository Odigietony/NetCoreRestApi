using DAL.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class FacultyRepository : IFacultyInterface
    {
        private readonly ApplicationDbContext _context;

        public FacultyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Faculty data)
        {
            _context.Faculties.Add(data);
            Save();
        } 

        public IEnumerable<Faculty> GetAll()
        {
            return _context.Faculties;
        }

        public Faculty GetOne(int Id)
        {
            return _context.Faculties.Find(Id);
        }

        public void Update(Faculty data)
        { 
            _context.Update(data);
            Save();
        } 

        public void Delete(int Id)
        {
            _context.Faculties.Remove(GetOne(Id));
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
