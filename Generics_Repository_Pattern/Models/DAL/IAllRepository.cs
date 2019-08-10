using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Repository_Pattern.Models.DAL
{
    interface IAllRepository<T> where T:class
    {
        IEnumerable<T> GetModel();
        T GetModelById(int ModelId);
        void InsertModel(T model);
        void UpdateModel(T model);
        void DeleteModel(T ModelId);
        void Save();
    }
}
