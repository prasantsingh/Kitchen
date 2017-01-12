using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class ItemUnitMasterEntity
    {
        public string Unit_Name { get; set; }
        public Nullable<int> Unit_Status { get; set; }
        public Nullable<System.DateTime> Unit_DateTime { get; set; }
    }

}