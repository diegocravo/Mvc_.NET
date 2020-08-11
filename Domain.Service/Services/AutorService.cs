using Domain.Model.Interfaces.Repositories;
using Domain.Model.Interfaces.Services;
using Domain.Model.Models;
using System.Collections.Generic;

namespace Domain.Service.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;

        public AutorService(
            IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public AutorModel Create(AutorModel autorModel)
        {
            return _autorRepository.Create(autorModel);
        }

        public void Delete(int id)
        {
            _autorRepository.Delete(id);
        }

        public IEnumerable<AutorModel> GetAll()
        {
           return _autorRepository.GetAll();
        }

        public AutorModel GetById(int id)
        {
            return _autorRepository.GetById(id);
        }

        public AutorModel Update(AutorModel autorModel)
        {
            return _autorRepository.Update(autorModel);
        }
    }
}
