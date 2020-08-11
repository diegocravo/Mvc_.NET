using Data.Infrastructure.Context;
using Domain.Model.Interfaces.Repositories;
using Domain.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure.Repositories
{
    public class MoleculaRepository : IMoleculaRepository
    {
        private readonly BibliotecaContext _bibliotecaContext;

        public MoleculaRepository(
            BibliotecaContext bibliotecaContext)
        {
            _bibliotecaContext = bibliotecaContext;
        }

        public MoleculaModel Create(MoleculaModel moleculaModel)
        {
            _bibliotecaContext.Add(moleculaModel);
            _bibliotecaContext.SaveChanges();

            return moleculaModel;
        }

        public void Delete(int id)
        {
            var moleculaModel = GetById(id);
            _bibliotecaContext.Remove(moleculaModel);
            _bibliotecaContext.SaveChanges();
        }

        public IEnumerable<MoleculaModel> GetAll()
        {
            return _bibliotecaContext
                .Moleculas
                .Include(l => l.Autor);
        }

        public MoleculaModel GetById(int id)
        {
            return _bibliotecaContext.Moleculas.Include(m => m.Autor).FirstOrDefault(l => l.Id == id);
        }

        public MoleculaModel Update(MoleculaModel moleculaModel)
        {
            _bibliotecaContext.Update(moleculaModel);
            _bibliotecaContext.SaveChanges();

            return moleculaModel;
        }
    }
}
