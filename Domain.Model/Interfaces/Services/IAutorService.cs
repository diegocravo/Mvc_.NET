using Domain.Model.Models;
using System.Collections.Generic;

namespace Domain.Model.Interfaces.Services
{
    public interface IAutorService
    {
        IEnumerable<AutorModel> GetAll();
        AutorModel GetById(int id);
        AutorModel Create(AutorModel autorModel);
        AutorModel Update(AutorModel autorModel);
        void Delete(int id);
    }
}
