﻿using RESTAPIProjct.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPIProjct.Models
{
    public class CourseForCreationDto : CourseForManipulationDto
    {
        public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
