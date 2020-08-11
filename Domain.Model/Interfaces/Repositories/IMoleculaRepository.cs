using Domain.Model.Models;
using System.Collections.Generic;

namespace Domain.Model.Interfaces.Repositories
{
    public interface IMoleculaRepository
    {
        IEnumerable<MoleculaModel> GetAll();
        MoleculaModel GetById(int id);
        MoleculaModel Create(MoleculaModel moleculaModel);
        MoleculaModel Update(MoleculaModel moleculaModel);
        void Delete(int id);
    }
}
