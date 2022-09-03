using Microsoft.EntityFrameworkCore;
using MaqGetway.Domain.Entities;
using MaqGetway.Domain.IJsonItem;
using MaqGetway.Domain.Interfaces;
using MaqGetway.Infrastructure.Context;
using MaqGetway.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaqGetway.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public Domain.IJsonItem.IJsonItemRepository JsonItemRepository { get; }
        private JsonItemContext context;

        public UnitOfWork(JsonItemContext Context, Domain.IJsonItem.IJsonItemRepository jsonItemRepository)
        {
            context = Context;
            JsonItemRepository = jsonItemRepository;
        }

   
        public int CompleteAsync()
        {
            return context.SaveChanges();

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }
    }
}


