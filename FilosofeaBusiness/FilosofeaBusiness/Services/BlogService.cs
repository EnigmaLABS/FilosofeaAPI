using System;
using System.Collections.Generic;

using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.RepositoryInterfaces;
using FilosofeaDomain.ServiceInterfaces;

namespace FilosofeaBusiness.Services
{
    public class BlogService : IBlogService
    {
        private IBlogRepository _blogRepository;

        public BlogService(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public IEnumerable<IEntrada> getEntradas(int idUser, DateTime? fechadesde, DateTime? fechahasta, int? top)
        {
            var result = _blogRepository.GetEntradasByDate(idUser, (DateTime)fechadesde, (DateTime)fechahasta);

            return result;
        }
    }
}
