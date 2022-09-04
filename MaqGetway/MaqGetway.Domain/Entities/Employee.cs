using MaqGetway.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MaqGetway.Domain.Entities
{
    public class Employee
    {
    
        public string Id { get; set; }

        public string Name { get; set; }

        public int Type { get; set; } 


    }
}
