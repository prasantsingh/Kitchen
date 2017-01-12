using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class ItemCodeEntity
    {
        public string Item_Cat_id { get; set; }
        public string Item_id { get; set; }
        public string Item_Name { get; set; }
        public string Item_Desc1 { get; set; }
        public string Item_Desc2 { get; set; }
        public string Item_UnitMeasure { get; set; }
        public Nullable<int> Item_Status { get; set; }
        public Nullable<System.DateTime> Item_DateTime { get; set; }
    }

}