using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTarget.Repository.Contracts
{
    public interface IBaseRepository<T>
    {
        void Insert(T obj);
        void Update(T obj);
        void Excluir(T obj);
        List<T> GetAll();
        T GetById(int id);
    }
}
