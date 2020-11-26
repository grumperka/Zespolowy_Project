using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Zespolowy.Models
{
    public class CarPhoto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PathFile { get; set; }

        [StringLength(20)]
        public string MimeType { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime SendDate { get; set; }

        [Required]
        public int CarRepairId { get; set; }

        public virtual CarRepair CarRepair { get; set; }
    }
}
