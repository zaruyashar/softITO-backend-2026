using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RepositUnitWorkApp.Model
{
    public class VehicleType
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string Explanation { get; set; }
    }
}
