﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Dto
{
    public class CategoryDto
    {
        public string Name { get; set; }
        public int InternalSubCategory { get; set; }
        public string Brief { get; set; }
    }
}
