using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        public void Create(T data);

        public void Delete(int id);

        public void Update(int id, T data);

        T Get(Predicate<T> predicate);

        T GetAll(Predicate<T> predicate);
    }
}
