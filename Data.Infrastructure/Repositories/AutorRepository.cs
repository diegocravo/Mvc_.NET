using Data.Infrastructure.Context;
using Domain.Model.Interfaces.Repositories;
using Domain.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace Data.Infrastructure.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly BibliotecaContext _bibliotecaContext;

        public AutorRepository(
            BibliotecaContext bibliotecaContext)
        {
            _bibliotecaContext = bibliotecaContext;
        }

        public AutorModel Create(AutorModel autorModel)
        {
            _bibliotecaContext.Add(autorModel);
            _bibliotecaContext.SaveChanges();

            return autorModel;
        }

        public void Delete(int id)
        {
            var autorModel = GetById(id);
            _bibliotecaContext.Remove(autorModel);
            _bibliotecaContext.SaveChanges();
        }

        public IEnumerable<AutorModel> GetAll()
        {
            return _bibliotecaContext.Autores.AsEnumerable();
        }

        public AutorModel GetById(int id)
        {
            return _bibliotecaContext.Autores.FirstOrDefault(x => x.Id == id);
        }

        public AutorModel Update(AutorModel autorModel)
        {
            _bibliotecaContext.Update(autorModel);
            _bibliotecaContext.SaveChanges();

            return autorModel;
        }
    }
}
