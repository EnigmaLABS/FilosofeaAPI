using System;
using Xunit;

using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

using FilosofeaDomain.Entities;
using FilosofeaDomain.ServiceInterfaces;
using FilosofeaDomain.RepositoryInterfaces;
using FilosofeaBusiness.Services;
using FilosofeaData.Context;
using FilosofeaData.Repositories;
using FilosofeaTest.Request;

namespace FilosofeaTest.EndToEndTest.Services
{
    public class BlogServiceTest
    {
        private IConfiguration _configuration;
        private IBlogService _blogService;

        public IServiceProvider Services { get; private set; }

        public BlogServiceTest()
        {
            _configuration = InitConfiguration();
            ConfigureServices();
        }

        private void ConfigureServices()
        {
            var optionsBuilder = new DbContextOptionsBuilder<FilosofeadbContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));

            FilosofeadbContext context = new FilosofeadbContext(optionsBuilder.Options);
            IBlogRepository _blogRepository = new BlogRepository(context);
            _blogService = new BlogService(_blogRepository);
        }
        
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            return config;
        }

        [Fact]
        public void GetEntradas_ByDate_OK()
        { 

        }

        [Fact]
        public void PutEntrada_OK()
        {
            var request = this.PutEntrada_OK_Request();
            var result = _blogService.PutEntrada(request);

            Assert.NotNull(result);
            Assert.IsType<Entrada>(result);
        }
    }
}
