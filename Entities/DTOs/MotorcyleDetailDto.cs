using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MotorcyleDetailDto :IDto
    {
        public int MotorcycleId { get; set; }
        public string MotorcyleName { get; set; }
        public int BrandId { get; set; }
     
    }
}
                