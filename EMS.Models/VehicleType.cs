﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models
{
    public class VehicleType
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        [DisplayName("Vehicle Type")]
        public string? Name { get; set; }
    }
}
