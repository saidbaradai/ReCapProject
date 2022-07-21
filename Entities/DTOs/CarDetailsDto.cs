﻿using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailsDto :IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public int ModelYear { get; set; }
    }
}
