using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BindCheckListToModel.Models
{
    
        public class CountryModel
        {
            public List<Country> CountryList { get; set; }
        public bool isHome { get; set; }
    }
        public class Country
        {
            public int countryId { get; set; }
            public bool CheckedStatus { get; set; }
            public string CountryName { get; set; }

          
        }

    
}