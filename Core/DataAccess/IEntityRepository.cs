
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Core katmnı evrensel katmandır.İÇerisindeki kodlar projeye özgü değil genel kodlardır.Core katmanı diğer katmanları referans almaz.Alırsa diğer katmanları bağımlı hale gelir.
    //Generic constraint(T için istenilen her değerin girilmesini engellememize yarar yanlızca veri tabanı nesneleri girilmelidir.)
    //class: Referans tip olabilir anlamına gelir.
    //IEntity: IEntity olmalı ya da IEntityden implemente olmuş bir nesne olabilir.
    //new():new'lenebilir olmalı.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
