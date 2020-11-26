using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zespolowy.Models
{
    public class CarService
    {
        public int Id { get; set; }
        
        [StringLength(200)]
        public string AddressService { get; set; }

        [Required]
        [StringLength(200)]
        public string NameService { get; set; }
    }
}
