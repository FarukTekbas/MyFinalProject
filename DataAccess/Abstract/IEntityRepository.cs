using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic constraint kısıtlıyoruz T referans tip olabilir, IEntity olabilir yada IEntity implemete edebilir, new() lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //filtre yazmamızı sağlıyor bunlar delegeler expression
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
