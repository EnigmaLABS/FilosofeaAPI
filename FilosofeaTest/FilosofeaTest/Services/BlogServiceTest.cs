using System;
using System.Collections.Generic;
using Xunit;

using FilosofeaDomain.DTO.Request;
using FilosofeaDomain.Entities;
using FilosofeaDomain.ServiceInterfaces;

namespace FilosofeaTest.Services
{
    public class BlogServiceTest
    {
        private IBlogService _blogService;

        public BlogServiceTest(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [Fact]
        public void PutEntrada_OK()
        {

            PutEntradaRequest request = new PutEntradaRequest()
            {
                Entrada = new Entrada()
                {
                    Titulo = "Test PutEntrada_OK",
                    Hl1 = "H1 Test",
                    Hl2 = "H2 Test",
                    Usuario = new Usuario()
                    {
                        IdUsuario = 1
                    },
                    Autores = new List<Autor>()
                    {
                        new Autor()
                        {
                            IdAutor = 1
                        }
                    },
                    estadosEntradas = new EstadosEntradas()
                    {
                        idEstadoEntrada = 1
                    }
                }
            };

            _blogService.PutEntrada(request);

            Assert.True(1==1);
        }
    }
}
