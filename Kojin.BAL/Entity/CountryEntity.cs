using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity
{
    public class CountryEntity
    {
        public string cou_code { get; set; }
        public string name { get; set; }
        public string cou_name { get; set; }
        public string iso3 { get; set; }
        public Nullable<int> numcode { get; set; }
    }
}