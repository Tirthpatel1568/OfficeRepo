﻿    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
    public class City
    {   [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
       
    }
}