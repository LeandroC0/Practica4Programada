using Practica4.Domain.Entities;
using Practica4.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Practica4.Aplicacion.Chiste
{
    public class ChisteService : IChisteService
    {
        private readonly IChisteRepository _chisteRepository;

        public ChisteService(IChisteRepository chisteRepository)
        {
            _chisteRepository = chisteRepository;
        }

        public IEnumerable<ChisteDto> GetAllChistes()
        {
            return _chisteRepository.GetAllChistes()
                        .Select(c => new ChisteDto
                        {
                            Id = c.Id,
                            TextoChiste = c.TextoChiste
                        });
        }

        public ChisteDto GetChisteById(int id)
        {
            var chiste = _chisteRepository.GetChisteById(id);
            if (chiste == null) return null;

            return new ChisteDto
            {
                Id = chiste.Id,
                TextoChiste = chiste.TextoChiste
            };
        }

        public void AddChiste(ChisteDto chisteDto)
        {
            var chiste = new Chistes
            {
                TextoChiste = chisteDto.TextoChiste
            };

            _chisteRepository.AddChiste(chiste);
        }

        public void UpdateChiste(ChisteDto chisteDto)
        {
            var chiste = new Chistes
            {
                Id = chisteDto.Id,
                TextoChiste = chisteDto.TextoChiste
            };

            _chisteRepository.UpdateChiste(chiste);
        }

        public void DeleteChiste(int id)
        {
            _chisteRepository.DeleteChiste(id);
        }
    }
}