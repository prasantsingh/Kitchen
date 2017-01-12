using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class KitchenEntity
    {
        public string Cust_id { get; set; }
        public string Kit_id { get; set; }
        public string Kit_Loc1 { get; set; }
        public string Kit_Loc2 { get; set; }
        public string Kit_Type { get; set; }
        public Nullable<decimal> App_Small_V { get; set; }
        public Nullable<decimal> Act_Small_V { get; set; }
        public Nullable<decimal> App_Meduim_V { get; set; }
        public Nullable<decimal> Act_Meduim_V { get; set; }
        public Nullable<decimal> App_Larger_V { get; set; }
        public Nullable<decimal> Act_Larger_V { get; set; }
        public Nullable<decimal> App_Extra_LV { get; set; }
        public Nullable<decimal> Act_Extra_LV { get; set; }
        public Nullable<int> Kit_Status { get; set; }
        public Nullable<System.DateTime> Kit_DateTime { get; set; }
    }
}