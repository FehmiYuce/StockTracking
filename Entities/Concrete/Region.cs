﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string? Description { get; set; }
    }
}
