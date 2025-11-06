using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface ILibraryService
    {
        Library Create(Library library);
        Library Update(int id, Library library);
        Library Get(Predicate<Library> predicate);
        List<Library> GetAll(Predicate<Library> predicate);
        void Delete(int id);
    }
}
