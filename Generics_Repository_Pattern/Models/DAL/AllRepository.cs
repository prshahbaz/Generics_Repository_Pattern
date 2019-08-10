using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Generics_Repository_Pattern.Models.DAL
{
    public class AllRepository<T>:IAllRepository<T> where T:class
    {
        private DataContext _dataContext;
        private IDbSet<T> DbEntity;
        public AllRepository()
        {
            _dataContext = new DataContext();
            DbEntity = _dataContext.Set<T>();
        }

        public void DeleteModel(T ModelId)
        {
            T model = DbEntity.Find(ModelId);
            DbEntity.Remove(model);
        }

        public IEnumerable<T> GetModel()
        {
           return DbEntity.ToList();
        }

        public T GetModelById(int ModelId)
        {
            return DbEntity.Find(ModelId);
        }

        public void InsertModel(T model)
        {
            DbEntity.Add(model);
        }

        public void Save()
        {
            _dataContext.SaveChanges();
        }

        public void UpdateModel(T model)
        {
            _dataContext.Entry(model).State = EntityState.Modified;
        }
    }
}