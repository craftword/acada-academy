﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadaAcademy.ViewModels
{
    public class ItemRouteViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Location { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        [Required]
        public int Order { get; set; }
        [Required]
        public DateTime ActivityTime { get; set; }
    }
}
