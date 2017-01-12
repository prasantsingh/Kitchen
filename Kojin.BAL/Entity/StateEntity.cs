using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity
{
    public class StateEntity
    {
        public long id { get; set; }
        public string province_name { get; set; }
        public string province_code { get; set; }
        public string cou_code { get; set; }
    }
}