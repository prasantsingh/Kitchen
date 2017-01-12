using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class ItemReplanishmentEntity
    {
        public string Cust_Id { get; set; }
        public string Kit_Id { get; set; }
        public string Rep_Window { get; set; }
        public string Reorder_value { get; set; }
        public Nullable<int> Item_Rep_Status { get; set; }
        public Nullable<System.DateTime> Item_Rep_DateTime { get; set; }
        public int Item_Rep_Sno { get; set; }
    }
}