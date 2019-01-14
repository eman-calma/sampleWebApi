using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TotalSynergy.Common.Models;

namespace TotalSynergy.Data
{
    public interface IRepository<T> where T : BaseModel
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }   
}
