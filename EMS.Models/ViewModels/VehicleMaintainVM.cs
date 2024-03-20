using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Models.ViewModels
{
    public class VehicleMaintainVM
    {
        public VehicleMaintain VehicleMaintain { get; set; }
        [ValidateNever]
        public Vehicle? Vehicles { get; set; }
    }
}
