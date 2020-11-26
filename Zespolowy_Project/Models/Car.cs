using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zespolowy.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string OwnerName { get; set; }

        [Required]
        [StringLength(200)]
        public string OwnerAddress { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [StringLength(100)]
        public string NumerPlate { get; set; }

        [Required]
        public int Mileage { get; set; }
    }
}
