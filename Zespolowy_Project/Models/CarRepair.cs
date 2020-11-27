using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zespolowy.Models
{
    public class CarRepair
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string RepairDescryption { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime RepairStartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime RepairEndDate { get; set; }

        public int ManHours { get; set; }

        [Required]
        public float Cost { get; set; }

        [Required]
        public int CarServiceId { get; set; }
        public virtual CarService CarService { get; set; }

        [Required]
        public int CarId { get; set; }

        [JsonIgnore]
        public virtual Car Car { get; set; }


    }
}
