using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces
{
    public interface IBaseInterface<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetOne(int Id);
        void Create(object T);
        void Update(object T);
        void Delete(int Id);
        void Save();
    }
}
