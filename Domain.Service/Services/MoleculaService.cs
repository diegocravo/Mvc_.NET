using Domain.Model.Interfaces.Repositories;
using Domain.Model.Interfaces.Services;
using Domain.Model.Models;
using System.Collections.Generic;

namespace Domain.Service.Services
{
    public class MoleculaService : IMoleculaService
    {
        private readonly IMoleculaRepository _moleculaRepository;

        public MoleculaService(
            IMoleculaRepository moleculaRepository)
        {
            _moleculaRepository = moleculaRepository;
        }

        public MoleculaModel Create(MoleculaModel moleculaModel)
        {
            return _moleculaRepository.Create(moleculaModel);
        }

        public void Delete(int id)
        {
            _moleculaRepository.Delete(id);
        }

        public IEnumerable<MoleculaModel> GetAll()
        {
            return _moleculaRepository.GetAll();
        }

        public MoleculaModel GetById(int id)
        {
            return _moleculaRepository.GetById(id);
        }

        public MoleculaModel Update(MoleculaModel moleculaModel)
        {
            return _moleculaRepository.Update(moleculaModel);
        }
    }
}
