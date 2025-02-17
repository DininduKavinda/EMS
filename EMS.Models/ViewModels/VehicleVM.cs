﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models.ViewModels
{
    public class VehicleVM
    {
        public Vehicle Vehicle { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> VehicleTypeList { get; set; }
    }
}
