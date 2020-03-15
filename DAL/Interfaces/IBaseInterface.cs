using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IBaseInterface<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetOne(int Id);
        void Create(T data);
        void Update(T data);
        void Delete(int Id);
        void Save();
    }
}
