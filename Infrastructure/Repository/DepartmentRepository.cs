using DAL.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository
{
    public class DepartmentRepository : IDepartmentInterface
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Create(Department data)
        {
            _context.Departments.Add(data);
            Save();
        }

        public void Delete(int Id)
        {
            _context.Departments.Remove(GetOne(Id));
            Save();
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Departments;
        }

        public Department GetOne(int Id)
        {
            return _context.Departments.Find(Id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Department data)
        {
            _context.Departments.Update(data);
            Save();
        }
    }
}
