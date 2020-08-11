using Domain.Model.Models;
using System.Collections.Generic;

namespace Domain.Model.Interfaces.Repositories
{
    public interface IAutorRepository
    {
        IEnumerable<AutorModel> GetAll();
        AutorModel GetById(int id);
        AutorModel Create(AutorModel autorModel);
        AutorModel Update(AutorModel autorModel);
        void Delete(int id);

    }
}
