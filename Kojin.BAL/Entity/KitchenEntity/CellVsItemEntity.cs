using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class CellVsItemEntity
    {
        public int Sno { get; set; }
        public string Cust_Id { get; set; }
        public string Kit_Id { get; set; }
        public string Tray_Id { get; set; }
        public string Cell_Id { get; set; }
        public string Item_Cate { get; set; }
        public string Item_Code { get; set; }
        public string Item_Details { get; set; }
        public string Unit_Of_Measure { get; set; }
        public Nullable<decimal> Min_Qty { get; set; }
        public Nullable<decimal> Max_Qty { get; set; }
        public Nullable<decimal> Re_Order_Qty { get; set; }
        public string DSMB_Vendor { get; set; }
        public string Max_V_SMB_Vendor { get; set; }
        public string D_Big_Ret { get; set; }
        public string Min_V_Big_Ret { get; set; }
        public Nullable<int> CI_Status { get; set; }
        public Nullable<System.DateTime> CI_DateTime { get; set; }
    }
}