﻿using MaqGetway.Domain.Enums;
using MaqGetway.Apllication.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaqGetway.Apllication.Service.IService
{
    public interface IJsonItemDiffService
    {
        Task<JsonItemDTO> Select(string id, JsonItemEnum position);
        Task<bool> Save(JsonItemDTO entity);
        Task<JsonDiffDto> GetComparison(string id);
    }
}

