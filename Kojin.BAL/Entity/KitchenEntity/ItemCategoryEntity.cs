using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class ItemCategoryEntity
    {
        public string Kit_id { get; set; }
        public string Item_Cat_id { get; set; }
        public string Item_Cat_Name { get; set; }
        public string Item_Cat_Desc1 { get; set; }
        public string Item_Cat_Desc2 { get; set; }
        public string Item_Cat_Desc3 { get; set; }
        public Nullable<int> Item_Cat_Status { get; set; }
        public Nullable<System.DateTime> Item_Cat_DateTime { get; set; }
    }


}