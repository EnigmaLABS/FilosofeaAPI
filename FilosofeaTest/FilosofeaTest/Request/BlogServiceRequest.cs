using System;
using System.Collections.Generic;

using FilosofeaDomain.DTO.Request;
using FilosofeaDomain.Entities;
using FilosofeaTest.EndToEndTest.Services;

namespace FilosofeaTest.Request
{
    public static class BlogServiceRequest
    {
        public static PutEntradaRequest PutEntrada_OK_Request(this BlogServiceTest blogServiceTest)
        {
            PutEntradaRequest request = new PutEntradaRequest()
            {
                Entrada = new Entrada()
                {
                    Titulo = "Test PutEntrada_OK",
                    Texto = "Test Text",
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
                    },
                    Categorias = new List<EntradaCategoria>()
                    {
                        new EntradaCategoria()
                        {
                            idEntradaCategoria = 1
                        }
                    }
                }
            };

            return request;
        }
    }
}
