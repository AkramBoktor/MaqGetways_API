using Microsoft.EntityFrameworkCore;
using MaqGetway.Domain.Entities;
using MaqGetway.Domain.IJsonItem;
using MaqGetway.Domain.Interfaces;
using MaqGetway.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MaqGetway.Infrastructure.Repository
{
    public class JsonItemRepository : GenericRepository<JsonItem>,IJsonItemRepository
    {
        public JsonItemRepository(JsonItemContext context) : base(context) { }


    }
}

