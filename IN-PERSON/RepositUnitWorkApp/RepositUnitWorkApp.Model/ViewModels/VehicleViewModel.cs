using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositUnitWorkApp.Model.ViewModels
{
    public class VehicleViewModel
    {
        public Vehicle Vehicle { get; set; }
        public IEnumerable<SelectListItem> VehicleTypeList { get; set; }
    }
}
