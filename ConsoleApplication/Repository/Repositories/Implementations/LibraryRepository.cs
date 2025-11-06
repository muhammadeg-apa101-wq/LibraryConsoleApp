using Domain.Models;
using Repository.Data;
using Repository.Exceptions;
using Repository.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Implementations
{
    public class LibraryRepository : IRepository<Library>
    {
        public void Create(Library data)
        {
            try
            {
                if (data is null) { throw new NotFoundException("Data not found"); }

                AppDbContext<Library>.datas.Add(data);  
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Library Get(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public Library GetAll(Predicate<Library> predicate)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Library data)
        {
            throw new NotImplementedException();
        }
    }
}
