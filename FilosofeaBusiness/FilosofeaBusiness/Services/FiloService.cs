using System;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.RepositoryInterfaces;
using FilosofeaDomain.ServiceInterfaces;

namespace FilosofeaBusiness.Services
{
    public class FiloService : IFiloService
    {
        private IFiloRepository _filoRepository;

        public FiloService(IFiloRepository filoRepository)
        {
            _filoRepository = filoRepository;
        }

        public IAutor getAutor(long id)
        {
            var result = _filoRepository.GetAutor(id);

            return result;
        }

        public IEnumerable<IAutor> getAutoresByDate(DateTime fecha)
        {
            var result = _filoRepository.getAutoresByDate(fecha);

            return result;
        }
    }
}
