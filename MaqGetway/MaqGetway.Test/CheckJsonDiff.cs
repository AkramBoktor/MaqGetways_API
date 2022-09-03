using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MaqGetway.Domain.Entities;
using MaqGetway.Domain.IJsonItem;
using MaqGetway.Domain.Interfaces;
using MaqGetway.Infrastructure.Context;
using MaqGetway.Infrastructure.Repository;
using MaqGetway.Infrastructure.UnitOfWork;
using MaqGetway.Apllication.Service.DTO;
using MaqGetway.Apllication.Service.IService;
using MaqGetway.Apllication.Service.Service;
using System;

namespace MaqGetwaye.Test
{
    public class CheckJsonDiff 
    {

        private static Microsoft.EntityFrameworkCore.DbContextOptions<JsonItemContext> options = new
      Microsoft.EntityFrameworkCore.DbContextOptionsBuilder<JsonItemContext>()
                      .UseSqlServer("Data Source=AKRAM-BOKTOR\\DEVELOPER;Initial Catalog=MaqGetwaye;Integrated Security=true")
        .Options;
    

       private JsonItemContext jsonContext = new JsonItemContext(options);


    [Fact(DisplayName = "Check if return the same as expected")]
        public void ShouldBeTheSame()
        {
            IJsonItemRepository jsonItemRepository = new JsonItemRepository(jsonContext);
            IUnitOfWork unitOfWork = new UnitOfWork(jsonContext,jsonItemRepository);

            IJsonItemDiffService _service = new JsonItemDiffService(unitOfWork);

            Task<JsonDiffDto> returnDTO = _service.GetComparison("1");

            Assert.True(returnDTO.Result.Message == "The data is the same");
        }




    }
}